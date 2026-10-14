using System;
using System.Windows.Forms;
using RfidApiLib;

namespace RfidConnectRegister.BussinessLogic.Classes
{
    internal class ConnectTo6061 : IDisposable
    {
        private ReadTagFrom6061 _readTagFrom6061;
        private readonly ListBox _lsbReadRfidTags = new ListBox();
        public bool ConnectionStatus;
        public bool StartIndentifyStatus;
        private readonly Timer _timerRecconct;
        private readonly Timer _timerClear;
        private TextBox _txtIn = new TextBox();
        private readonly string _port;
        private readonly int _power;

        public ConnectTo6061(string portString, int power)
        {
            _timerRecconct = new Timer();

            _timerClear = new Timer
            {
                Interval = 20000
            };

            _port = portString;
            _power = power;
            _timerRecconct.Tick += TimerRecconct_Tick;
            _timerClear.Tick += _timerClear_Tick;
            _readTagFrom6061 = new ReadTagFrom6061(_port, _power);
            ConnectionStatus = _readTagFrom6061.ConnectionStatus;
        }

        private void _timerClear_Tick(object sender, EventArgs e)
        {
            _lsbReadRfidTags.Items.Clear();

            _readTagFrom6061.Api.ClearReceiveBuf();

            _readTagFrom6061.Api.ClearIdBuf();
            Array.Clear(_readTagFrom6061.Tags, 0, _readTagFrom6061.Tags.Length);
        }

        private void TimerRecconct_Tick(object sender, EventArgs e)
        {
            var serial = _readTagFrom6061.DeskUhfReaderIndentify();

            if (_lsbReadRfidTags.Items.Contains(serial))
                return;
            _lsbReadRfidTags.Items.Add(serial);
            if (serial.Length == 24)
                _txtIn.Text = serial;
        }

        public void StartIndentifyTagByDeskUhfReader(TextBox txtOut)
        {
            if (!ConnectionStatus)
            {
                _readTagFrom6061 = new ReadTagFrom6061(_port, _power);
                ConnectionStatus = true;
            }

            _txtIn = txtOut;
            _timerRecconct.Enabled = true;
            StartIndentifyStatus = true;
        }

        public void StopIndentifyTagByDeskUhfReader()
        {
            _timerRecconct.Enabled = false;

            StartIndentifyStatus = false;
            ConnectionStatus = false;
            _readTagFrom6061.CloseConnectionToDeskUhfReader();
            _lsbReadRfidTags.Items.Clear();

        }

        public void Dispose()
        {
            if (_lsbReadRfidTags != null) _lsbReadRfidTags.Dispose();
            if (_timerRecconct != null) _timerRecconct.Dispose();
            if (_txtIn != null) _txtIn.Dispose();
            if (_timerRecconct != null) _timerRecconct.Dispose();
            if (_timerClear != null) _timerClear.Dispose();
        }
    }

    public class ReadTagFrom6061
    {
        private readonly ListBox _lsbReadRfidTags = new ListBox();
        public  readonly RfidApi Api = new RfidApi();
        public byte IsoReading = 0;
        public byte EpcReading;
        public int TagCnt;
        public  string[] Tags = new string[1000];
        public bool ConnectionStatus;
        private readonly string _port;
        private readonly int _power;

        public ReadTagFrom6061(string com, int power)
        {
            _port = com;
            _power = power;
            OpenConnectionToDeskUhfReader();
        }

        private void OpenConnectionToDeskUhfReader()
        {

            byte v1 = 0;
            byte v2 = 0;
            int status = Api.OpenCommPort(_port);
            if (status == 0)
            {
                Api.BaudRate = 9600;
                Api.GetFirmwareVersion(ref v1, ref v2);
                _lsbReadRfidTags.Items.Clear();

                Api.ClearReceiveBuf();

                Api.ClearIdBuf();
                Array.Clear(Tags, 0, Tags.Length);
                TagCnt = 0;
                EpcReading = 1;

                var pwr = (byte) _power;
                const byte freq = 2;
                Api.SetRf(pwr, freq);

                ConnectionStatus = true;
            }
            else
            {
                ConnectionStatus = false;
            }
        }

        public void CloseConnectionToDeskUhfReader()
        {
            try
            { Api.CloseCommPort(); }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }

            Api.ClearIdBuf();
            EpcReading = 0;
            ConnectionStatus = false;
        }

        public string DeskUhfReaderIndentify()
        {
            var serial = string.Empty;
            try
            {
                var isoBuf = new byte[100, 12];
                byte tagCnt = 0;
                byte tagFlag = 0;

                Api.EpcMultiTagIdentify(ref isoBuf, ref tagCnt, ref tagFlag);
                if (tagCnt > 0)
                {
                    int i;
                    for (i = 0; i < tagCnt; i++)
                    {
                        var s1 = string.Empty;
                        int j;
                        for (j = 0; j < 12; j++)
                        {
                            var s = string.Format("{0:X2}", isoBuf[i, j]);
                            s1 += s;
                        }
                        
                        Tags[TagCnt] = s1;
                        serial = s1;
                        TagCnt++;
                    }
                }

                Api.ClearReceiveBuf();
                Api.ClearIdBuf();
                Tags = new string[1000];
                TagCnt = 0;
            }
            catch (Exception ex)
            {
                Tools.ExceptionLogger.WriteExceptionLogs(ex);
            }

            return serial;
        }
    }
}
