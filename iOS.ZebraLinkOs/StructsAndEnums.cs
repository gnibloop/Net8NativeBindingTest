using System;
using ObjCRuntime;

namespace iOS.ZebraLinkOs
{
    public enum ZplPrintMode : uint
    {
        Rewind,
        PeelOff,
        TearOff,
        Cutter,
        Applicator,
        DelayedCut,
        LinerlessPeel,
        LinerlessRewind,
        PartialCutter,
        Rfid,
        Kiosk,
        Unknown
    }
    public enum ZebraErrorCode : uint
    {
        ErrorNoConnection,
        ErrorWriteFailure,
        ErrorReadFailure,
        UnknownPrinterLanguage,
        MalformedNetworkDiscoveryAddress,
        NetworkErrorDuringDiscovery,
        InvalidDiscoveryHopCount,
        MalformedPrinterStatusResponse,
        InvalidFormatName,
        BadFileDirectoryEntry,
        MalformedFormatFieldNumber,
        InvalidPrinterLanguage,
        InvalidFileName,
        InvalidPrinterDriveLetter
    }
    public enum PrinterLanguage : uint
    {
        Zpl,
        Cpcl
    }
}
