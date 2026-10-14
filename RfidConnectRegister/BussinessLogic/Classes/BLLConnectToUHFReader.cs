using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using RfidApiLib;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using System.Threading;
using System.Runtime.InteropServices;
using static RfidConnectRegister.BussinessLogic.Classes.Tools;
using System.Linq;

namespace RfidConnectRegister.BussinessLogic.Classes
{


    public class BllConectToDeskReader
    {
        ListBox lsbReadRFIDTags = new ListBox();
        public Boolean ConnectionStatus = false;
        public Boolean StartIndentifyStatus = false;
        System.Windows.Forms.Timer TimerClear;


        ConnectToDeskUHFReader _dalConnectToDeskUHFReader;
        ConnectToTinyUHFReader _dalConnectToTinyUHFReader;
        ConnectToT64UHFReader _dalConnectToT64UHFReader;

        System.Windows.Forms.Timer TimerRecconct;
        TextBox _txtIn = new TextBox();
        DataGridView _dgvIn = new DataGridView();

        int KindResult = 0;
        public BllConectToDeskReader()
        {
            try
            {
                TimerRecconct = new System.Windows.Forms.Timer();
                TimerRecconct.Interval = 200;
                TimerClear = new System.Windows.Forms.Timer()
                {
                    Interval = 20000
                };
                this.TimerRecconct.Tick += new System.EventHandler(this.TimerRecconct_Tick);
                this.TimerClear.Tick += new System.EventHandler(this.TimerClear_Tick);

                if (Properties.Settings.Default.DeskReaderType.ToString() == "1")
                {
                    try
                    {

                        _dalConnectToTinyUHFReader = new ConnectToTinyUHFReader((byte)Convert.ToInt32(  Properties.Settings.Default.ReaderPower));
                        if (_dalConnectToTinyUHFReader.ConnectionStatus)
                            ConnectionStatus = true;
                        else
                            ConnectionStatus = false;
                    }
                    catch
                    {
                        _dalConnectToTinyUHFReader = null;
                        ConnectionStatus = false;
                    }
                }
                else if (Properties.Settings.Default.DeskReaderType.ToString() == "0")
                {

                    _dalConnectToDeskUHFReader = new ConnectToDeskUHFReader((byte)Convert.ToInt32( Properties.Settings.Default.ReaderPower));
                    if (_dalConnectToDeskUHFReader.ConnectionStatus)
                        ConnectionStatus = true;
                    else
                        ConnectionStatus = false;

                }
                else if (Properties.Settings.Default.DeskReaderType == 2)//T64
                {
                    try
                    {

                        _dalConnectToT64UHFReader = new ConnectToT64UHFReader(Properties.Settings.Default.DeskPower);
                        if (_dalConnectToT64UHFReader.ConnectionStatus)
                            ConnectionStatus = true;
                        else
                            ConnectionStatus = false;
                    }
                    catch
                    {
                        _dalConnectToT64UHFReader = null;
                        ConnectionStatus = false;
                    }
                }
            }
            catch
            {
                _dalConnectToTinyUHFReader = null;
                ConnectionStatus = false;
            }
        }
        private void TimerRecconct_Tick(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.DeskReaderType.ToString() == "1")
            {

                if (_dalConnectToTinyUHFReader.EPCReed != "")
                {
                    string Serial = _dalConnectToTinyUHFReader.EPCReed;
                    if (Serial.Length > 24)
                    {

                        Serial = Serial.Substring((Serial.Length - 24), Serial.Length - (Serial.Length - 24));
                    }
                    if (!lsbReadRFIDTags.Items.Contains(Serial))
                    {
                        lsbReadRFIDTags.Items.Add(Serial);
                        if (Serial.Length == 24)
                        {
                            if (KindResult == 1)
                            {
                                _txtIn.Text = Serial;
                                StopIndentifyTagByDeskReader();
                            }
                            else if (KindResult == 2)
                            {
                                if (_txtIn.Text != Serial)
                                    _txtIn.Text = Serial;

                            }
                        }
                    }
                    _dalConnectToTinyUHFReader.EPCReed = "";

                }
            }
            else if (Properties.Settings.Default.DeskReaderType.ToString() == "0")
            {

                string Serial = _dalConnectToDeskUHFReader.DeskUHFReaderIndentify();
                if (!lsbReadRFIDTags.Items.Contains(Serial) && Serial != "")
                {
                    lsbReadRFIDTags.Items.Add(Serial);
                    if (Serial.Length == 24)
                    {
                        if (KindResult == 1)
                        {
                            _txtIn.Text = Serial;
                            StopIndentifyTagByDeskReader();
                        }
                        else if (KindResult == 2)
                        {
                            if (_txtIn.Text != Serial)
                                _txtIn.Text = Serial;

                        }
                    }
                }
            }
            else if (Properties.Settings.Default.DeskReaderType.ToString() == "2")
            {
                if (_dalConnectToT64UHFReader.EPCReed != null && _dalConnectToT64UHFReader.EPCReed != "")
                {
                    string Serial = _dalConnectToT64UHFReader.EPCReed;
                    if (Serial.Length > 24)
                    {

                        Serial = Serial.Substring((Serial.Length - 24), Serial.Length - (Serial.Length - 24));
                    }
                    if (!lsbReadRFIDTags.Items.Contains(Serial))
                    {
                        lsbReadRFIDTags.Items.Add(Serial);
                        if (Serial.Length == 24)
                        {
                            if (KindResult == 1)
                            {
                                _txtIn.Text = Serial;
                                StopIndentifyTagByDeskReader();
                            }
                            else if (KindResult == 2)
                            {
                                if (_txtIn.Text != Serial)
                                    _txtIn.Text = Serial;

                            }
                        }
                    }
                    _dalConnectToT64UHFReader.EPCReed = "";

                }

            }

            }

        public void ClearList()
        {
            lsbReadRFIDTags.Items.Clear();
        }


        private void TimerClear_Tick(object sender, EventArgs e)
        {
            lsbReadRFIDTags.Items.Clear();
        }

        public struct Para
        {
            public byte[] uii;
            public byte bank;
            public int addr;
            public int len;
            public byte[] pwd;
            public byte[] writedata;
            public bool withuii;
        }
        public void StartIndentifyTagByDeskReader(TextBox TXTOut, DataGridView DGVOut, int KindResultType)
        {
            _txtIn = TXTOut;
            _dgvIn = DGVOut;
            KindResult = KindResultType;// 1 > one Read -  2 >multi Read
            TimerRecconct.Enabled = true;

            if (Properties.Settings.Default.DeskReaderType.ToString() == "1")//Tiny
            {
                if (!ConnectionStatus)
                {
                    _dalConnectToTinyUHFReader = new ConnectToTinyUHFReader((byte)Convert.ToInt32(  Properties.Settings.Default.ReaderPower));
                    ConnectionStatus = true;
                }



                try
                {
                    if (ConnectionStatus)
                    {

                        if (_dalConnectToTinyUHFReader.Inventory(0x01))
                        {
                            Para para = new Para();
                            StartIndentifyStatus = true;
                            Object obj = (Object)para;



                            _dalConnectToTinyUHFReader.LoopEnable = true;

                            _dalConnectToTinyUHFReader.EPCThread = new Thread(new ParameterizedThreadStart(_dalConnectToTinyUHFReader.GetUiiThread_Timer));

                            _dalConnectToTinyUHFReader.EPCThread.IsBackground = true;

                            _dalConnectToTinyUHFReader.EPCThread.Start(obj);


                        }
                    }
                } 
                catch (Exception ex)
                {
                   // AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
                }

            }
            else if (Properties.Settings.Default.DeskReaderType.ToString() == "0")//6061
            {

                if (!ConnectionStatus)
                {
                    _dalConnectToDeskUHFReader = new ConnectToDeskUHFReader((byte)Convert.ToInt32(  Properties.Settings.Default.ReaderPower));
                    ConnectionStatus = true;
                }
                StartIndentifyStatus = true;
            }
            else if (Properties.Settings.Default.DeskReaderType == 2)//T64
            {
                try
                {

                    if (!ConnectionStatus)
                    {
                        _dalConnectToT64UHFReader = new ConnectToT64UHFReader(Properties.Settings.Default.DeskPower);
                        ConnectionStatus = true;
                    }

                    if (ConnectionStatus)
                    {
                        _dalConnectToT64UHFReader.T64UHFReaderIndentify();
                        StartIndentifyStatus = true;
                    }
                }
                catch (Exception ex)
                {
                    
                }

            }

        }
        public void StopIndentifyTagByDeskReader()
        {
            if (Properties.Settings.Default.DeskReaderType.ToString() == "1")
            {
                TimerRecconct.Enabled = false;
                TimerClear.Enabled = false;
                lsbReadRFIDTags.Items.Clear();
                StartIndentifyStatus = false;
                ConnectionStatus = false;
                _dalConnectToTinyUHFReader.CloseConnectionToTinyUHFReader();
            }
            else if (Properties.Settings.Default.DeskReaderType.ToString() =="0")
            {
                TimerRecconct.Enabled = false;
                TimerClear.Enabled = false;
                lsbReadRFIDTags.Items.Clear();
                StartIndentifyStatus = false;
                ConnectionStatus = false;
                _dalConnectToDeskUHFReader.CloseConnectionToDeskUHFReader();

            }
            else if (Properties.Settings.Default.DeskReaderType == 2)//T64
            {
                TimerClear.Enabled = false;
                lsbReadRFIDTags.Items.Clear();
                StartIndentifyStatus = false;
                ConnectionStatus = false;
                _dalConnectToT64UHFReader.CloseConnectionToT64UHFReader();
            }
        }

    }

    public class ConnectToT64UHFReader
    {

        public ConnectToT64UHFReader(byte power)
        {
            OpenConnectionToT64UHFReader(power);
        }




        public class Reader
        {

            /// <summary>
            /// 定义宏
            /// 定义一个动态链接库的文件名
            /// </summary>
            public const string PUBLIC_COM_PATH = @"VHLib.dll";//"ReaderDynamicLib.dll";//@"VHLib.dll";


            //==============================常量定义==============================
            public const int ID_MAX_SIZE_64BIT = 8;     //电子标签的ID号为64bit
            public const int ID_ATA_MAX_SIZE = 20;      //ATA电子标签的ID号为20byte
            public const int ID_MAX_SIZE_96BIT = 65;        //电子标签的ID号
            public const int MAX_LABELS = 255;      // 一次读写操作最多不超过100个标签

            //==============================API函数返回码==============================
            public const int _OK = 0x00;    // 操作成功

            //通信方面出错信息
            public const int _init_rs232_err = 0x81;    //  通信口初始化失败
            public const int _no_scanner = 0x82;    //  找不到读写器
            public const int _comm_error = 0x83;    //  收发通信数据出错
            public const int _baudrate_error = 0x84;    //  设置波特率出错
            public const int _init_net_error = 0x85;    //  网口初始化失败
            public const int _net_error = 0x86; //  网口收发通信数据出错

            // 读写器返回出错信息
            public const int _no_antenna = 0x01;   //天线连接失败
            public const int _no_label = 0x02;   //未检测到标签
            public const int _invalid_label = 0x03;   //非法标签
            public const int _less_power = 0x04;   //读写功率不够
            public const int _write_prot_error = 0x05;   //该区写保护
            public const int _check_sum_error = 0x06;   //校验和错误
            public const int _parameter_error = 0x07;   //参数错误
            public const int _memory_error = 0x08;   //数据区不存在
            public const int _password_error = 0x09;   //密码不正确
            public const int _killpassword_error = 0x0a;   //G2标签毁灭密码为全零
            public const int _nonlicet_command = 0x0b;   //非法命令
            public const int _nonlicet_user = 0x0c;   //密码不匹配的非法用户
            public const int _invalid_command = 0x1e;   //表示无效指令，如参数不正确的指令
            public const int _other_error = 0x1f;   //未知命令

            //函数输入错误
            public const int _no_cardID_input = 0x20;   //其它错误

            public struct ReaderDate
            {
                public byte Year;           //年
                public byte Month;          //月
                public byte Day;            //日
                public byte Hour;           //时
                public byte Minute;         //分
                public byte Second;         //秒
            }

            public struct HandsetParam
            {
                public byte TagType;        //标签种类：01H－ISO18000-6B，02H－EPCC1，04H－EPCC1G2，08H－EM4442。	(0)
                public byte Alarm;          //bit0-bit7 bit0:0-不报警，1-报警 bit1 0-不使用白名单 1-使用白名单。	(1)
                public byte OutputMode;     //数据输出模式：0-保存并直接输出,1-保存但不直接输出,2-不保存但直接输出  (2)
                public byte USBBaudRate;    //USB接口波特率 04-9600 05-19200  06-38400  07-57600 08-115200			(3)
                public byte BtBaudRate;     //蓝牙串口通讯波特率													(4)
                public byte Min_Frequence;  //发射微波信号频率的起始点，取值： 1~63。								(5)
                public byte Max_Frequence;  //发射微波信号频率的起始点，取值： 1~63。								(6)
                public byte Power;          //发射功率值，取值：0~160。												(7)
                public byte RFhrdVer1;      //RF模块硬件主版本														(8)
                public byte RFhrdVer2;      //RF模块硬件次版本														(9)
                public byte RFSoftVer1;     //RF模块软件主版本														(10)
                public byte RFSoftVer2;     //RF模块软件次版本														(11)
                public byte ISTID;          //是否读TID区															(12)
                public byte TIDAddr;        //TID读取起始位置														(13)
                public byte TIDLen;         //TID读取长度															(14)
                public byte ISUSER;         //是否读USER															(15)
                public byte USERAddr;       //USER读取起始位置														(16)
                public byte USERLen;        //USER读取长度															(17)
                public byte ISVibrate;      //电机振动,0-不，1-振动													(18)
                public byte Modutype;       //模块类型,0---R2000, 1---VM5E											(19)
                public byte Reserve21;      //保留																	(20)
                public byte Reserve22;      //保留																	(21)
                public byte Reserve23;      //保留																	(22)
                public byte Reserve24;      //保留																	(23)
                public byte Reserve25;      //保留																	(24)
                public byte Reserve26;      //保留																	(25)
                public byte Reserve27;      //保留																	(26)
                public byte Reserve28;      //保留																	(27)
                public byte Reserve29;      //保留																	(28)
                public byte Reserve30;      //保留																	(29)
                public byte Reserve31;      //保留																	(30)
                public byte Reserve32;      //保留
            }

            public struct ReaderBasicParam
            {
                public byte BaudRate;           //串口的通信速率，取值：00H~08H，代表速率同"设定波特率"命令。
                public byte Power;              //发射功率值，取值：20~30dBm。0-63
                public byte Min_Frequence;      //发射微波信号频率的起始点，取值： 0~59。
                public byte Max_Frequence;      //发射微波信号频率的终止点，取值： 0~59。
                public byte Reserve5;           //保留
                public byte WorkMode;           //读写器工作方式：0-主动方式，1-命令方式
                public byte ReaderAddress;      //RS485地址:1--254
                public byte NumofCard;          //最多读卡数目。
                public byte TagType;            //标签种类：01H－ISO18000-6B，02H－EPCC1，04H－EPCC1G2，08H－EM4442。
                public byte ReadDuration;       //(10)读卡持续时间：射频发射持续时间，只针对EM标签有效；0－10ms，1－20ms，2－30ms，3－40ms。
                public byte ReadTimes;          //读卡次数M：收到上位机读卡命令，读写器执行M次此命令。
                public byte EnableBuzzer;       //1:使能蜂鸣器0:不使能蜂鸣器
                public byte IP1;                //读写器IP地址
                public byte IP2;                //
                public byte IP3;                //
                public byte IP4;                //
                public byte Port1;              //读写器端口高位
                public byte Port2;              //
                public byte Mask1;              //读写器掩码1
                public byte Mask2;              //读写器掩码2
                public byte Mask3;              //读写器掩码3
                public byte Mask4;              //读写器掩码4
                public byte Gateway1;           //读写器地址网关
                public byte Gateway2;           //
                public byte Gateway3;           //
                public byte Gateway4;           //
                public byte MAC1;               //读写器MAC地址
                public byte MAC2;               //
                public byte MAC3;               //
                public byte MAC4;               //
                public byte MAC5;               //
                public byte MAC6;               //

            }

            //读写器主动工作参数
            public struct ReaderAutoParam
            {
                public byte AutoMode;           //(1)读标签模式：0-定时方式，1-触发方式。
                public byte TimeH;              //(2)标签保留时间：单位：秒s。缺省值为1。
                public byte TimeL;              //(3)
                public byte Interval;           //(4)0-10ms，1-20ms，2-30ms，3-50ms，4-100ms。缺省值为2。每隔设定时间主动读取一次标签。
                public byte NumH;               //(5)标签保留数目：缺省值为1。已读取的标签ID在读写器内存中保留的数目。
                public byte NumL;               //(6)
                public byte OutputManner;       //(7)数据输出格式：0-简化格式，1-标准格式，2-XML格式。缺省值为0。
                public byte OutInterface;       //(8)输出接口：0－RS232口，1－RS485口，2－RJ45口。缺省值为0。 3- Wiegand26    4- Wiegand34
                public byte WiegandWidth;       //(9)Weigand脉冲宽度值。
                public byte WiegandInterval;    //(10)Weigand脉冲间隔值。
                public byte ID_Start;           //(11)输出卡号的起始位，取值0～4。
                public byte IDPosition;         //(12)卡号在电子标签上的存放地址。EPC区--0, USER区--1，TID区--2
                public byte Report_Interval;    //(13)通知间隔：单位秒s。缺省值为1。每隔设定时间主动通知上位机一次。
                public byte Report_Condition;   //(14)通知条件：缺省值为1。0-被动通知，1-定时通知，2-增加新标签，3-减少标签，4-标签数变化	
                public byte Report_Output;      //(15)通知输出端
                public byte Antenna;            //(16)天线选择。1-ant1,2-ant2,4-ant4,8-ant8
                public byte TriggerMode;        //(17)触发方式(缺省值为0): 0-低电平 1-高电平
                public byte HostIP1;            //(18)被通知IP地址
                public byte HostIP2;            //(19)
                public byte HostIP3;            //(20)
                public byte HostIP4;            //(21)
                public byte Port1;              //(22)被通知端口
                public byte Port2;              //(23)
                public byte Reserve24;          //(24)被通知MAC,mofi by mqs 20121207 保留
                public byte ArgentinaSim;       //(25)//仿真模式(阿根廷),0--非仿真，1--仿真
                public byte CardTime1;          //(26)//读卡总超时1
                public byte CardTime2;          //(27)//读卡总超时2
                public byte ArgentinaMode;      //(28)//阿根的五种模式,0---Only ATA  只读ATA;1---Only EPC 只读EPC;2---Only EPC & TID 只读EPC+TID;3---ATA + EPC   读ATA+EPC;4---ATA + EPC & TID读ATA+EPC&TID
                public byte AnSleepTime;        //(29)//天线睡眠时间，单位：ms,(1-255)
                public byte Alarm;              //(30)0-不报警，1-报警。在定时和触发方式下是否检测报警。
                public byte Reserve31;          //(31)标准输出时间间隔，缺省值为120秒，1～255。
                public byte EnableRelay;        //(32)自动工作模式是否控制继电器1:控制 0:不控制
            }

            public static int PERFIXLEN = 20;  //前缀值的长度
                                               //读写器仿真键盘参数
                                               //对应的C#结构体
            [StructLayout(LayoutKind.Sequential, Pack = 1)]
            //[StructLayout(LayoutKind.Sequential)]
            public struct SimParam
            {
                public byte DataFormat;             //(0)数据格式两种：16进制--0, 10进制--1									
                                                    //public byte	DataBank;				//(1)EPC区--0, USER区--1，TID区--2
                public byte IsPerfix;               //(2)是否前缀，1--带,0--不带												
                                                    //public byte []PerfixCode;	//(3-22)前缀值,不够0x00填充													
                                                    //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
                [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
                public byte[] PerfixCode;
                public byte IsEnter;                //(23)是否回车换行, 1--带,0--不带											
                public byte StartAddress;           //(24)数据起始地址															
                public byte DataLen;                //(25)数据长度
                public byte OutputInterval; //(26)标准输出间隔(0-255)(0--输出ID之间无间隔)
                                            //public byte Demo1;
                                            //public byte Demo2;
                                            //public SimParam()
                                            //{
                                            //    PerfixCode = new byte[20];
                                            //}
            }

            public struct tagReaderFreq
            {
                public string chFreq;       //国家频率字符串

                public int iGrade;          //级数 = 50;
                public int iSkip;           //步进 = 500KHz;
                public int dwFreq;          //起始频率 = 902750;
                                            //公式：902750 + 级数*步进
            }

            //关于各个国家的频率
            //static const tagReaderFreq stuctFreqCountry[]=
            //{
            //	{"00---FCC(American)", 63, 400, 902600},							//(0),{"00---FCC(American)", 50, 500, 902750},
            //	{"01---ETSI EN 300-220(Europe300-220)", 11, 200, 865500},			//(1),{"01---ETSI EN 300-220(Europe300-220)", -1, -1, -1},
            //	{"02---ETSI EN 302-208(Europe302-208)", 4, 600, 865700},			//(2)
            //	{"03---HK920-925(Hong Kong)", 10, 500, 920250},						//(3)
            //	{"04---TaiWan 922-928(Taiwan)", 12, 500, 922250},					//(4)
            //	{"05---Japan 952-954(Japan)", 0, 0, 0},								//(5)
            //	{"06---Japan 952-955(Japan)", 14,200, 952200},						//(6)
            //	{"07---ETSI EN 302-208(Europe)", 4, 600, 865700},					//(7)
            //	{"08---Korea 917-921(Korea)", 6, 600, 917300},						//(8)
            //	{"09---Malaysia 919-923(Malaysia)", 8, 500, 919250},				//(9)
            //	{"10--China 920-925(China)", 16, 250, 920625},						//(10)
            //	{"11--Japan 952-956(Japan)", 4, 1200, 952400},						//(11)
            //	{"12--South Africa 915-919(Poncho)", 17, 200, 915600},				//(12)
            //	{"13--Brazil 902-907/915-928(Brazil)", 35, 500, 902750},			//(13)
            //	{"14--Thailand 920-925(Thailand)", -1, -1, -1},						//(14)
            //	{"15--Singapore 920-925(Singapore)", 10, 500, 920250},				//(15)
            //	{"16--Australia 920-926(Australia)", 12, 500, 920250},				//(16)
            //	{"17--India 865-867(India)", 4, 600, 865100},						//(17)
            //	{"18--Uruguay 916-928(Uruguay)", 23, 500, 916250},					//(18)
            //	{"19--Vietnam 920-925(Vietnam)", 10, 500, 920250},					//(19)
            //	{"20--Israel 915-917", 1, 0, 916250},								//(20)
            //	{"21--Philippines 918-920(Philippines)", 4, 500, 918250},			//(21)
            //	{"22--Canada 902-928(Canada)", 42, 500, 902750},					//(22)
            //	{"23--Indonesia 923-925(Indonesia)", 4, 500, 923250},				//(23)
            //	{"24--New Zealand 921.5-928(New Zealand)", 11, 500, 922250},		//(24)
            //};


            /// <summary>
            /// 
            /// </summary>
            public Reader()
            {

            }

            //==============================读写器应用函数定义==============================

            //连接读写器
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ConnectScanner(ref int hScanner, string szPort, int nBaudRate);

            //断开连接
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 DisconnectScanner(int hScanner);

            //通过USB连接读写器
            //apiReturn _stdcall VH_ConnectScannerUsb(HANDLE *hScanner);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_ConnectScannerUsb(ref int hScanner);

            //断开连接
            //apiReturn _stdcall VH_DisconnectScannerUsb(HANDLE hScanner);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_DisconnectScannerUsb(int hScanner);



            //检测USB在线,bDech---1为在线，否则不在线
            //typedef int (_stdcall *VH_fDechUsb)(BOOL bDech);
            public delegate int VH_fDechUsb(bool bDech);

            //初始化USB，可检测，传入函数地址
            //apiReturn _stdcall VH_InitUsb(VH_fDechUsb fFunc);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_InitUsb(VH_fDechUsb fFunc);

            //关闭USB,释放资源
            //apiReturn _stdcall VH_CloseUsb();


            //////////////////////////////////////////////////////////////////////////
            //用途:		设置通信方式
            //函数名:	Mux_SetCommunicationOpt
            //功能:		对手持机的通信模式进行设置
            //输入参数:	lOpt 为何种方式通信(0--TCP/IP, 1--RS232,2--RS485, 3--USB)
            //			lpRHand 为读写器的句柄
            //输出参数:	
            //返回值:	返回 0 为成功，其它失败
            //备注:		外部接口
            //////////////////////////////////////////////////////////////////////////
            //apiReturn _stdcall VH_SetCommunicationOpt(long lOpt, void *lpRWHand);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_SetCommunicationOpt(int lOpt, int lpRWHand);


            //////////////////////////////////////////////////////////////////////////
            //用途:		设置输出日志文件
            //函数名:	VH_SetLogFile
            //功能:		将日志功能写入到指定文件中
            //输入参数:	FileName 指全路径名
            //输出参数:	无
            //返回值:	返回0为成功，否则-1为失败
            //备注:
            //////////////////////////////////////////////////////////////////////////
            //BOOL _stdcall VH_SetLogFile(char* FileName)
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_SetLogFile(string FileName);


            //////////////////////////////////////////////////////////////////////////
            //用途:		写日志
            //函数名:	VH_WriteAppLogFile
            //功能:		将日志功能写入到指定文件中
            //输入参数:	FileName 指全路径名
            //			Line 指当前行号，这里暂不使用
            //			fmt 指格式化，你懂的
            //输出参数:	无
            //返回值:	返回0为成功，否则-1为失败
            //备注:
            //////////////////////////////////////////////////////////////////////////
            //int _stdcall VH_WriteAppLogFile(char* FileName, int Line, char* fmt, ...);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern int VH_WriteAppLogFile(string FileName, int Line, string strOutput);


            //==============================上载控制命令==============================
            //读取版本号
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_GetVersion(int hScanner, ref int wHardVer, ref int wSoftVer);
            //这样做的目的跟原来保持一致
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetVersion(int hScanner, int wHardVer, int wSoftVer);

            //启动/停止自动模式,0--stop, 1--start
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_AutoMode(int hScanner, int Mode);

            //启动/停止自动模式,0--stop, 1--start
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 AutoMode(int hScanner, int Mode);

            //增加名单
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 AddLableID(int hScanner, int Count, int Len, byte data);

            //删除名单
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 DelLableID(int hScanner);

            //增加单个或多个名单
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 DelSingleLableID(int hScanner, int Count, int Len, byte data);

            //获得名单
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetLableID(int hScanner, int startaddr, int listlen, int nTotal, int DataLen, byte data);

            //提交名单
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 SaveLableID(int hScanner);

            //获取读写器基本工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ReadHanderParam(int hScanner, HandsetParam pParam);

            //设置读写器基本工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 WriteHanderParam(int hScanner, HandsetParam pParam);

            //////////////////////////////////////////////////////////////////////////
            //用途:		取仿真键盘小模块参数
            //函数名:	ReadSimParam
            //功能:		将小模块的参数读出来
            //输入参数:	hScanner 为通信句柄,
            //输出参数:	pParam 为结构体指针
            //返回值:	返回 0 为成功，否则失败
            //备注:
            //////////////////////////////////////////////////////////////////////////
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ReadSimParam(int hScanner, ref SimParam pParam);
            //public static extern UInt16 ReadSimParam(int hScanner, byte[] pParam);

            //////////////////////////////////////////////////////////////////////////
            //用途:		设置仿真键盘小模块参数
            //函数名:	WriteSimParam
            //功能:		将小模块的参数写入其中
            //输入参数:	hScanner 为通信句柄,pParam 为结构体指针
            //输出参数:	
            //返回值:	返回 0 为成功，否则失败
            //备注:
            //////////////////////////////////////////////////////////////////////////
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 WriteSimParam(int hScanner, ref SimParam pParam);

            //设置读写器基本工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 WriteBasicParam(int hScanner, ref ReaderBasicParam pParam);

            //读取读写器自动工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ReadAutoParam(int hScanner, ref ReaderAutoParam pParam);

            //设置读写器自动工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 WriteAutoParam(int hScanner, ref ReaderAutoParam pParam);

            //设置厂工作参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 WriteFactoryParam(int hScanner, ref SimParam pParam);

            //恢复读写器出厂参数
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ReadFactoryParameter(int hScanner);

            //获得读写器工作频率范围
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetFrequencyRange(int hScanner, ref byte Frequency);

            //获得读写器ID
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetReaderID(int hScanner, byte[] ReaderID);

            //设置时间
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 SetReaderTime(int hScanner, ReaderDate time);

            //获得时间
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetReaderTime(int hScanner, ReaderDate time);

            //设置标签过滤器
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 SetReportFilter(int hScanner, int ptr, int len, byte mask);

            //获得标签过滤器
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetReportFilter(int hScanner, int ptr, int len, byte mask);

            //////////////////////////////////////////////////////////////////////////
            //用途:		获取时间段的记录总数
            //函数名:	VH_GetRecordNum
            //功能:		取记录总数
            //输入参数:	hScanner 通信句柄
            //			stime 为起始时间，etime 为结束时间
            //输出参数:	nTotal 为记录总数
            //返回值:	0--成功，其它失败
            //备注:		注意：如果起始时间和结束时间都为0,则取机器中全部记录。
            //////////////////////////////////////////////////////////////////////////
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_GetRecordNum(int hScanner, ReaderDate stime, ReaderDate etime, int nTotal);

            //////////////////////////////////////////////////////////////////////////
            //用途:		获取时间段的记录
            //函数名:	VH_GetRecord
            //功能:		取记录
            //输入参数:	hScanner 通信句柄
            //			stime 为起始时间，etime 为结束时间
            //输出参数:	nTotal 为记录总数, nDiNum 为第几条，从0开始算, data 指记录指针
            //返回值:	0--成功，其它失败
            //备注:		注意：如果起始时间和结束时间都为0,则取机器中全部记录。
            //////////////////////////////////////////////////////////////////////////
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 VH_GetRecord(int hScanner, ReaderDate stime, ReaderDate etime, int nTotal, int nDiNum, byte data);

            //获得记录
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetRecord(int hScanner, ReaderDate stime, ReaderDate etime, int nTotal, int taglen, byte data);

            //删除全部记录
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 DeleteAllRecord(int hScanner);

            //设置读写器ID
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 SetHandsetID(int hScanner, byte HandsetID);

            //获得读写器ID
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 GetHandsetID(int hScanner, byte HandsetID);


            //==============================EPC C1G2数据读写命令==============================
            //读取EPC1G2标签ID号
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_ReadLabelID(int hScanner, int mem, int ptr, int len, byte[] mask, byte[] IDBuffer, ref int nCounter, int Address);

            //读一块数据
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_ReadWordBlock(int hScanner, byte EPC_WORD, byte[] IDBuffer, byte mem, byte ptr, byte len, byte[] Data, byte[] AccessPassword, int Address);

            //写一块数据
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_WriteWordBlock(int hScanner, byte EPC_WORD, byte[] IDBuffer, byte mem, byte ptr, byte len, byte[] Data, byte[] AccessPassword, int Address);

            //写EPC
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_WriteEPC(int hScanner, byte len, byte[] Data, byte[] AccessPassword, int Address);


            //蜂鸣器报警,0--stop, 1--start
            //apiReturn _stdcall BuzzerAlarm(HANDLE hScanner,int iAlarm);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 BuzzerAlarm(int hScanner, int iAlarm);

            //设置读写保护状态
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_SetLock(int hScanner, byte EPC_WORD, byte[] IDBuffer, byte mem, byte Lock, byte[] AccessPassword, int Address);

            //读取读写器基本工作参数
            //apiReturn _stdcall ReadBasicParam(HANDLE hScanner, ReaderBasicParam * pParam);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 ReadBasicParam(int hScanner, ref ReaderBasicParam pParam);

            //设置读写器基本工作参数
            //apiReturn _stdcall WriteBasicParam(HANDLE hScanner, ReaderBasicParam * pParam);
            //[DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            //public static extern UInt16 WriteBasicParam(int hScanner, ref ReaderBasicParam pParam);

            //EAS状态操作命令
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_ChangeEas(int hScanner, byte EPC_WORD, byte[] IDBuffer, byte State, byte[] AccessPassword, int Address);
            //EAS报警命令
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern UInt16 EPC1G2_EasAlarm(int hScanner, int Address);

            /* ans = first + second */
            //实现两个16进制字符串的大数相加,如：
            // first:ABCDEF123456ABCDEF123456ABCDEF123456
            // second:ABCDEF123456ABCDEF123456ABCDEF123456
            //结果存入 ans:1579BDE2468AD579BDE2468AD579BDE2468AC
            //void _stdcall VH_big_num_add(char *ans, char *first, char *second);
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern void VH_big_num_add(StringBuilder ans, string first, string second);



            //////////////////////////////////////////////////////////////////////////
            //用途:		Bcd码转成ASC码并补空格
            //函数名:	Bcd2AscEx
            //功能:		将BCD码转成ASC码,即16进制转成字符串
            //输入参数:	bcd 指16进制的指针
            //			len 指其长度
            //输出参数:	bcd 指转后输出的指针
            //返回值:	无
            //备注:		与Bcd2Asc不同的是多出空格，如0x40 0x03==>40 03 ,而不是4003
            //////////////////////////////////////////////////////////////////////////
            //void _stdcall Bcd2AscEx(char *asc, char *bcd, int len)
            [DllImport(PUBLIC_COM_PATH, CharSet = CharSet.Ansi)]
            public static extern void Bcd2AscEx(StringBuilder asc, byte[] bcd, int len);


        }//end of public class DllComm

        public bool ConnectionStatus = false;

        public string EPCReed;
        UInt16 res;
        public int m_hScanner = -1, _OK = 0;
        public int ComMode = 0;//0--TCP/IP, 1--RS232,2--RS485, 3--USB
        public long lopt = 0;
        public string szPort;
        public byte connect_OK = 0;////0--no connect, 1--connected
        public int HardVersion = 0;
        public int SoftVersion = 0;
        public int RS485Address = 0;
        public List<string> _listEPC = new List<string>();

        public Reader.ReaderBasicParam gBasicParam = new Reader.ReaderBasicParam();
        public Reader.ReaderAutoParam gAutoParam = new Reader.ReaderAutoParam();
        public Reader.SimParam Param = new Reader.SimParam();//自模下仿真参数


        public byte gFre = 0;  //取哪个国家的频率

        public byte[] gReaderID = new byte[33];            //读写器ID

        public Reader.tagReaderFreq[] stuctFreqCountry = new Reader.tagReaderFreq[25];

        bool nStop = false;

        Thread teThreadEPC = null;//6c读线程
        public int nidEvent, mem, ptr, len;
        public int Read_times;
        public int m_antenna_sel;
        public byte[] AccessPassWord = new byte[4];
        public int nBaudRate = 0, Interval, EPC_Word;
        public byte[] IDTemp = new byte[120];
        private void OpenConnectionToT64UHFReader(byte power)
        {
            try
            {
                ConnectionStatus = false;


                int i = 0;

                szPort = Properties.Settings.Default.DeskUHFReader_Port.ToString();
                res = Reader.VH_ConnectScannerUsb(ref m_hScanner);


                {
                    for (i = 0; i < 3; i++)
                    {
                        //读版本
                        res = Reader.VH_GetVersion(m_hScanner, ref HardVersion, ref SoftVersion);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {

                        return;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        //读基本参数
                        res = Reader.ReadBasicParam(m_hScanner, ref gBasicParam);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {
                        return;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        //国家频率
                        res = Reader.GetFrequencyRange(m_hScanner, ref gFre);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {
                        return;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        //读auto参数
                        res = Reader.ReadAutoParam(m_hScanner, ref gAutoParam);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {
                        return;
                    }

                    for (i = 0; i < 3; i++)
                    {
                        //读ID
                        res = Reader.GetReaderID(m_hScanner, gReaderID);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {
                        return;
                    }
                    for (i = 0; i < 3; i++)
                    {
                        byte[] pPParam = new byte[26];
                        //读仿真参数
                        //res = Reader.ReadSimParam(m_hScanner, pPParam);
                        res = Reader.ReadSimParam(m_hScanner, ref Param);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    if (res != _OK)
                    {
                        return;
                    }
                    connect_OK = 1;//0--no connect, 1--connected
                    ConnectionStatus = true;
                    i = 0;
                    gBasicParam.Min_Frequence = (byte)(0 + 1);
                    gBasicParam.Max_Frequence = (byte)(10 + 1);
                    gBasicParam.Power = power;
                    gBasicParam.TagType = 0x04;

                    for (i = 0; i < 3; i++)
                    {

                        res = Reader.WriteBasicParam(m_hScanner, ref gBasicParam);
                        if (_OK == res)
                        {
                            break;
                        }
                    }
                    return;
                }
            }
            catch
            (Exception ex)
            {
                ConnectionStatus = false;

               
            }
        }

        public void CloseConnectionToT64UHFReader()
        {
            try
            {
                nStop = false;
                Thread.Sleep(800);
                try
                {
                    if (teThreadEPC != null)
                        teThreadEPC.Abort();
                }
                catch
                (Exception ex)
                {
                    
                }
                res = Reader.VH_DisconnectScannerUsb(m_hScanner);

                ConnectionStatus = false;
            }
            catch
            (Exception ex)
            {
                 
            }
        }


        public void T64UHFReaderIndentify()
        {

            if (0 == connect_OK)
            {
                nStop = false;
                return;
            }

            nStop = true;

            teThreadEPC = new Thread(new ThreadStart(this.ThreadReaderEPC));
            teThreadEPC.Start();

        }
        private void ThreadReaderEPC()
        {
            byte[] mask = new byte[512];
            byte[] IDBuffer = new byte[7680];
            int nCounter = 0;
            int res;

            while (nStop)
            {
                if (connect_OK == 0)
                {
                    nStop = false;
                    break;
                }

                // Attempt to read EPC labels
                res = Reader.EPC1G2_ReadLabelID(m_hScanner, 1, 0, 0, mask, IDBuffer, ref nCounter, RS485Address);
                if (res == Reader._OK)
                {
                    int ID_len = IDBuffer[0]; // IDBuffer[0] contains the word count
                    if (ID_len > 0)
                    {
                        byte[] epcData = new byte[ID_len * 2];
                        Array.Copy(IDBuffer, 1, epcData, 0, ID_len * 2);

                        // Convert EPC data to hex string
                        StringBuilder sb = new StringBuilder();
                        for (int j = 0; j < epcData.Length; j++)
                        {
                            sb.AppendFormat("{0:X2}", epcData[j]);
                        }
                        string epcString = sb.ToString();

                        bool exists = false;

                        try
                        {
                            if (epcString.Length > 24)
                            {
                                epcString = epcString.Substring(0, 24);
                            }
                        }
                        catch
                        {

                        }
                        List<string> IgnoreEpclist = null;
                        try
                        {
                            IgnoreEpclist = Properties.Settings.Default.IgnoreEpcList
                                                                                   .Split(',')
                                                                                   .Select(x => x.Trim())
                                                                                   .Where(x => !string.IsNullOrEmpty(x))
                                                                                   .ToList();

                        }
                        catch
                        {

                        }
                        if (IgnoreEpclist == null || !IgnoreEpclist.Contains(epcString))
                        {
                            if (_listEPC.FirstOrDefault(p => p.ToString() == epcString) != null) // Update count or other information if needed
                            {
                                exists = true;

                            }


                            if (!exists)
                            {
                                _listEPC.Add(epcString);

                            }
                            EPCReed = epcString;
                        }

                    }
                    else
                    {
                        // Optionally handle read errors or log them
                        // For example:
                        // Reader.VH_WriteAppLogFile("", 0, $"Read error: {res}");
                    }

                    // Small delay to prevent CPU overutilization
                    Thread.Sleep(10);
                }
            }
        }
    }


    public class ConnectToDeskUHFReader
    {

        private ListBox lsbReadRFIDTags = new ListBox();
        RfidApi Api = new RfidApi();
        public byte IsoReading = 0;
        public byte EpcReading = 0;
        public int TagCnt = 0;
        string[] tags = new string[1000];
        string[] DataForWriteToTag = new string[7];
        public Boolean ConnectionStatus = false;


        public ConnectToDeskUHFReader(byte power)
        {
            OpenConnectionToDeskUHFReader(power);
        }
        private void OpenConnectionToDeskUHFReader(byte power)
        {

            byte v1 = 0;
            byte v2 = 0;
            int status = Api.OpenCommPort( Properties.Settings.Default.DeskUHFReader_Port);
            if (status == 0)
            {
                status = Api.GetFirmwareVersion(ref v1, ref v2);
                lsbReadRFIDTags.Items.Clear();



                
               var freq = (byte)(2);
                

                Api.ClearReceiveBuf();
           var status2=   Api.SetRf(power, freq);
                Api.ClearIdBuf();
                Array.Clear(tags, 0, tags.Length);
                TagCnt = 0;
                EpcReading = 1;
                ConnectionStatus = true;
            }
            else
            {
                ConnectionStatus = false;

            }

        }

        public void CloseConnectionToDeskUHFReader()
        {
            try
            {
                Api.CloseCommPort();
                Api.ClearIdBuf();
                EpcReading = 0;
                ConnectionStatus = false;
            }
            catch
            (Exception ex)
            {
               // AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
            }
        }

        public string DeskUHFReaderIndentify()
        {
            string Serial = "";
            try
            {
                int status;
                int i, j;
                byte[,] IsoBuf = new byte[100, 12];
                byte tag_cnt = 0;
                string s = "";
                string s1 = "";
                byte tag_flag = 0;

                status = Api.EpcMultiTagIdentify(ref IsoBuf, ref tag_cnt, ref tag_flag);
                if (tag_cnt > 0)
                {
                    for (i = 0; i < tag_cnt; i++)
                    {
                        s = string.Empty;
                        s1 = string.Empty;
                        for (j = 0; j < 12; j++)
                        {
                            s = string.Format("{0:X2}", IsoBuf[i, j]);
                            s1 += s;
                        }
                        tags[TagCnt] = s1;

                        Serial = s1;
                        TagCnt++;


                    }
                }
                Api.ClearReceiveBuf();
                Api.ClearIdBuf();
            }
            catch (Exception ex)
            {
               // AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
            }
            return Serial;
        }
    }

    public class ConnectToTinyUHFReader
    {

        public ConnectToTinyUHFReader(byte power)
        {
            OpenConnectionToTinyUHFReader(power);
        }


        public struct SRECORD
        {
            public byte Sindex;
            public byte Slen;
            public byte Target;
            public byte Action;
            public byte bank;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
            public byte[] Ptr;
            public byte Len;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public byte[] Mask;
            public byte Truncate;
        }

        //标签信息
        public struct TagInfo
        {
            public string type;
            public string uii;
            public string tid;
            public string user;
            public string err;
        }



        public bool ConnectionStatus = false;

        public static bool Enabel_flg = false;      //使能标志，确定COM口与RLM连接成功或断开  
        public const string API_Path = "UhfReader_API_HID.dll";//DLL文件放到执行文件相同目录下
        public static IntPtr hCom;                  //COM设备参数

        public static byte flagCrc = 0x05;          //CRC、通信波特率标志; 
        public static byte bQ = 0x03;               //防碰撞操作的Q值 

        //       public static Main PublicDM;           //主窗体句柄，可选择保留使用
        public string EPCReed = "";
        public Thread EPCThread;//识别标签线程
        public bool LoopEnable = false;

        //用于标签信息的显示
        public static TagInfo tagInfo = new TagInfo();
        public static List<TagInfo> tagList = new List<TagInfo>();
        public static int[] cnt = new int[500];
        public static List<string> uiiList = new List<string>();
        public static double interval = 0.2;


        //代理
        public delegate void TagThread();
        public delegate void AddShow(string txt);



        /******************************************************************************************************************/
        /****************                             API 函数定义开始                                       **************/
        /******************************************************************************************************************/

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //open and connect  
        public static extern int UhfSearchHids(StringBuilder serials);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //open and connect  
        public static extern bool UhfReaderConnect(ref IntPtr hCom, string cPort, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //close and disconnect
        public static extern bool UhfReaderDisconnect(ref IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get status
        public static extern bool UhfGetPaStatus(IntPtr hCom, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get power
        public static extern bool UhfGetPower(IntPtr hCom, byte[] power, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //set power
        public static extern bool UhfSetPower(IntPtr hCom, byte option, byte power, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get fre
        public static extern bool UhfGetFrequency(IntPtr hCom, byte[] fremode, byte[] frebase, byte[] basefre, byte[] channnum, byte[] channspc, byte[] frehop, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //set fre
        public static extern bool UhfSetFrequency(IntPtr hCom, byte fremode, byte frebase, byte[] basefre, byte channnum, byte channspc, byte frehop, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get version
        public static extern bool UhfGetVersion(IntPtr hCom, byte[] serial, byte[] version, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get uid
        public static extern bool UhfGetReaderUID(IntPtr hCom, byte[] uid, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //inventory
        public static extern bool UhfStartInventory(IntPtr hCom, byte flagCrcAnti, byte initQ, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               // Get Received
        public static extern bool UhfReadInventory(IntPtr hCom, byte[] ulen, byte[] Uii);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //stop
        public static extern bool UhfStopOperation(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //inventory single
        public static extern bool UhfInventorySingleTag(IntPtr hCom, byte[] ulen, byte[] Uii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data
        public static extern bool UhfReadDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] readdata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write data
        public static extern bool UhfWriteDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] writedata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single
        public static extern bool UhfReadDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] readdata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write data single
        public static extern bool UhfWriteDataToSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] writedata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //erase data
        public static extern bool UhfEraseDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //lock
        public static extern bool UhfLockMemByEPC(IntPtr hCom, byte[] pwd, byte[] lockdata, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //kill
        public static extern bool UhfKillTagByEPC(IntPtr hCom, byte[] pwd, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //mutil write data
        public static extern bool UhfBlockWriteDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] writedata, byte[] error, byte[] status, byte[] writelen, byte[] ruuii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data for Cnt is zero
        public static extern bool UhfReadMaxDataByEPC(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte[] Uii, byte[] datalen, byte[] readdata, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Cnt is zero
        public static extern bool UhfReadMaxDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte[] datalen, byte[] readdata, byte[] Uii, byte[] uiiLen, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Anti Q
        public static extern bool UhfStartReadDataFromMultiTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte option, byte[] playload, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read data single for Anti Q
        public static extern bool UhfGetDataFromMultiTag(IntPtr hCom, byte[] status, byte[] ufData_len, byte[] ufReadData, byte[] usData_len, byte[] usReadData, byte[] uii, byte[] uiilen);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //erase data single
        public static extern bool UhfEraseDataFromSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //lock single
        public static extern bool UhfLockMemFromSingleTag(IntPtr hCom, byte[] pwd, byte[] lockdata, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //kill single
        public static extern bool UhfKillSingleTag(IntPtr hCom, byte[] pwd, byte[] Uii, byte[] error, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //mutil write data single
        public static extern bool UhfBlockWriteDataToSingleTag(IntPtr hCom, byte[] pwd, byte bank, byte[] ptr, byte cnt, byte[] writedata, byte[] Uii, byte[] uiilen, byte[] status, byte[] error, byte[] writelen, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //read register
        public static extern bool UhfGetRegister(IntPtr hCom, int radd, int rlen, byte[] status, byte[] reg, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //write register
        public static extern bool UhfSetRegister(IntPtr hCom, int radd, int rlen, byte[] reg, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //reset register
        public static extern bool UhfResetRegister(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //save register
        public static extern bool UhfSaveRegister(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //add select
        public static extern bool UhfAddFilter(IntPtr hCom, ref SRECORD pSRecord, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //delete select
        public static extern bool UhfDeleteFilterByIndex(IntPtr hCom, byte sindex, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get select
        public static extern bool UhfStartGetFilterByIndex(IntPtr hCom, byte sindex, byte snum, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //get select received
        public static extern bool UhfReadFilterByIndex(IntPtr hCom, byte[] status, ref SRECORD pSRecord);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //choose select
        public static extern bool UhfSelectFilterByIndex(IntPtr hCom, byte sindex, byte snum, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //sleep mode
        public static extern bool UhfEnterSleepMode(IntPtr hCom, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //start update
        public static extern bool UhfUpdateInit(ref IntPtr hCom, string cPort, byte[] status, byte[] RN32, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //send inverse
        public static extern bool UhfUpdateSendRN32(IntPtr hCom, byte[] RN32, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //start trans
        public static extern bool UhfUpdateSendSize(IntPtr hCom, byte[] status, byte[] filesize, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //tran package
        public static extern bool UhfUpdateSendData(IntPtr hCom, byte[] status, byte packnum, byte lastpack, int data_len, byte[] trandata, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]                               //end update
        public static extern bool UhfUpdateCommit(IntPtr hCom, byte[] status, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern void UhfCharToCString(byte[] byteinput, StringBuilder stroutput, int len);    //convert byte[] to string 

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern void UhfCStringToChar(StringBuilder strinput, byte[] byteoutput, int len);    //convert string to byte[]

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfBlockWriteEPCToSingleTag(IntPtr hCom, byte[] uAccessPwd, byte uCnt, byte[] uWriteData, byte[] uUii, byte[] uLenUii, byte[] uStatus, byte[] uErrorCode, byte[] uWritedLen, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfBlockWriteEPCByEPC(IntPtr hCom, byte[] uAccessPwd, byte uCnt, byte[] uUii, byte[] uWriteData, byte[] uErrorCode, byte[] uStatus, byte[] uWritedLen, byte[] RuUii, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfSetMultiANT(IntPtr hCom, byte[] AntStatus, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfGetMultiANT(IntPtr hCom, byte[] AntStatus, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfCheckANT(IntPtr hCom, byte[] ANT, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfChooseANT(IntPtr hCom, byte ANT, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfStartInventoryForMultiAnt(IntPtr hCom, byte flagAnti, byte initQ, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfReadInventoryFromMultiAnt(IntPtr hCom, byte[] ANT, byte[] uLenUii, byte[] uUii);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfStartReadDataForMultiAnt(IntPtr hCom, byte[] uAccessPwd, byte uBank, byte[] uPtr, byte uCnt, byte uOption, byte[] uPayLoad, byte flagCrc);

        [System.Runtime.InteropServices.DllImportAttribute(API_Path)]
        public static extern bool UhfGetDataFromMultiAnt(IntPtr hCom, byte[] ANT, byte[] uStatus, byte[] ufData_len, byte[] ufReadData, byte[] usData_len, byte[] usReadData, byte[] uUii, byte[] uLenUii);

        /******************************************************************************************************************/
        /****************                             API 函数定义结束                                       **************/
        /******************************************************************************************************************/



        public static bool CheckDigit(string sString)//判断字符串是否为十六进制数
        {
            int i;

            bool Res = false;

            char[] c = sString.ToUpper().ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[0-9]") || System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[A-F]"))
                    Res = true;
                else
                {
                    Res = false;
                    break;
                }
            }
            return Res;
        }

        public static bool CheckDecimal(string sString)//判断字符串是否为十进制数
        {
            int i;

            bool Res = false;

            char[] c = sString.ToUpper().ToCharArray();
            for (i = 0; i < c.Length; i++)
            {
                if (System.Text.RegularExpressions.Regex.IsMatch((c[i]).ToString(), "[0-9]"))
                    Res = true;
                else
                {
                    Res = false;
                    break;
                }
            }
            return Res;
        }

        public static string StringAddPlace(string InputStr)
        {
            if (InputStr.Length == 0)
                return "";

            string P_str = "";

            for (int i = 0; i < InputStr.Length / 2; i++)
            {
                P_str += InputStr.Substring(2 * i, 2) + " ";
            }

            return P_str;
        }

        public static void HexStringToBytes(string InputStr, byte[] OutPutByte)
        {
            if (InputStr.Length == 0)
                return;

            for (int strLen = 0; strLen < InputStr.Length / 2; strLen++)
                OutPutByte[strLen] = Convert.ToByte(InputStr.Substring(strLen * 2, 2), 16);
        }

        public static byte HexStringToByte(string InputStr)
        {
            if (InputStr.Length != 2)
                return 0x00;

            return Convert.ToByte(InputStr, 16);
        }

        public static string BytesToHexString(byte[] InPutByte, int ConvertLen)
        {
            string OutPutStr = "";
            try
            {
                for (int i = 0; i < ConvertLen; i++)
                {
                    OutPutStr += Convert.ToString((InPutByte[i] >> 4), 16);
                    OutPutStr += Convert.ToString((InPutByte[i] & 0x0F), 16);
                }
                return OutPutStr.ToUpper();
            }
            catch (Exception)
            {
                return "";
            }
        }


        public static string ByteToHexString(byte InputByte)
        {
            string OutPutStr = "";

            try
            {
                OutPutStr += Convert.ToString((InputByte >> 4), 16);
                OutPutStr += Convert.ToString((InputByte & 0x0F), 16);
                return OutPutStr.ToUpper();
            }
            catch (Exception)
            {
                return "";
            }
        }

        /*
        // 主窗体信息显示处理函数，可选择保留使用
        public static void ShowInfo(UhfReader_DEMO.Main objFrom, string info)   // 显示操作信息
        {
            objFrom.SetInfoText = info;
        }*/

        /// ////////////////////////////////////////////////////////////////////////////////////////////
        /// 数据窗口信息显示(循环显示时使用)    Show data on ListView contorl
        /// ////////////////////////////////////////////////////////////////////////////////////////////
        public static void ShowLoop()
        {
            //PublicDM.DataGVTags.Rows.Clear();

            //for (int i = 0; i < tagList.Count; i++)
            //{
            //    PublicDM.DataGVTags.Rows.Add((i + 1) + "", tagList[i].type, tagList[i].uii, tagList[i].uii.Length / 2, tagList[i].tid, tagList[i].tid.Length / 2, tagList[i].user, tagList[i].user.Length / 2, tagList[i].err, cnt[i]);
            //}
            //PublicDM.TbTagCnt.Text = uiiList.Count.ToString();
        }


        public static void CntToZero()
        {
            for (int i = 0; i < 500; i++)
            {
                cnt[i] = 0;
            }
        }

        public static void AddToTagList(string type, string uii, string tid, string user, string err)
        {
            tagInfo.type = type;
            tagInfo.uii = uii;
            tagInfo.tid = tid;
            tagInfo.user = user;
            tagInfo.err = err;

            int index = tagList.IndexOf(tagInfo);
            if (index == -1)
            {
                tagList.Add(tagInfo);
                int indexs = tagList.IndexOf(tagInfo);
                cnt[indexs] = 1;
            }
            else
            {
                cnt[index]++;
            }
        }

        public static void AddToShow(string str)
        {
            // PublicDM.TbShow.AppendText(str + "\r\n");
        }

        //汉字串转换成16进制字符串（Unicode）
        public static string HanziToUnicodeHexString(string hanziStr)
        {
            byte[] unicodebytes = Encoding.Unicode.GetBytes(hanziStr);

            string unicodehexStr = BytesToHexString(unicodebytes, unicodebytes.Length);

            return unicodehexStr;
        }

        //16进制字符串转换成汉字串（Unicode）
        public static string UnicodeHexStringToHanzi(string unicodehexStr)
        {
            int len = unicodehexStr.Length / 2;

            byte[] output = new byte[len];

            HexStringToBytes(unicodehexStr, output);

            string result = Encoding.Unicode.GetString(output);

            return result;
        }


        public static int SearchHids(ref string[] serials)
        {
            StringBuilder serialStr = new StringBuilder(1024);

            int hidCnt = UhfSearchHids(serialStr);

            if (hidCnt == 0)
            {
                return 0;
            }
            else
            {
                serials = serialStr.ToString().Split('|');
            }

            return hidCnt;
        }

        public static byte SelectBaudAndCrc(long lBaud, byte bCrc)
        {
            byte bRes = 0x04;
            if (lBaud == 9600)
                bRes = 0x00;
            else if (lBaud == 19200)
                bRes = 0x02;
            else if (lBaud == 57600)
                bRes = 0x04;
            else
                bRes = 0x06;

            if (bCrc != 0)
                bRes = (byte)(bRes | 0x01);

            flagCrc = bRes;
            return bRes;
        }


        public static bool ConnectRLM(string sPort)
        {
            if (sPort != null)
                return UhfReaderConnect(ref hCom, sPort, flagCrc);
            else return false;
        }


        public static bool DisConnectRLM()
        {
            return UhfReaderDisconnect(ref hCom, flagCrc);
        }


        public bool Inventory(byte flgAnti)
        {
            if (UhfStartInventory(hCom, flgAnti, bQ, flagCrc))
                return true;
            else
                return false;
        }


        public static bool ReadInventory(byte[] uLenUii, byte[] uUii)
        {
            if (UhfReadInventory(hCom, uLenUii, uUii))
                return true;
            else
                return false;
        }

        public static bool ReadInventoryFromMultiAnt(byte[] Ant, byte[] uLenUii, byte[] uUii)
        {
            if (UhfReadInventoryFromMultiAnt(hCom, Ant, uLenUii, uUii))
                return true;
            else
                return false;
        }

        public bool Stop()
        {
            if (UhfStopOperation(hCom, flagCrc))
                return true;
            else
                return false;
        }

        public void GetUiiThread_Timer(Object obj)
        {
            string Uii_str = "";
            int i;

            byte[] blen = new byte[1];
            byte[] buii = new byte[255];

            //    Para para = (Para)obj;

            do
            {
                Uii_str = "";

                if (ReadInventory(blen, buii))
                {
                    System.Media.SystemSounds.Asterisk.Play();

                    Uii_str = BytesToHexString(buii, blen[0]);

                    tagInfo.type = "Inventory";

                    tagInfo.uii = Uii_str;
                    tagInfo.tid = "";
                    tagInfo.user = "";
                    tagInfo.err = "";

                    if (!uiiList.Contains(Uii_str))
                    {
                        uiiList.Add(Uii_str);
                    }

                    int index = tagList.IndexOf(tagInfo);
                    if (index == -1)
                    {
                        tagList.Add(tagInfo);
                        //         LoopEnable = false;
                        int indexs = tagList.IndexOf(tagInfo);
                        cnt[indexs] = 1;
                        EPCReed = Uii_str;
                    }
                    else
                    {
                        cnt[index]++;
                        EPCReed = Uii_str;

                    }
                }
                else { Console.WriteLine("No tag be found"); }

            } while (LoopEnable);

            //   TagThread tagThread = new TagThread(ShowLoop);
            //  PublicDM.BeginInvoke(tagThread);

            //if (EPCThread != null)
            //{
            //    EPCThread.Abort();
            //}
        }


        private void OpenConnectionToTinyUHFReader(byte power)
        {
            try
            {

                string[] serials = new string[32];

                int hidCnt = SearchHids(ref serials);



                string comStr = serials[0];


                flagCrc = SelectBaudAndCrc(57600, 0x01);



                if (ConnectRLM(comStr))
                {
                    ConnectionStatus = true;


                }
            }
            catch
            (Exception ex)
            {
                ConnectionStatus = false;

              //  AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
            }





        }

        public void CloseConnectionToTinyUHFReader()
        {
            try
            {
                LoopEnable = false;

                Stop();
                Thread.Sleep(1000);

                if (EPCThread != null)
                {
                    EPCThread.Abort();
                }
                if (DisConnectRLM())
                {


                    ConnectionStatus = false;

                }

            }
            catch
            (Exception ex)
            {
                //AvizheLog.ExceptionLogger.Write(Application.StartupPath + "\\Exceptions", ex);
            }
        }



        public void TinyUHFReaderIndentify(TextBox _txt, DataGridView _dgv, ListBox _lstTagReeded, int KindResult)
        {

        }
    }

}
