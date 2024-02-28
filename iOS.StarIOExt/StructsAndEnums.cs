using System;
using ObjCRuntime;

namespace iOS.StarIOExt
{
    [Native]
    public enum SCBInitializationType : ulong
    {
        SCBInitializationTypeCommand
    }

    [Native]
    public enum SCBFontStyleType : ulong
    {
        A,
        B
    }

    [Native]
    public enum SCBCodePageType : ulong
    {
        Cp437,
        Cp737,
        Cp772,
        Cp774,
        Cp851,
        Cp852,
        Cp855,
        Cp857,
        Cp858,
        Cp860,
        Cp861,
        Cp862,
        Cp863,
        Cp864,
        Cp865,
        Cp866,
        Cp869,
        Cp874,
        Cp928,
        Cp932,
        Cp998,
        Cp999,
        Cp1001,
        Cp1250,
        Cp1251,
        Cp1252,
        Cp2001,
        Cp3001,
        Cp3002,
        Cp3011,
        Cp3012,
        Cp3021,
        Cp3041,
        Cp3840,
        Cp3841,
        Cp3843,
        Cp3844,
        Cp3845,
        Cp3846,
        Cp3847,
        Cp3848,
        Utf8,
        Blank
    }

    [Native]
    public enum SCBInternationalType : ulong
    {
        Usa,
        France,
        Germany,
        Uk,
        Denmark,
        Sweden,
        Italy,
        Spain,
        Japan,
        Norway,
        Denmark2,
        Spain2,
        LatinAmerica,
        Korea,
        Ireland,
        Legal
    }

    [Native]
    public enum SCBLogoSize : ulong
    {
        Normal,
        DoubleWidth,
        DoubleHeight,
        DoubleWidthDoubleHeight
    }

    [Native]
    public enum SCBAlignmentPosition : long
    {
        Left,
        Center,
        Right
    }

    [Native]
    public enum SCBCutPaperAction : long
    {
        FullCut,
        PartialCut,
        FullCutWithFeed,
        PartialCutWithFeed
    }

    [Native]
    public enum SCBPeripheralChannel : long
    {
        SCBPeripheralChannelNo1,
        SCBPeripheralChannelNo2
    }

    [Native]
    public enum SCBSoundChannel : long
    {
        SCBSoundChannelNo1,
        SCBSoundChannelNo2
    }

    [Native]
    public enum SCBBarcodeSymbology : ulong
    {
        Upce,
        Upca,
        Jan8,
        Jan13,
        Code39,
        Itf,
        Code128,
        Code93,
        Nw7
    }

    [Native]
    public enum SCBBarcodeWidth : ulong
    {
        SCBBarcodeWidthMode1,
        SCBBarcodeWidthMode2,
        SCBBarcodeWidthMode3,
        SCBBarcodeWidthMode4,
        SCBBarcodeWidthMode5,
        SCBBarcodeWidthMode6,
        SCBBarcodeWidthMode7,
        SCBBarcodeWidthMode8,
        SCBBarcodeWidthMode9
    }

    [Native]
    public enum SCBPdf417Level : ulong
    {
        SCBPdf417LevelECC0,
        SCBPdf417LevelECC1,
        SCBPdf417LevelECC2,
        SCBPdf417LevelECC3,
        SCBPdf417LevelECC4,
        SCBPdf417LevelECC5,
        SCBPdf417LevelECC6,
        SCBPdf417LevelECC7,
        SCBPdf417LevelECC8
    }

    [Native]
    public enum SCBQrCodeModel : ulong
    {
        SCBQrCodeModelNo1,
        SCBQrCodeModelNo2
    }

    [Native]
    public enum SCBQrCodeLevel : ulong
    {
        L,
        M,
        Q,
        H
    }

    [Native]
    public enum SCBBitmapConverterRotation : long
    {
        Normal,
        Right90,
        Left90,
        Rotate180
    }

    [Native]
    public enum SCBBlackMarkType : long
    {
        Invalid,
        Valid,
        ValidWithDetection
    }

    [Native]
    public enum SDCBInternationalType : long
    {
        Usa = 0,
        France = 1,
        Germany = 2,
        Uk = 3,
        Denmark = 4,
        Sweden = 5,
        Italy = 6,
        Spain = 7,
        Japan = 8,
        Norway = 9,
        Denmark2 = 10,
        Spain2 = 11,
        LatinAmerica = 12,
        Korea = 13
    }

    [Native]
    public enum SDCBCodePageType : long
    {
        Cp437 = 0,
        Katakana = 1,
        Cp850 = 2,
        Cp860 = 3,
        Cp863 = 4,
        Cp865 = 5,
        Cp1252 = 6,
        Cp866 = 7,
        Cp852 = 8,
        Cp858 = 9,
        Japanese = 10,
        SimplifiedChinese = 11,
        TraditionalChinese = 12,
        Hangul = 13
    }

    [Native]
    public enum SDCBCursorMode : long
    {
        Off = 0,
        Blink = 1,
        On = 2
    }

    [Native]
    public enum SDCBContrastMode : long
    {
        Minus3 = 0,
        Minus2 = 1,
        Minus1 = 2,
        Default = 3,
        Plus1 = 4,
        Plus2 = 5,
        Plus3 = 6
    }

    [Native]
    public enum StarIoExtParserCompletionResult : long
    {
        Invalid = 0,
        Success,
        Failure
    }

    [Native]
    public enum StarIoExtDisplayedWeightStatus : long
    {
        Invalid = 0,
        Zero,
        NotInMotion,
        Motion
    }

    [Native]
    public enum StarIoExtEmulation : long
    {
        None = 0,
        StarPRNT,
        StarLine,
        StarGraphic,
        EscPos,
        EscPosMobile,
        StarDotImpact,
        StarPRNTL
    }

    [Native]
    public enum StarIoExtCharacterCode : long
    {
        None = 0,
        Standard,
        Japanese,
        SimplifiedChinese,
        TraditionalChinese
    }

    [Native]
    public enum StarIoExtBcrModel : long
    {
        None = 0,
        Pop1
    }

    [Native]
    public enum StarIoExtDisplayModel : long
    {
        None = 0,
        Scd222
    }

    [Native]
    public enum StarIoExtScaleModel : long
    {
        None = 0,
        Aps10,
        Aps12,
        Aps20
    }
}
