using System.Runtime.InteropServices;

namespace iOS.StarIO
{
    public enum SMEmulation : uint
    {
        Unknown = 0,
        StarLine,
        Escpos
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct StarPrinterStatus
    {
        public uint coverOpen;

        public uint offline;

        public uint compulsionSwitch;

        public uint overTemp;

        public uint unrecoverableError;

        public uint cutterError;

        public uint mechError;

        public uint pageModeCmdError;

        public uint paperSizeError;

        public uint presenterPaperJamError;

        public uint headUpError;

        public uint blackMarkDetectStatus;

        public uint paperEmpty;

        public uint paperNearEmptyInner;

        public uint paperNearEmptyOuter;

        public uint stackerFull;

        public uint etbAvailable;

        public byte etbCounter;

        public byte presenterState;

        public uint rawLength;

        public fixed byte raw[63];  //Check the original header file we found it's a fixed array
                                    //[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
                                    //public IntPtr raw;
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct StarPrinterStatus_1
    {
        public uint coverOpen;

        public uint offline;

        public uint compulsionSwitch;

        public uint overTemp;

        public uint unrecoverableError;

        public uint cutterError;

        public uint mechError;

        public uint receiveBufferOverflow;

        public uint pageModeCmdError;

        public uint blackMarkError;

        public uint presenterPaperJamError;

        public uint headUpError;

        public uint receiptBlackMarkDetection;

        public uint receiptPaperEmpty;

        public uint receiptPaperNearEmptyInner;

        public uint receiptPaperNearEmptyOuter;

        public uint presenterPaperPresent;

        public uint peelerPaperPresent;

        public uint stackerFull;

        public uint slipTOF;

        public uint slipCOF;

        public uint slipBOF;

        public uint validationPaperPresent;

        public uint slipPaperPresent;

        public uint etbAvailable;

        public byte etbCounter;

        public byte presenterState;

        public uint rawLength;

        public fixed byte raw[63];
    }

    [StructLayout(LayoutKind.Sequential)]
    unsafe public struct StarPrinterStatus_2
    {
        public uint coverOpen;

        public uint offline;

        public uint compulsionSwitch;

        public uint overTemp;

        public uint unrecoverableError;

        public uint cutterError;

        public uint mechError;

        public uint headThermistorError;

        public uint receiveBufferOverflow;

        public uint pageModeCmdError;

        public uint blackMarkError;

        public uint presenterPaperJamError;

        public uint headUpError;

        public uint voltageError;

        public uint receiptBlackMarkDetection;

        public uint receiptPaperEmpty;

        public uint receiptPaperNearEmptyInner;

        public uint receiptPaperNearEmptyOuter;

        public uint presenterPaperPresent;

        public uint peelerPaperPresent;

        public uint stackerFull;

        public uint slipTOF;

        public uint slipCOF;

        public uint slipBOF;

        public uint validationPaperPresent;

        public uint slipPaperPresent;

        public uint etbAvailable;

        public byte etbCounter;

        public byte presenterState;

        public uint rawLength;

        public fixed byte raw[63];
    }

    static class CFunctions
    {
        // extern void * OpenPort (const char *portName, const char *portSettings, u_int32_t ioRequestTimeoutMillis, SMEmulation emulation);
        [DllImport("__Internal")]
        static extern unsafe void* OpenPort(sbyte* portName, sbyte* portSettings, uint ioRequestTimeoutMillis, SMEmulation emulation);

        // extern u_int32_t ClosePort (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint ClosePort(void* port);

        // extern u_int32_t ReadPort (void *port, u_int8_t *readBuffer, u_int32_t size, u_int32_t *sizeCommunicated);
        [DllImport("__Internal")]
        static extern unsafe uint ReadPort(void* port, byte* readBuffer, uint size, uint* sizeCommunicated);

        // extern u_int32_t WritePort (void *port, const u_int8_t *writeBuffer, u_int32_t size, u_int32_t *sizeCommunicated);
        [DllImport("__Internal")]
        static extern unsafe uint WritePort(void* port, byte* writeBuffer, uint size, uint* sizeCommunicated);

        // extern u_int32_t GetOnlineStatus (void *port, u_int32_t *onlineStatus);
        [DllImport("__Internal")]
        static extern unsafe uint GetOnlineStatus(void* port, uint* onlineStatus);

        // extern u_int32_t GetParsedStatus (void *port, StarPrinterStatus *starPrinterStatus);
        [DllImport("__Internal")]
        static extern unsafe uint GetParsedStatus(void* port, StarPrinterStatus starPrinterStatus);

        // extern u_int32_t GetParsedStatusEx (void *port, void *starPrinterStatus, u_int32_t level);
        [DllImport("__Internal")]
        static extern unsafe uint GetParsedStatusEx(void* port, void* starPrinterStatus, uint level);

        // extern u_int32_t RetrieveFirmwareInformation (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint RetrieveFirmwareInformation(void* port);

        // extern u_int32_t RetrieveDipSwitchInformation (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint RetrieveDipSwitchInformation(void* port);

        // extern u_int32_t BeginCheckedBlock (void *port, StarPrinterStatus *starPrinterStatus);
        [DllImport("__Internal")]
        static extern unsafe uint BeginCheckedBlock(void* port, StarPrinterStatus starPrinterStatus);

        // extern u_int32_t BeginCheckedBlockEx (void *port, void *starPrinterStatus, u_int32_t level);
        [DllImport("__Internal")]
        static extern unsafe uint BeginCheckedBlockEx(void* port, void* starPrinterStatus, uint level);

        // extern u_int32_t EndCheckedBlock (void *port, StarPrinterStatus *starPrinterStatus);
        [DllImport("__Internal")]
        static extern unsafe uint EndCheckedBlock(void* port, StarPrinterStatus starPrinterStatus);

        // extern u_int32_t EndCheckedBlockEx (void *port, void *starPrinterStatus, u_int32_t level);
        [DllImport("__Internal")]
        static extern unsafe uint EndCheckedBlockEx(void* port, void* starPrinterStatus, uint level);

        // extern u_int32_t ResetDevice (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint ResetDevice(void* port);

        // extern char * GetFirmwareInformation (void *port);
        [DllImport("__Internal")]
        static extern unsafe sbyte* GetFirmwareInformation(void* port);

        // extern char * GetDipSwitchInformation (void *port, u_int8_t dsInfo);
        [DllImport("__Internal")]
        static extern unsafe sbyte* GetDipSwitchInformation(void* port, byte dsInfo);

        // extern int retrieveButtonSecurityTimeout (void *port);
        [DllImport("__Internal")]
        static extern unsafe int retrieveButtonSecurityTimeout(void* port);

        // extern u_int32_t GetEndCheckedBlockTimeoutMillis (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint GetEndCheckedBlockTimeoutMillis(void* port);

        // extern void SetEndCheckedBlockTimeoutMillis (void *port, u_int32_t timeoutMillis);
        [DllImport("__Internal")]
        static extern unsafe void SetEndCheckedBlockTimeoutMillis(void* port, uint timeoutMillis);

        // extern u_int32_t IsUSBSharing (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint IsUSBSharing(void* port);

        // extern u_int32_t IsDKAirCash (void *port);
        [DllImport("__Internal")]
        static extern unsafe uint IsDKAirCash(void* port);
    }

    public enum SMDeviceType : uint
    {
        Unknown = 0,
        DesktopPrinter,
        PortablePrinter,
        DKAirCash
    }

    public enum SMBluetoothSecurity : uint
    {
        Disable,
        Ssp,
        PINcode
    }

    public enum SMBluetoothSettingCapability : uint
    {
        Support,
        NoSupport
    }

}

