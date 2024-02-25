using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using System.Collections.Generic;

namespace iOS.ZebraLinkOs
{

    // The first step to creating a binding is to add your native framework ("MyLibrary.xcframework")
    // to the project.
    // Open your binding csproj and add a section like this
    // <ItemGroup>
    //   <NativeReference Include="MyLibrary.xcframework">
    //     <Kind>Framework</Kind>
    //     <Frameworks></Frameworks>
    //   </NativeReference>
    // </ItemGroup>
    //
    // Once you've added it, you will need to customize it for your specific library:
    //  - Change the Include to the correct path/name of your library
    //  - Change Kind to Static (.a) or Framework (.framework/.xcframework) based upon the library kind and extension.
    //    - Dynamic (.dylib) is a third option but rarely if ever valid, and only on macOS and Mac Catalyst
    //  - If your library depends on other frameworks, add them inside <Frameworks></Frameworks>
    // Example:
    // <NativeReference Include="libs\MyTestFramework.xcframework">
    //   <Kind>Framework</Kind>
    //   <Frameworks>CoreLocation ModelIO</Frameworks>
    // </NativeReference>
    // 
    // Once you've done that, you're ready to move on to binding the API...
    //
    // Here is where you'd define your API definition for the native Objective-C library.
    //
    // For example, to bind the following Objective-C class:
    //
    //     @interface Widget : NSObject {
    //     }
    //
    // The C# binding would look like this:
    //
    //     [BaseType (typeof (NSObject))]
    //     interface Widget {
    //     }
    //
    // To bind Objective-C properties, such as:
    //
    //     @property (nonatomic, readwrite, assign) CGPoint center;
    //
    // You would add a property definition in the C# interface like so:
    //
    //     [Export ("center")]
    //     CGPoint Center { get; set; }
    //
    // To bind an Objective-C method, such as:
    //
    //     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
    //
    // You would add a method definition to the C# interface like so:
    //
    //     [Export ("doSomething:atIndex:")]
    //     void DoSomething (NSObject object, nint index);
    //
    // Objective-C "constructors" such as:
    //
    //     -(id)initWithElmo:(ElmoMuppet *)elmo;
    //
    // Can be bound as:
    //
    //     [Export ("initWithElmo:")]
    //     NativeHandle Constructor (ElmoMuppet elmo);
    //
    // For more information, see https://aka.ms/ios-binding
    //


    // @protocol FileUtil
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/

    // @protocol GraphicsUtil
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol,Model]
    [BaseType(typeof(NSObject))]
    interface GraphicsUtil
    {
        // @required -(BOOL)printImage:(CGImageRef)image atX:(NSInteger)x atY:(NSInteger)y withWidth:(NSInteger)width withHeight:(NSInteger)height andIsInsideFormat:(BOOL)isInsideFormat error:(NSError **)error;
        [Abstract]
        [Export("printImage:atX:atY:withWidth:withHeight:andIsInsideFormat:error:")]
        bool PrintImage(CGImage image, nint x, nint y, nint width, nint height, bool isInsideFormat, out NSError error);

    }
    interface IGraphicsUtil { } //Skeleton to return enable returning Interface 

    // @protocol ResponseValidator
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ResponseValidator
    {
        // @required -(BOOL)isResponseComplete:(NSData *)data;
        [Abstract]
        [Export("isResponseComplete:")]
        bool IsResponseComplete(NSData data);
    }

    // @protocol ZebraPrinterConnection
    /*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
    [Protocol,Model]
    [BaseType(typeof(NSObject))]
    interface ZebraPrinterConnection
    {
        // @required -(NSString *)toString;
        [Abstract]
        [Export("toString")]
        string ToString();

        // @required -(NSInteger)getMaxTimeoutForRead;
        [Abstract]
        [Export("getMaxTimeoutForRead")]
        nint MaxTimeoutForRead();

        // @required -(NSInteger)getTimeToWaitForMoreData;
        [Abstract]
        [Export("getTimeToWaitForMoreData")]
        nint TimeToWaitForMoreData();

        // @required -(void)setMaxTimeoutForRead:(NSInteger)paramMaxTimeoutForRead;
        [Abstract]
        [Export("setMaxTimeoutForRead:")]
        void SetMaxTimeoutForRead(nint paramMaxTimeoutForRead);

        // @required -(void)setTimeToWaitForMoreData:(NSInteger)paramMimeToWaitForMoreData;
        [Abstract]
        [Export("setTimeToWaitForMoreData:")]
        void SetTimeToWaitForMoreData(nint paramMimeToWaitForMoreData);

        // @required -(BOOL)isConnected;
        [Abstract]
        [Export("isConnected")]
        bool IsConnected();

        // @required -(BOOL)open;
        [Abstract]
        [Export("open")]
        bool Open();

        // @required -(void)close;
        [Abstract]
        [Export("close")]
        void Close();

        // @required -(NSInteger)write:(NSData *)data error:(NSError **)error;
        [Abstract]
        [Export("write:error:")]
        nint Write(NSData data, out NSError error);

        // @required -(NSInteger)write:(NSData *)data withOffset:(NSInteger)offset andWithLength:(NSInteger)length error:(NSError **)error;
        [Abstract]
        [Export("write:withOffset:andWithLength:error:")]
        nint Write(NSData data, nint offset, nint length, out NSError error);

        // @required -(NSInteger)writeStream:(NSInputStream *)dataSource error:(NSError **)error;
        [Abstract]
        [Export("writeStream:error:")]
        nint WriteStream(NSInputStream dataSource, out NSError error);

        // @required -(NSData *)read:(NSError **)error;
        [Abstract]
        [Export("read:")]
        NSData Read(out NSError error);

        // @required -(void)read:(NSOutputStream *)destinationStream error:(NSError **)error;
        [Abstract]
        [Export("read:error:")]
        void Read(NSOutputStream destinationStream, out NSError error);

        // @required -(NSString *)getSimpleConnectionName;
        [Abstract]
        [Export("getSimpleConnectionName")]
        string SimpleConnectionName();

        // @required -(BOOL)hasBytesAvailable;
        [Abstract]
        [Export("hasBytesAvailable")]
        bool HasBytesAvailable();

        // @required -(void)waitForData:(NSInteger)maxTimeout;
        [Abstract]
        [Export("waitForData:")]
        void WaitForData(nint maxTimeout);

        // @required -(NSData *)sendAndWaitForResponse:(NSData *)data withResponseValidator:(id<ResponseValidator,NSObject>)validator withError:(NSError **)error;
        [Abstract]
        [Export("sendAndWaitForResponse:withResponseValidator:withError:")]
        NSData SendAndWaitForResponse(NSData data, ResponseValidator validator, out NSError error);

        // @required -(NSData *)sendAndWaitForResponse:(NSData *)data withMaxTimeoutForRead:(NSInteger)maxTimeoutForRead andWithTimeToWaitForMoreData:(NSInteger)timeToWaitForMoreData withResponseValidator:(id<ResponseValidator,NSObject>)validator andWithError:(NSError **)error;
        [Abstract]
        [Export("sendAndWaitForResponse:withMaxTimeoutForRead:andWithTimeToWaitForMoreData:withResponseValidator:andWithError:")]
        NSData SendAndWaitForResponse(NSData data, nint maxTimeoutForRead, nint timeToWaitForMoreData, [NullAllowed] ResponseValidator validator, out NSError error);

    }

    // @interface NetworkDiscoverer : NSObject
    [BaseType(typeof(NSObject))]
    interface NetworkDiscoverer
    {
        // +(NSArray *)multicastWithHops:(NSInteger)hops error:(NSError **)error;
        [Static]
        [Export("multicastWithHops:error:")]
        NSObject[] MulticastWithHops(nint hops, out NSError error);

        // +(NSArray *)multicastWithHops:(NSInteger)hops andWaitForResponsesTimeout:(NSInteger)waitForResponsesTimeout error:(NSError **)error;
        [Static]
        [Export("multicastWithHops:andWaitForResponsesTimeout:error:")]
        NSObject[] MulticastWithHops(nint hops, nint waitForResponsesTimeout, out NSError error);

        // +(NSArray *)subnetSearchWithRange:(NSString *)subnetRange error:(NSError **)error;
        [Static]
        [Export("subnetSearchWithRange:error:")]
        NSObject[] SubnetSearchWithRange(string subnetRange, out NSError error);

        // +(NSArray *)subnetSearchWithRange:(NSString *)subnetRange andWaitForResponsesTimeout:(NSInteger)waitForResponsesTimeout error:(NSError **)error;
        [Static]
        [Export("subnetSearchWithRange:andWaitForResponsesTimeout:error:")]
        NSObject[] SubnetSearchWithRange(string subnetRange, nint waitForResponsesTimeout, out NSError error);

        // +(NSArray *)directedBroadcastWithIpAddress:(NSString *)ipAddress error:(NSError **)error;
        [Static]
        [Export("directedBroadcastWithIpAddress:error:")]
        NSObject[] DirectedBroadcastWithIpAddress(string ipAddress, out NSError error);

        // +(NSArray *)directedBroadcastWithIpAddress:(NSString *)ipAddress andWaitForResponsesTimeout:(NSInteger)waitForResponsesTimeout error:(NSError **)error;
        [Static]
        [Export("directedBroadcastWithIpAddress:andWaitForResponsesTimeout:error:")]
        NSObject[] DirectedBroadcastWithIpAddress(string ipAddress, nint waitForResponsesTimeout, out NSError error);

        // +(NSArray *)localBroadcast:(NSError **)error;
        [Static]
        [Export("localBroadcast:")]
        NSObject[] LocalBroadcast(out NSError error);

        // +(NSArray *)localBroadcastWithTimeout:(NSInteger)waitForResponsesTimeout error:(NSError **)error;
        [Static]
        [Export("localBroadcastWithTimeout:error:")]
        NSObject[] LocalBroadcastWithTimeout(nint waitForResponsesTimeout, out NSError error);
    }


    // @interface PrinterStatus : NSObject
    [BaseType(typeof(NSObject))]
    interface PrinterStatus
    {
        // @property (assign) BOOL isReadyToPrint;
        [Export("isReadyToPrint")]
        bool IsReadyToPrint { get; set; }

        // @property (assign) BOOL isHeadOpen;
        [Export("isHeadOpen")]
        bool IsHeadOpen { get; set; }

        // @property (assign) BOOL isHeadCold;
        [Export("isHeadCold")]
        bool IsHeadCold { get; set; }

        // @property (assign) BOOL isHeadTooHot;
        [Export("isHeadTooHot")]
        bool IsHeadTooHot { get; set; }

        // @property (assign) BOOL isPaperOut;
        [Export("isPaperOut")]
        bool IsPaperOut { get; set; }

        // @property (assign) BOOL isRibbonOut;
        [Export("isRibbonOut")]
        bool IsRibbonOut { get; set; }

        // @property (assign) BOOL isReceiveBufferFull;
        [Export("isReceiveBufferFull")]
        bool IsReceiveBufferFull { get; set; }

        // @property (assign) BOOL isPaused;
        [Export("isPaused")]
        bool IsPaused { get; set; }

        // @property (assign) NSInteger labelLengthInDots;
        [Export("labelLengthInDots")]
        nint LabelLengthInDots { get; set; }

        // @property (assign) NSInteger numberOfFormatsInReceiveBuffer;
        [Export("numberOfFormatsInReceiveBuffer")]
        nint NumberOfFormatsInReceiveBuffer { get; set; }

        // @property (assign) NSInteger labelsRemainingInBatch;
        [Export("labelsRemainingInBatch")]
        nint LabelsRemainingInBatch { get; set; }

        // @property (assign) BOOL isPartialFormatInProgress;
        [Export("isPartialFormatInProgress")]
        bool IsPartialFormatInProgress { get; set; }

        // @property (assign) ZplPrintMode printMode;
        [Export("printMode", ArgumentSemantic.Assign)]
        ZplPrintMode PrintMode { get; set; }
    }


    // @interface TcpPrinterConnection : NSObject <ZebraPrinterConnection>
    [BaseType(typeof(NSObject))]
    interface TcpPrinterConnection : ZebraPrinterConnection
    {
        // -(id)initWithAddress:(NSString *)anAddress andWithPort:(NSInteger)aPort;
        [Export("initWithAddress:andWithPort:")]
        NativeHandle Constructor(string anAddress, nint aPort);

        // -(id)initWithAddress:(NSString *)anAddress withPort:(NSInteger)aPort withMaxTimeoutForRead:(NSInteger)aMaxTimeoutForRead andWithTimeToWaitForMoreData:(NSInteger)aTimeToWaitForMoreData;
        [Export("initWithAddress:withPort:withMaxTimeoutForRead:andWithTimeToWaitForMoreData:")]
        NativeHandle Constructor(string anAddress, nint aPort, nint aMaxTimeoutForRead, nint aTimeToWaitForMoreData);

        // +(NSInteger)DEFAULT_MAX_TIMEOUT_FOR_READ;
        [Static]
        [Export("DEFAULT_MAX_TIMEOUT_FOR_READ")]
        nint DEFAULT_MAX_TIMEOUT_FOR_READ();

        // +(NSInteger)DEFAULT_TIME_TO_WAIT_FOR_MORE_DATA;
        [Static]
        [Export("DEFAULT_TIME_TO_WAIT_FOR_MORE_DATA")]
        nint DEFAULT_TIME_TO_WAIT_FOR_MORE_DATA();

        // -(void)setMaxTimeoutForOpen:(int)aTimeout;
        [Export("setMaxTimeoutForOpen:")]
        void SetMaxTimeoutForOpen(int aTimeout);
    }

    // @protocol ZebraPrinter
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface ZebraPrinter
    {
        // @required -(id<GraphicsUtil,NSObject>)getGraphicsUtil;
        [Abstract]
        [Export("getGraphicsUtil")]
        IGraphicsUtil GraphicsUtil();

        // @required -(PrinterStatus *)getCurrentStatus:(NSError **)error;
        [Abstract]
        [Export("getCurrentStatus:")]
        PrinterStatus GetCurrentStatus(out NSError error);
    }

    interface IZebraPrinter { } //Skeleton Interface to enalbe returning interface type

    // @interface ZebraPrinterFactory : NSObject
    [BaseType(typeof(NSObject))]
    interface ZebraPrinterFactory
    {
        // +(id<ZebraPrinter,NSObject>)getInstance:(id<ZebraPrinterConnection,NSObject>)connection error:(NSError **)error;
        [Static]
        [Export("getInstance:error:")]
        IZebraPrinter GetInstance(TcpPrinterConnection connection, out NSError error);

        // +(id<ZebraPrinter,NSObject>)getInstance:(id<ZebraPrinterConnection,NSObject>)connection withPrinterLanguage:(PrinterLanguage)language;
        [Static]
        [Export("getInstance:withPrinterLanguage:")]
        IZebraPrinter GetInstance(TcpPrinterConnection connection, PrinterLanguage language);
    }

}
