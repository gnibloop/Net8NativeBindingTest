using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace iOS.StarIOExt
{
    // @interface ISCBBuilder : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ISCBBuilder
    {
        // @property (readonly, nonatomic) NSMutableData * commands;
        [Export("commands")]
        NSMutableData Commands { get; }

        // -(void)beginDocument;
        [Export("beginDocument")]
        void BeginDocument();

        // -(void)endDocument;
        [Export("endDocument")]
        void EndDocument();

        // -(void)appendInitialization:(SCBInitializationType)type;
        [Export("appendInitialization:")]
        void AppendInitialization(SCBInitializationType type);

        // -(void)appendByte:(unsigned char)data;
        [Export("appendByte:")]
        void AppendByte(byte data);

        // -(void)appendData:(NSData *)otherData;
        [Export("appendData:")]
        void AppendData(NSData otherData);

        // -(void)appendBytes:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytes:length:")]
        unsafe void AppendBytes(IntPtr bytes, nuint length);

        // -(void)appendRawByte:(unsigned char)data;
        [Export("appendRawByte:")]
        void AppendRawByte(byte data);

        // -(void)appendRawData:(NSData *)otherData;
        [Export("appendRawData:")]
        void AppendRawData(NSData otherData);

        // -(void)appendRawBytes:(const void *)bytes length:(NSUInteger)length;
        [Export("appendRawBytes:length:")]
        unsafe void AppendRawBytes(IntPtr bytes, nuint length);

        // -(void)appendFontStyle:(SCBFontStyleType)type;
        [Export("appendFontStyle:")]
        void AppendFontStyle(SCBFontStyleType type);

        // -(void)appendCodePage:(SCBCodePageType)type;
        [Export("appendCodePage:")]
        void AppendCodePage(SCBCodePageType type);

        // -(void)appendInternational:(SCBInternationalType)type;
        [Export("appendInternational:")]
        void AppendInternational(SCBInternationalType type);

        // -(void)appendLineFeed;
        [Export("appendLineFeed")]
        void AppendLineFeed();

        // -(void)appendDataWithLineFeed:(NSData *)otherData;
        [Export("appendDataWithLineFeed:")]
        void AppendDataWithLineFeed(NSData otherData);

        // -(void)appendBytesWithLineFeed:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytesWithLineFeed:length:")]
        unsafe void AppendBytesWithLineFeed(IntPtr bytes, nuint length);

        // -(void)appendLineFeed:(NSInteger)line;
        [Export("appendLineFeed:")]
        void AppendLineFeed(nint line);

        // -(void)appendDataWithLineFeed:(NSData *)otherData line:(NSInteger)line;
        [Export("appendDataWithLineFeed:line:")]
        void AppendDataWithLineFeed(NSData otherData, nint line);

        // -(void)appendBytesWithLineFeed:(const void *)bytes length:(NSUInteger)length line:(NSInteger)line;
        [Export("appendBytesWithLineFeed:length:line:")]
        unsafe void AppendBytesWithLineFeed(IntPtr bytes, nuint length, nint line);

        // -(void)appendUnitFeed:(NSInteger)unit;
        [Export("appendUnitFeed:")]
        void AppendUnitFeed(nint unit);

        // -(void)appendDataWithUnitFeed:(NSData *)otherData unit:(NSInteger)unit;
        [Export("appendDataWithUnitFeed:unit:")]
        void AppendDataWithUnitFeed(NSData otherData, nint unit);

        // -(void)appendBytesWithUnitFeed:(const void *)bytes length:(NSUInteger)length unit:(NSInteger)unit;
        [Export("appendBytesWithUnitFeed:length:unit:")]
        unsafe void AppendBytesWithUnitFeed(IntPtr bytes, nuint length, nint unit);

        // -(void)appendCharacterSpace:(NSInteger)space;
        [Export("appendCharacterSpace:")]
        void AppendCharacterSpace(nint space);

        // -(void)appendLineSpace:(NSInteger)lineSpace;
        [Export("appendLineSpace:")]
        void AppendLineSpace(nint lineSpace);

        // -(void)appendEmphasis:(BOOL)emphasis;
        [Export("appendEmphasis:")]
        void AppendEmphasis(bool emphasis);

        // -(void)appendDataWithEmphasis:(NSData *)otherData;
        [Export("appendDataWithEmphasis:")]
        void AppendDataWithEmphasis(NSData otherData);

        // -(void)appendBytesWithEmphasis:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytesWithEmphasis:length:")]
        unsafe void AppendBytesWithEmphasis(IntPtr bytes, nuint length);

        // -(void)appendInvert:(BOOL)invert;
        [Export("appendInvert:")]
        void AppendInvert(bool invert);

        // -(void)appendDataWithInvert:(NSData *)otherData;
        [Export("appendDataWithInvert:")]
        void AppendDataWithInvert(NSData otherData);

        // -(void)appendBytesWithInvert:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytesWithInvert:length:")]
        unsafe void AppendBytesWithInvert(IntPtr bytes, nuint length);

        // -(void)appendMultiple:(NSInteger)width height:(NSInteger)height;
        [Export("appendMultiple:height:")]
        void AppendMultiple(nint width, nint height);

        // -(void)appendDataWithMultiple:(NSData *)otherData width:(NSInteger)width height:(NSInteger)height;
        [Export("appendDataWithMultiple:width:height:")]
        void AppendDataWithMultiple(NSData otherData, nint width, nint height);

        // -(void)appendBytesWithMultiple:(const void *)bytes length:(NSUInteger)length width:(NSInteger)width height:(NSInteger)height;
        [Export("appendBytesWithMultiple:length:width:height:")]
        unsafe void AppendBytesWithMultiple(IntPtr bytes, nuint length, nint width, nint height);

        // -(void)appendMultipleHeight:(NSInteger)height;
        [Export("appendMultipleHeight:")]
        void AppendMultipleHeight(nint height);

        // -(void)appendDataWithMultipleHeight:(NSData *)otherData height:(NSInteger)height;
        [Export("appendDataWithMultipleHeight:height:")]
        void AppendDataWithMultipleHeight(NSData otherData, nint height);

        // -(void)appendBytesWithMultipleHeight:(const void *)bytes length:(NSUInteger)length height:(NSInteger)height;
        [Export("appendBytesWithMultipleHeight:length:height:")]
        unsafe void AppendBytesWithMultipleHeight(IntPtr bytes, nuint length, nint height);

        // -(void)appendMultipleWidth:(NSInteger)width;
        [Export("appendMultipleWidth:")]
        void AppendMultipleWidth(nint width);

        // -(void)appendDataWithMultipleWidth:(NSData *)otherData width:(NSInteger)width;
        [Export("appendDataWithMultipleWidth:width:")]
        void AppendDataWithMultipleWidth(NSData otherData, nint width);

        // -(void)appendBytesWithMultipleWidth:(const void *)bytes length:(NSUInteger)length width:(NSInteger)width;
        [Export("appendBytesWithMultipleWidth:length:width:")]
        unsafe void AppendBytesWithMultipleWidth(IntPtr bytes, nuint length, nint width);

        // -(void)appendUnderLine:(BOOL)underLine;
        [Export("appendUnderLine:")]
        void AppendUnderLine(bool underLine);

        // -(void)appendDataWithUnderLine:(NSData *)otherData;
        [Export("appendDataWithUnderLine:")]
        void AppendDataWithUnderLine(NSData otherData);

        // -(void)appendBytesWithUnderLine:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytesWithUnderLine:length:")]
        unsafe void AppendBytesWithUnderLine(IntPtr bytes, nuint length);

        // -(void)appendLogo:(SCBLogoSize)size number:(NSInteger)number;
        [Export("appendLogo:number:")]
        void AppendLogo(SCBLogoSize size, nint number);

        // -(void)appendAbsolutePosition:(NSInteger)position;
        [Export("appendAbsolutePosition:")]
        void AppendAbsolutePosition(nint position);

        // -(void)appendDataWithAbsolutePosition:(NSData *)otherData position:(NSInteger)position;
        [Export("appendDataWithAbsolutePosition:position:")]
        void AppendDataWithAbsolutePosition(NSData otherData, nint position);

        // -(void)appendBytesWithAbsolutePosition:(const void *)bytes length:(NSUInteger)length position:(NSInteger)position;
        [Export("appendBytesWithAbsolutePosition:length:position:")]
        unsafe void AppendBytesWithAbsolutePosition(IntPtr bytes, nuint length, nint position);

        // -(void)appendAlignment:(SCBAlignmentPosition)position;
        [Export("appendAlignment:")]
        void AppendAlignment(SCBAlignmentPosition position);

        // -(void)appendDataWithAlignment:(NSData *)otherData position:(SCBAlignmentPosition)position;
        [Export("appendDataWithAlignment:position:")]
        void AppendDataWithAlignment(NSData otherData, SCBAlignmentPosition position);

        // -(void)appendBytesWithAlignment:(const void *)bytes length:(NSUInteger)length position:(SCBAlignmentPosition)position;
        [Export("appendBytesWithAlignment:length:position:")]
        unsafe void AppendBytesWithAlignment(IntPtr bytes, nuint length, SCBAlignmentPosition position);

        // -(void)appendHorizontalTabPosition:(NSArray<NSNumber *> *)positions;
        [Export("appendHorizontalTabPosition:")]
        void AppendHorizontalTabPosition(NSNumber[] positions);

        // -(void)appendCutPaper:(SCBCutPaperAction)action;
        [Export("appendCutPaper:")]
        void AppendCutPaper(SCBCutPaperAction action);

        // -(void)appendPeripheral:(SCBPeripheralChannel)channel;
        [Export("appendPeripheral:")]
        void AppendPeripheral(SCBPeripheralChannel channel);

        // -(void)appendPeripheral:(SCBPeripheralChannel)channel time:(NSInteger)time;
        [Export("appendPeripheral:time:")]
        void AppendPeripheral(SCBPeripheralChannel channel, nint time);

        // -(void)appendSound:(SCBSoundChannel)channel;
        [Export("appendSound:")]
        void AppendSound(SCBSoundChannel channel);

        // -(void)appendSound:(SCBSoundChannel)channel repeat:(NSInteger)repeat;
        [Export("appendSound:repeat:")]
        void AppendSound(SCBSoundChannel channel, nint repeat);

        // -(void)appendBarcodeData:(NSData *)otherData symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri;
        [Export("appendBarcodeData:symbology:width:height:hri:")]
        void AppendBarcodeData(NSData otherData, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri);

        // -(void)appendBarcodeBytes:(const void *)bytes length:(NSUInteger)length symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri;
        [Export("appendBarcodeBytes:length:symbology:width:height:hri:")]
        unsafe void AppendBarcodeBytes(IntPtr bytes, nuint length, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri);

        // -(void)appendBarcodeDataWithAbsolutePosition:(NSData *)otherData symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri position:(NSInteger)position;
        [Export("appendBarcodeDataWithAbsolutePosition:symbology:width:height:hri:position:")]
        void AppendBarcodeDataWithAbsolutePosition(NSData otherData, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri, nint position);

        // -(void)appendBarcodeBytesWithAbsolutePosition:(const void *)bytes length:(NSUInteger)length symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri position:(NSInteger)position;
        [Export("appendBarcodeBytesWithAbsolutePosition:length:symbology:width:height:hri:position:")]
        unsafe void AppendBarcodeBytesWithAbsolutePosition(IntPtr bytes, nuint length, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri, nint position);

        // -(void)appendBarcodeDataWithAlignment:(NSData *)otherData symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri position:(SCBAlignmentPosition)position;
        [Export("appendBarcodeDataWithAlignment:symbology:width:height:hri:position:")]
        void AppendBarcodeDataWithAlignment(NSData otherData, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri, SCBAlignmentPosition position);

        // -(void)appendBarcodeBytesWithAlignment:(const void *)bytes length:(NSUInteger)length symbology:(SCBBarcodeSymbology)symbology width:(SCBBarcodeWidth)width height:(NSInteger)height hri:(BOOL)hri position:(SCBAlignmentPosition)position;
        [Export("appendBarcodeBytesWithAlignment:length:symbology:width:height:hri:position:")]
        unsafe void AppendBarcodeBytesWithAlignment(IntPtr bytes, nuint length, SCBBarcodeSymbology symbology, SCBBarcodeWidth width, nint height, bool hri, SCBAlignmentPosition position);

        // -(void)appendPdf417Data:(NSData *)otherData line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect;
        [Export("appendPdf417Data:line:column:level:module:aspect:")]
        void AppendPdf417Data(NSData otherData, nint line, nint column, SCBPdf417Level level, nint module, nint aspect);

        // -(void)appendPdf417Bytes:(const void *)bytes length:(NSUInteger)length line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect;
        [Export("appendPdf417Bytes:length:line:column:level:module:aspect:")]
        unsafe void AppendPdf417Bytes(IntPtr bytes, nuint length, nint line, nint column, SCBPdf417Level level, nint module, nint aspect);

        // -(void)appendPdf417DataWithAbsolutePosition:(NSData *)otherData line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect position:(NSInteger)position;
        [Export("appendPdf417DataWithAbsolutePosition:line:column:level:module:aspect:position:")]
        void AppendPdf417DataWithAbsolutePosition(NSData otherData, nint line, nint column, SCBPdf417Level level, nint module, nint aspect, nint position);

        // -(void)appendPdf417BytesWithAbsolutePosition:(const void *)bytes length:(NSUInteger)length line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect position:(NSInteger)position;
        [Export("appendPdf417BytesWithAbsolutePosition:length:line:column:level:module:aspect:position:")]
        unsafe void AppendPdf417BytesWithAbsolutePosition(IntPtr bytes, nuint length, nint line, nint column, SCBPdf417Level level, nint module, nint aspect, nint position);

        // -(void)appendPdf417DataWithAlignment:(NSData *)otherData line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect position:(SCBAlignmentPosition)position;
        [Export("appendPdf417DataWithAlignment:line:column:level:module:aspect:position:")]
        void AppendPdf417DataWithAlignment(NSData otherData, nint line, nint column, SCBPdf417Level level, nint module, nint aspect, SCBAlignmentPosition position);

        // -(void)appendPdf417BytesWithAlignment:(const void *)bytes length:(NSUInteger)length line:(NSInteger)line column:(NSInteger)column level:(SCBPdf417Level)level module:(NSInteger)module aspect:(NSInteger)aspect position:(SCBAlignmentPosition)position;
        [Export("appendPdf417BytesWithAlignment:length:line:column:level:module:aspect:position:")]
        unsafe void AppendPdf417BytesWithAlignment(IntPtr bytes, nuint length, nint line, nint column, SCBPdf417Level level, nint module, nint aspect, SCBAlignmentPosition position);

        // -(void)appendQrCodeData:(NSData *)otherData model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell;
        [Export("appendQrCodeData:model:level:cell:")]
        void AppendQrCodeData(NSData otherData, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell);

        // -(void)appendQrCodeBytes:(const void *)bytes length:(NSUInteger)length model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell;
        [Export("appendQrCodeBytes:length:model:level:cell:")]
        unsafe void AppendQrCodeBytes(IntPtr bytes, nuint length, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell);

        // -(void)appendQrCodeDataWithAbsolutePosition:(NSData *)otherData model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell position:(NSInteger)position;
        [Export("appendQrCodeDataWithAbsolutePosition:model:level:cell:position:")]
        void AppendQrCodeDataWithAbsolutePosition(NSData otherData, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell, nint position);

        // -(void)appendQrCodeBytesWithAbsolutePosition:(const void *)bytes length:(NSUInteger)length model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell position:(NSInteger)position;
        [Export("appendQrCodeBytesWithAbsolutePosition:length:model:level:cell:position:")]
        unsafe void AppendQrCodeBytesWithAbsolutePosition(IntPtr bytes, nuint length, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell, nint position);

        // -(void)appendQrCodeDataWithAlignment:(NSData *)otherData model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell position:(SCBAlignmentPosition)position;
        [Export("appendQrCodeDataWithAlignment:model:level:cell:position:")]
        void AppendQrCodeDataWithAlignment(NSData otherData, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell, SCBAlignmentPosition position);

        // -(void)appendQrCodeBytesWithAlignment:(const void *)bytes length:(NSUInteger)length model:(SCBQrCodeModel)model level:(SCBQrCodeLevel)level cell:(NSInteger)cell position:(SCBAlignmentPosition)position;
        [Export("appendQrCodeBytesWithAlignment:length:model:level:cell:position:")]
        unsafe void AppendQrCodeBytesWithAlignment(IntPtr bytes, nuint length, SCBQrCodeModel model, SCBQrCodeLevel level, nint cell, SCBAlignmentPosition position);

        // -(void)appendBitmap:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale rotation:(SCBBitmapConverterRotation)rotation;
        [Export("appendBitmap:diffusion:width:bothScale:rotation:")]
        void AppendBitmap(UIImage image, bool diffusion, nint width, bool bothScale, SCBBitmapConverterRotation rotation);

        // -(void)appendBitmap:(UIImage *)image diffusion:(BOOL)diffusion rotation:(SCBBitmapConverterRotation)rotation;
        [Export("appendBitmap:diffusion:rotation:")]
        void AppendBitmap(UIImage image, bool diffusion, SCBBitmapConverterRotation rotation);

        // -(void)appendBitmap:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale;
        [Export("appendBitmap:diffusion:width:bothScale:")]
        void AppendBitmap(UIImage image, bool diffusion, nint width, bool bothScale);

        // -(void)appendBitmap:(UIImage *)image diffusion:(BOOL)diffusion;
        [Export("appendBitmap:diffusion:")]
        void AppendBitmap(UIImage image, bool diffusion);

        // -(void)appendBitmapWithAbsolutePosition:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale rotation:(SCBBitmapConverterRotation)rotation position:(NSInteger)position;
        [Export("appendBitmapWithAbsolutePosition:diffusion:width:bothScale:rotation:position:")]
        void AppendBitmapWithAbsolutePosition(UIImage image, bool diffusion, nint width, bool bothScale, SCBBitmapConverterRotation rotation, nint position);

        // -(void)appendBitmapWithAbsolutePosition:(UIImage *)image diffusion:(BOOL)diffusion rotation:(SCBBitmapConverterRotation)rotation position:(NSInteger)position;
        [Export("appendBitmapWithAbsolutePosition:diffusion:rotation:position:")]
        void AppendBitmapWithAbsolutePosition(UIImage image, bool diffusion, SCBBitmapConverterRotation rotation, nint position);

        // -(void)appendBitmapWithAbsolutePosition:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale position:(NSInteger)position;
        [Export("appendBitmapWithAbsolutePosition:diffusion:width:bothScale:position:")]
        void AppendBitmapWithAbsolutePosition(UIImage image, bool diffusion, nint width, bool bothScale, nint position);

        // -(void)appendBitmapWithAbsolutePosition:(UIImage *)image diffusion:(BOOL)diffusion position:(NSInteger)position;
        [Export("appendBitmapWithAbsolutePosition:diffusion:position:")]
        void AppendBitmapWithAbsolutePosition(UIImage image, bool diffusion, nint position);

        // -(void)appendBitmapWithAlignment:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale rotation:(SCBBitmapConverterRotation)rotation position:(SCBAlignmentPosition)position;
        [Export("appendBitmapWithAlignment:diffusion:width:bothScale:rotation:position:")]
        void AppendBitmapWithAlignment(UIImage image, bool diffusion, nint width, bool bothScale, SCBBitmapConverterRotation rotation, SCBAlignmentPosition position);

        // -(void)appendBitmapWithAlignment:(UIImage *)image diffusion:(BOOL)diffusion rotation:(SCBBitmapConverterRotation)rotation position:(SCBAlignmentPosition)position;
        [Export("appendBitmapWithAlignment:diffusion:rotation:position:")]
        void AppendBitmapWithAlignment(UIImage image, bool diffusion, SCBBitmapConverterRotation rotation, SCBAlignmentPosition position);

        // -(void)appendBitmapWithAlignment:(UIImage *)image diffusion:(BOOL)diffusion width:(NSInteger)width bothScale:(BOOL)bothScale position:(SCBAlignmentPosition)position;
        [Export("appendBitmapWithAlignment:diffusion:width:bothScale:position:")]
        void AppendBitmapWithAlignment(UIImage image, bool diffusion, nint width, bool bothScale, SCBAlignmentPosition position);

        // -(void)appendBitmapWithAlignment:(UIImage *)image diffusion:(BOOL)diffusion position:(SCBAlignmentPosition)position;
        [Export("appendBitmapWithAlignment:diffusion:position:")]
        void AppendBitmapWithAlignment(UIImage image, bool diffusion, SCBAlignmentPosition position);

        // -(void)appendBlackMark:(SCBBlackMarkType)type;
        [Export("appendBlackMark:")]
        void AppendBlackMark(SCBBlackMarkType type);

        // -(void)beginPageMode:(CGRect)rect rotation:(SCBBitmapConverterRotation)rotation;
        [Export("beginPageMode:rotation:")]
        void BeginPageMode(CGRect rect, SCBBitmapConverterRotation rotation);

        // -(void)endPageMode;
        [Export("endPageMode")]
        void EndPageMode();

        // -(void)appendPageModeVerticalAbsolutePosition:(NSInteger)position;
        [Export("appendPageModeVerticalAbsolutePosition:")]
        void AppendPageModeVerticalAbsolutePosition(nint position);

        // -(void)appendPageModeRotation:(SCBBitmapConverterRotation)rotation;
        [Export("appendPageModeRotation:")]
        void AppendPageModeRotation(SCBBitmapConverterRotation rotation);
    }

    // @interface ISDCBBuilder : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ISDCBBuilder
    {
        // @property (readonly, nonatomic) NSMutableData * commands;
        [Export("commands")]
        NSMutableData Commands { get; }

        // @property (readonly, nonatomic) NSMutableData * passThroughCommands;
        [Export("passThroughCommands")]
        NSMutableData PassThroughCommands { get; }

        // -(void)appendByte:(unsigned char)data;
        [Export("appendByte:")]
        void AppendByte(byte data);

        // -(void)appendData:(NSData *)otherData;
        [Export("appendData:")]
        void AppendData(NSData otherData);

        // -(void)appendBytes:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytes:length:")]
        unsafe void AppendBytes(IntPtr bytes, nuint length);

        // -(void)appendBackSpace;
        [Export("appendBackSpace")]
        void AppendBackSpace();

        // -(void)appendHorizontalTab;
        [Export("appendHorizontalTab")]
        void AppendHorizontalTab();

        // -(void)appendLineFeed;
        [Export("appendLineFeed")]
        void AppendLineFeed();

        // -(void)appendCarriageReturn;
        [Export("appendCarriageReturn")]
        void AppendCarriageReturn();

        // -(void)appendBitmap:(UIImage *)image diffusion:(BOOL)diffusion;
        [Export("appendBitmap:diffusion:")]
        void AppendBitmap(UIImage image, bool diffusion);

        // -(void)appendInternational:(SDCBInternationalType)type;
        [Export("appendInternational:")]
        void AppendInternational(SDCBInternationalType type);

        // -(void)appendCodePage:(SDCBCodePageType)type;
        [Export("appendCodePage:")]
        void AppendCodePage(SDCBCodePageType type);

        // -(void)appendDeleteToEndOfLine;
        [Export("appendDeleteToEndOfLine")]
        void AppendDeleteToEndOfLine();

        // -(void)appendClearScreen;
        [Export("appendClearScreen")]
        void AppendClearScreen();

        // -(void)appendHomePosition;
        [Export("appendHomePosition")]
        void AppendHomePosition();

        // -(void)appendTurnOn:(BOOL)turnOn;
        [Export("appendTurnOn:")]
        void AppendTurnOn(bool turnOn);

        // -(void)appendSpecifiedPosition:(int)x y:(int)y;
        [Export("appendSpecifiedPosition:y:")]
        void AppendSpecifiedPosition(int x, int y);

        // -(void)appendCursorMode:(SDCBCursorMode)cursorMode;
        [Export("appendCursorMode:")]
        void AppendCursorMode(SDCBCursorMode cursorMode);

        // -(void)appendContrastMode:(SDCBContrastMode)contrastMode;
        [Export("appendContrastMode:")]
        void AppendContrastMode(SDCBContrastMode contrastMode);

        // -(void)appendUserDefinedCharacter:(int)index code:(int)code font:(unsigned char *)font;
        [Export("appendUserDefinedCharacter:code:font:")]
        unsafe void AppendUserDefinedCharacter(int index, int code, IntPtr font);

        // -(void)appendUserDefinedDbcsCharacter:(int)index code:(int)code font:(unsigned char *)font;
        [Export("appendUserDefinedDbcsCharacter:code:font:")]
        unsafe void AppendUserDefinedDbcsCharacter(int index, int code, IntPtr font);
    }

    // @interface ISSCBBuilder : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ISSCBBuilder
    {
        // @property (readonly, nonatomic) NSMutableData * commands;
        [Export("commands")]
        NSMutableData Commands { get; }

        // @property (readonly, nonatomic) NSMutableData * passThroughCommands;
        [Export("passThroughCommands")]
        NSMutableData PassThroughCommands { get; }

        // -(void)appendByte:(unsigned char)data;
        [Export("appendByte:")]
        void AppendByte(byte data);

        // -(void)appendData:(NSData *)otherData;
        [Export("appendData:")]
        void AppendData(NSData otherData);

        // -(void)appendBytes:(const void *)bytes length:(NSUInteger)length;
        [Export("appendBytes:length:")]
        unsafe void AppendBytes(IntPtr bytes, nuint length);

        // -(void)appendZeroClear;
        [Export("appendZeroClear")]
        void AppendZeroClear();

        // -(void)appendUnitChange;
        [Export("appendUnitChange")]
        void AppendUnitChange();
    }

    // typedef StarIoExtParserCompletionResult (^StarIoExtParserCompletionHandler)(uint8_t *, int *);
    unsafe delegate long StarIoExtParserCompletionHandler(IntPtr arg0, IntPtr arg1);

    // @interface ISCPParser : NSObject
    [Protocol]
    [BaseType(typeof(NSObject))]
    interface ISCPParser
    {
        // @property (copy, nonatomic) StarIoExtParserCompletionHandler completionHandler;
        [Export("completionHandler", ArgumentSemantic.Copy)]
        StarIoExtParserCompletionHandler CompletionHandler { get; set; }

        // -(NSData *)createSendCommands;
        [Export("createSendCommands")]
        //[Verify(MethodToProperty)]
        NSData CreateSendCommands();

        // -(NSData *)createReceiveCommands;
        [Export("createReceiveCommands")]
        //[Verify(MethodToProperty)]
        NSData CreateReceiveCommands();
    }

    // @interface ISCPConnectParser : ISCPParser
    [Protocol]

    [BaseType(typeof(ISCPParser))]
    interface ISCPConnectParser
    {
        // -(BOOL)connect;
        [Export("connect")]
        //[Verify(MethodToProperty)]
        bool Connect();
    }

    // @interface ISSCPWeightParser : ISCPParser
    [Protocol]
    [BaseType(typeof(ISCPParser))]
    interface ISSCPWeightParser
    {
        // -(StarIoExtDisplayedWeightStatus)status;
        [Export("status")]
        //[Verify(MethodToProperty)]
        StarIoExtDisplayedWeightStatus Status();

        // -(NSString *)weight;
        [Export("weight")]
        //[Verify(MethodToProperty)]
        string Weight();

        // -(NSData *)createSendCommands;
        [Export("createSendCommands")]
        //[Verify(MethodToProperty)]
        NSData CreateSendCommands();

        // -(NSData *)createReceiveCommands;
        [Export("createReceiveCommands")]
        //[Verify(MethodToProperty)]
        NSData CreateReceiveCommands();
    }

    // @interface StarIoExt : NSObject
    [BaseType(typeof(NSObject))]
    interface StarIoExt
    {
        // +(NSString *)description;
        [Static]
        [Export("description")]
        //[Verify(MethodToProperty)]
        string Description();

        // +(ISCBBuilder *)createCommandBuilder:(StarIoExtEmulation)emulation;
        [Static]
        [Export("createCommandBuilder:")]
        ISCBBuilder CreateCommandBuilder(StarIoExtEmulation emulation);

        // +(ISDCBBuilder *)createDisplayCommandBuilder:(StarIoExtDisplayModel)model;
        [Static]
        [Export("createDisplayCommandBuilder:")]
        ISDCBBuilder CreateDisplayCommandBuilder(StarIoExtDisplayModel model);

        // +(ISSCBBuilder *)createScaleCommandBuilder:(StarIoExtScaleModel)model;
        [Static]
        [Export("createScaleCommandBuilder:")]
        ISSCBBuilder CreateScaleCommandBuilder(StarIoExtScaleModel model);

        // +(ISCPConnectParser *)createBcrConnectParser:(StarIoExtBcrModel)model;
        [Static]
        [Export("createBcrConnectParser:")]
        ISCPConnectParser CreateBcrConnectParser(StarIoExtBcrModel model);

        // +(ISCPConnectParser *)createDisplayConnectParser:(StarIoExtDisplayModel)model;
        [Static]
        [Export("createDisplayConnectParser:")]
        ISCPConnectParser CreateDisplayConnectParser(StarIoExtDisplayModel model);

        // +(ISCPConnectParser *)createScaleConnectParser:(StarIoExtScaleModel)model;
        [Static]
        [Export("createScaleConnectParser:")]
        ISCPConnectParser CreateScaleConnectParser(StarIoExtScaleModel model);

        // +(ISSCPWeightParser *)createScaleWeightParser:(StarIoExtScaleModel)model;
        [Static]
        [Export("createScaleWeightParser:")]
        ISSCPWeightParser CreateScaleWeightParser(StarIoExtScaleModel model);
    }
}
