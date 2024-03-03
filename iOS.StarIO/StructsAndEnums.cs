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

