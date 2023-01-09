using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCallerIDNew
{

    /*  static class ImportLibrary
      {
          const String DLL_LOCATION = @"DllTechnoCaller.dll";

          [DllImport(DLL_LOCATION, CharSet = CharSet.Ansi,
           CallingConvention = CallingConvention.StdCall)]
          [return: MarshalAs(UnmanagedType.BStr)]
          public static extern string GetVerDll();
      }*/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // public [MarshalAs(UnmanagedType.BStr)]String  myString;

        int WithoutDeleteMemory = 2;
        int WithDeleteMemory = 1;
        public const string path = "DllTechnoCaller.dll";

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        //public static extern short GetNewAnswer(byte[] data);
        public static extern short GetNewAnswer(byte[] data);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int GetOfflineData(int DeviceIndex, int TypeOfClear);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetLastStatus(int DeviceIndex);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void SetIpServer(string MyIp);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]

        public static extern bool SendLastCommandToNetwork(string MyIp);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetVerDll(out IntPtr version);
        //static class getversion
        //{
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        //[return: MarshalAs(UnmanagedType.BStr)]
        public static extern void GetVerDevice(out IntPtr version);
        //}
        //[DllImport(path)]
        //[return: MarshalAs(UnmanagedType.HString)]
        //public static extern string GetVerDevice();

        //public static string GetAllValidProjects()
        //{
        //    string s = GetVerDevice();
        //    return s;
        //}

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetFirmware_Ver(out IntPtr version);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void EnableFSKDataLog(int DeviceIndex);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetListDevice();

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern int Get_Setting(out int DTMF_Call_In_Wait, out int DTMF_Call_Out_Wait,
                     out int Missed_Call_Counter, out int Len_Before_FSK_Data,
                     out int After_FSK_Sample_Len, out int Logic0_Sample_Len,
                     out int Logic1_Sample_Len, out int Differ_Lgic01_Len_FSK,
                     out int Differ_Data_Buffer_Len);

        [DllImport(path, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern int Set_Setting(int DTMF_Call_In_Wait, int DTMF_Call_Out_Wait,
                                              int Missed_Call_Counter, int Len_Before_FSK_Data,
                                              int After_FSK_Sample_Len, int Logic0_Sample_Len,
                                              int Logic1_Sample_Len, int Differ_Lgic01_Len_FSK,
                                              int Differ_Data_Buffer_Len);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern bool Default_Factory();


        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void Get_Line_NO(out IntPtr noline);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern Boolean Save_Offline(Boolean ISSave);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void Set_Password(string Pass);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern Boolean Send_CMDToCom(Boolean IsSend);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "Get_CMDToCom")]
        public static extern Boolean Get_CMDToCom(out Boolean IsSend);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern Boolean Get_Offline(out Boolean ISSave);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetCallerID(out IntPtr DeviceIndex, out IntPtr LineIndex,byte[] CallerIDNumber);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetDialNumber(short DeviceIndex, short LineIndex, short DialNumber);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetAnswer(out IntPtr DeviceIndex, out IntPtr LineIndex);

        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetOffline(out IntPtr DeviceIndex, out string TypeOfCallerID, out string CallerIDNumber);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetDialNumber2(out IntPtr DeviceIndex, out IntPtr LineIndex,byte[] DialNumber);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetRing(out IntPtr DeviceIndex, out IntPtr LineIndex, out IntPtr CountRing);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetLineDisconnect(out IntPtr DeviceIndex, out IntPtr LineIndex);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetHockOff(out IntPtr DeviceIndex, out IntPtr LineIndex);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetDeviceConnect(out IntPtr DeviceIndex, out IntPtr DeviceSerial, out IntPtr CountLine);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
        public static extern void GetHockOn(out IntPtr DeviceIndex, out IntPtr DeviceSerial, out int TimeSec);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetMissedCall(out IntPtr DeviceIndex, out IntPtr DeviceSerial, out IntPtr CountRing);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetDeviceDisConnect(out IntPtr DeviceIndex);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void SetLed(int DeviceIndex, int LedIndex, int TypeOf);
        [DllImport(path, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern void GetTransactionPOS(out IntPtr Port1, out IntPtr PosResponseCode1, out IntPtr PosSN1,
            out IntPtr PosAmount1, out IntPtr PosCardNumber1, out IntPtr PosTraceNumber1, out IntPtr PosRefNumber1, out IntPtr PosRes_Str1);




        private void timer1_Tick(object sender, EventArgs e)
        {
            byte[] data = new byte[300];
            short Res = GetNewAnswer(data);
            IntPtr DeviceIndex;
            IntPtr LineIndex;
            byte[] CallerIDNumber=new byte[300];
            int TimeSec1 = 0;
            IntPtr Ring;
            byte[] Dial=new byte[300];
            IntPtr SerialDevice;
            IntPtr LineCountOfDevice;
            IntPtr Port1;
            IntPtr PosResponseCode1;
            IntPtr PosSN1;
            IntPtr PosAmount1;
            IntPtr PosCardNumber1;
            IntPtr PosTraceNumber1;
            IntPtr PosRefNumber1;
            IntPtr PosRes_Str1;

            //Str = Convert.ToString(data);
            //TypeOfCallerID = Convert.ToString(data);
            //CallerIDNumber1 = Convert.ToString(data);
            // Res= GetNewAnswer((Str));

            if (Res != 0)
            {
                /*  string d = Encoding.Default.GetString(data).Replace("\0", string.Empty);
                  if (!string.IsNullOrEmpty(d))
                  {
                      ListBox1.Items.Add(d);
                  }*/
                pictureBox1.Image = imageList1.Images[5];
                if (Res == 1)
                {//answer
                    GetAnswer(out DeviceIndex, out LineIndex);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " پاسخگویی");
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox2.Image = imageList1.Images[3];

                }
                //if (Res == 2)
                //{  //Caller ID
                //    GetCallerID(DeviceIndex, LineIndex, CallerIDNumber.ToString());
                //    CallerIDNumber = ((CallerIDNumber).ToString());
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " شماره تماس گیرنده [ " + (CallerIDNumber).ToString() + "]");
                //}
                if (Res == 2)
                {  //Caller ID
                    GetCallerID(out DeviceIndex, out LineIndex,CallerIDNumber);
                    ListBox1.Items.Add("دستگاه شماره" + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- شماره تماس گیرنده " + "[" + Encoding.Default.GetString(CallerIDNumber) + "]");
                    pictureBox1.Image = imageList1.Images[7];
                    pictureBox2.Image = imageList1.Images[3];
                }
                //if (Res == 3)
                //{  //HockOn
                //    GetHockOn(DeviceIndex, LineIndex, TimeSec1);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " گوشی گذار و مدت بالا بودن گوشی " + "[" + Convert.ToString(TimeSec1) + "]");
                //}
                if (Res == 3)
                {  //HockOn(گذاشتن گوشی)
                    GetHockOn(out DeviceIndex, out LineIndex, out TimeSec1);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " گوشی گذار و مدت بالا بودن گوشی " + "[" + Convert.ToString(TimeSec1) + "]");
                    pictureBox1.Image = imageList1.Images[5];
                }

                //if (Res == 8)
                //{  //Missed Call
                //    GetMissedCall(DeviceIndex, LineIndex, Ring);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " تماس از دست رفته -  تعداد زنگ خورده شده [" + Convert.ToString(Ring) + "]");
                //}
                if (Res == 8)
                {  //Missed Call
                    GetMissedCall(out DeviceIndex, out LineIndex, out Ring);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " تماس از دست رفته -  تعداد زنگ خورده شده [" + Convert.ToString(Ring) + "]");
                    pictureBox2.Image = imageList1.Images[4];
                }

                //if (Res == 4)
                //{  //HockOff
                //    GetHockOff(DeviceIndex, LineIndex);
                //    ListBox1.Items.Add("دستگاه شماره" + Convert.ToString(DeviceIndex) + "- خط شماره" + Convert.ToString(LineIndex) + " - گوشی بردار");
                //}
                if (Res == 4)
                {  //HockOff(برداشتن گوشی)
                    GetHockOff(out DeviceIndex, out LineIndex);
                    ListBox1.Items.Add("دستگاه شماره" + Convert.ToString(DeviceIndex) + "- خط شماره" + Convert.ToString(LineIndex) + " - گوشی بردار");
                    pictureBox1.Image = imageList1.Images[0];
                }

                //if (Res == 5)
                //{  //Dial
                //    GetDialNumber2(DeviceIndex, LineIndex, Convert.ToString(Dial));
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " - شماره گیری [" + (Dial) + "]");
                //}
                if (Res == 5)
                {  //Dial
                    GetDialNumber2(out DeviceIndex, out LineIndex,Dial);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + " - شماره گیری [" +Encoding.Default.GetString( Dial )+ "]");
                    pictureBox1.Image = imageList1.Images[0];
                    pictureBox2.Image = imageList1.Images[6];
                }

                //if (Res == 6)
                //{ //Ring
                //    GetRing(DeviceIndex, LineIndex, Ring);

                //    ListBox1.Items.Add("دستگاه شماره" + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- درحال زنگ خوردن [" + Convert.ToString(Ring) + "]");
                //}
                if (Res == 6)
                { //Ring
                    GetRing(out DeviceIndex, out LineIndex, out Ring);

                    ListBox1.Items.Add("دستگاه شماره" + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- درحال زنگ خوردن [" + Convert.ToString(Ring) + "]");
                    pictureBox1.Image = imageList1.Images[7];
                    pictureBox2.Image = imageList1.Images[3];

                }

                //if (Res == 7)
                //{  //Line Disconnect
                //    GetLineDisconnect(DeviceIndex, LineIndex);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- قطع شدن خط متصل");
                //}
                if (Res == 7)
                {  //Line Disconnect
                    GetLineDisconnect(out DeviceIndex, out LineIndex);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- قطع شدن خط متصل");
                    pictureBox1.Image = imageList1.Images[1];
                }
                //if (Res == 20)
                //{  //Line connect
                //    GetLineDisconnect(DeviceIndex, LineIndex);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- وصل  شدن خط ");
                //}
                if (Res == 20)
                {  //Line connect
                    GetLineDisconnect(out DeviceIndex, out LineIndex);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- خط شماره " + Convert.ToString(LineIndex) + "- وصل  شدن خط ");
                    pictureBox1.Image = imageList1.Images[5];
                }
                //if (Res == 9)
                //{  //Device Connect
                //    GetDeviceConnect(DeviceIndex, SerialDevice, LineCountOfDevice);

                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + " سریال [" + Convert.ToString(SerialDevice) + "] - تعداد خط ورودی [" + Convert.ToString(LineCountOfDevice) + "] اتصال دستگاه ");
                //}
                if (Res == 9)
                {  //Device Connect
                    GetDeviceConnect(out DeviceIndex, out SerialDevice, out LineCountOfDevice);

                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + " سریال [" + Convert.ToString(SerialDevice) + "] - تعداد خط ورودی [" + Convert.ToString(LineCountOfDevice) + "] اتصال دستگاه ");
                    pictureBox1.Image = imageList1.Images[5];
                }

                //if (Res == 10)
                //{  //Device Dis Connect
                //    GetDeviceDisConnect(DeviceIndex);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + " قطع دستگاه از پورت USB");
                //}
                if (Res == 10)
                {  //Device Dis Connect
                    GetDeviceDisConnect(out DeviceIndex);
                    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + " قطع دستگاه از پورت USB");
                    pictureBox1.Image = imageList1.Images[1];
                }

                //if (Res == 164)
                //{  //Caller ID
                //    GetOffline(out DeviceIndex, out TypeOfCallerID, out CallerIDNumber1);
                //    ListBox1.Items.Add("دستگاه شماره " + Convert.ToString(DeviceIndex) + "- نوع تماس " + Convert.ToString(TypeOfCallerID) + " شمارنده تماس گیرنده [ " + CallerIDNumber1 + " ]");
                //}
                if (Res == 21)
                {
                    GetTransactionPOS(out Port1, out PosResponseCode1, out PosSN1, out PosAmount1, out PosCardNumber1, out PosTraceNumber1, out PosRefNumber1, out PosRes_Str1);
                }
                listBox2.Items.Add(Encoding.Default.GetString(data));
            }
            if (textBox2.Text != "")
            {
                SendLastCommandToNetwork(Convert.ToString((textBox2.Text).ToString()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr intp;
            GetVerDll(out intp);
            label1.Text = Marshal.PtrToStringAuto(intp);
        }

        private int MarshalAs(UnmanagedType bStr)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                IntPtr intp;
                GetFirmware_Ver(out intp);
                label2.Text = Marshal.PtrToStringAuto(intp);
            }
            else
            {
                label2.Text = "لطفا تایمر را فعال کنید";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                IntPtr intp;
                Get_Line_NO(out intp);
                label3.Text = Marshal.PtrToStringAuto(intp);
            }
            else
            {
                label3.Text = "لطفا تایمر را فعال کنید";
            }
            //label3.Text = Get_Line_NO();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                label15.Text = "";
                int DTMF_Call_In_Wait1 = 0, DTMF_Call_Out_Wait1 = 0, Missed_Call_Counter1 = 0, Len_Before_FSK_Data1 = 0,
                After_FSK_Sample_Len1 = 0, Logic0_Sample_Len1 = 0, Logic1_Sample_Len1 = 0, Differ_Lgic01_Len_FSK1 = 0,
                Differ_Data_Buffer_Len1 = 0;
                Get_Setting(out DTMF_Call_In_Wait1, out DTMF_Call_Out_Wait1, out Missed_Call_Counter1, out Len_Before_FSK_Data1,
                                   out After_FSK_Sample_Len1, out Logic0_Sample_Len1, out Logic1_Sample_Len1, out Differ_Lgic01_Len_FSK1, out Differ_Data_Buffer_Len1);
                //if (Marshal.PtrToStringBSTR(DTMF_Call_In_Wait) == "" && Marshal.PtrToStringBSTR(DTMF_Call_Out_Wait) == "" && Marshal.PtrToStringBSTR(Missed_Call_Counter) == "" && Marshal.PtrToStringBSTR(Len_Before_FSK_Data) == ""
                //    && Marshal.PtrToStringBSTR(After_FSK_Sample_Len) == "" && Marshal.PtrToStringBSTR(Logic0_Sample_Len) == "" && Marshal.PtrToStringBSTR(Logic1_Sample_Len) == "" && Marshal.PtrToStringBSTR(Differ_Lgic01_Len_FSK) == "" &&
                //    Marshal.PtrToStringBSTR(Differ_Data_Buffer_Len) == "")
                //{
                //    EditDTMF_Call_In_Wait.Text = "";
                //    EditDTMF_Call_Out_Wait.Text = "";
                //    EditMissed_Call_Counter.Text = "";
                //    EditLen_Before_FSK_Data.Text = "";
                //    EditAfter_FSK_Sample_Len.Text = "";
                //    EditLogic0_Sample_Len.Text = "";
                //    EditLogic1_Sample_Len.Text = "";
                //    EditDiffer_Lgic01_Len_FSK.Text = "";
                //    EditDiffer_Data_Buffer_Len.Text = "";
                //}
                if (DTMF_Call_In_Wait1 == 0 && DTMF_Call_Out_Wait1 == 0 && Missed_Call_Counter1 == 0 && Len_Before_FSK_Data1 == 0 &&
                    After_FSK_Sample_Len1 == 0 && Logic0_Sample_Len1 == 0 && Logic1_Sample_Len1 == 0 && Differ_Lgic01_Len_FSK1 == 0 &&
                    Differ_Data_Buffer_Len1 == 0)
                {
                    label15.Text = "برای تنظیمات مقداری وجود ندارد";
                }
                else
                {
                    label15.Text = "";
                    EditDTMF_Call_In_Wait.Text = Convert.ToString(DTMF_Call_In_Wait1);
                    EditDTMF_Call_Out_Wait.Text = Convert.ToString(DTMF_Call_Out_Wait1);
                    EditMissed_Call_Counter.Text = Convert.ToString(Missed_Call_Counter1);
                    EditLen_Before_FSK_Data.Text = Convert.ToString(Len_Before_FSK_Data1);
                    EditAfter_FSK_Sample_Len.Text = Convert.ToString(After_FSK_Sample_Len1);
                    EditLogic0_Sample_Len.Text = Convert.ToString(Logic0_Sample_Len1);
                    EditLogic1_Sample_Len.Text = Convert.ToString(Logic1_Sample_Len1);
                    EditDiffer_Lgic01_Len_FSK.Text = Convert.ToString(Differ_Lgic01_Len_FSK1);
                    EditDiffer_Data_Buffer_Len.Text = Convert.ToString(Differ_Data_Buffer_Len1);
                }
            }
            else
            {
                label15.Text = "لطفا تایمر را فعال کنید";
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetIpServer(Convert.ToString((textBox1.Text).ToString()));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                IntPtr intp;
                GetVerDevice(out intp);
                label14.Text = Marshal.PtrToStringAuto(intp);
            }
            else
            {
                label14.Text = "لطفا تایمر را فعال کنید";
            }
        }
        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                Boolean IsSend1;
                if (Get_CMDToCom(out IsSend1))
                {
                    checkBox1.Checked = IsSend1;
                    if (IsSend1 == true)
                    {
                        checkBox1.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        checkBox1.CheckState = CheckState.Unchecked;
                    }
                    MessageBox.Show("Get CMD To Com Done Successfully");
                }
                else
                {
                    MessageBox.Show("Faild to Get CMD To Com");
                }
            }
            else
            {
                MessageBox.Show("لطفا تایمر را فعال کنید");
            }

        }
        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                Boolean ISSave ;
                if (Get_Offline(out ISSave))
                {
                    SaveOfflineCheckBox.Checked = ISSave;
                    if (ISSave==true)
                    {
                        SaveOfflineCheckBox.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        SaveOfflineCheckBox.CheckState = CheckState.Unchecked;
                    }                   
                    MessageBox.Show("Read Save Offline done successfully");
                }
                else
                {
                    MessageBox.Show("Faild to Read");
                }
            }
            else
            {
                MessageBox.Show("لطفا تایمر را فعال کنید");
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            GetOfflineData(0, WithoutDeleteMemory);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int i;
            {
                i = Convert.ToInt32(MessageBox.Show("مطمئن هستید که می خواهید حافظه را پاک کنید؟"));
                if (i == 1)
                    GetOfflineData(0, WithDeleteMemory);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int CountOfNumber;
            CountOfNumber = GetOfflineData(0, 3);
            OTNtextBox.Text = Convert.ToString(CountOfNumber);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox3.Checked;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox3.Checked;
        }

        public class PAnsiChar
        {
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
        }
    }
}