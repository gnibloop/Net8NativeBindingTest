using System;
using CoreBluetooth;
using ExternalAccessory;
using Foundation;
using ObjCRuntime;

namespace iOS.StarIO
{
    // @interface ExternalAccessoryPort : NSObject <NSStreamDelegate>
    [BaseType(typeof(NSObject))]
    interface ExternalAccessoryPort : INSStreamDelegate
    {
        // @property (readonly, getter = isConnected) BOOL connected;
        [Export("connected")]
        bool Connected { [Bind("isConnected")] get; }

        // @property (readwrite) u_int32_t endCheckedBlockTimeoutMillis;
        [Export("endCheckedBlockTimeoutMillis")]
        uint EndCheckedBlockTimeoutMillis { get; set; }

        // @property (assign, nonatomic) NSInteger dataTimeoutSeconds;
        [Export("dataTimeoutSeconds")]
        nint DataTimeoutSeconds { get; set; }

        // @property (readonly, retain) NSString * firmwareInformation;
        [Export("firmwareInformation", ArgumentSemantic.Retain)]
        string FirmwareInformation { get; }

        // @property (readonly, retain) NSMutableArray * dipSwitchInformation;
        [Export("dipSwitchInformation", ArgumentSemantic.Retain)]
        NSMutableArray DipSwitchInformation { get; }

        // @property (readonly, assign) BOOL isDKAirCash;
        [Export("isDKAirCash")]
        bool IsDKAirCash { get; }

        // @property (retain) NSThread * thread71;
        [Export("thread71", ArgumentSemantic.Retain)]
        NSThread Thread71 { get; set; }

        // @property (retain) NSNumber * result71;
        [Export("result71", ArgumentSemantic.Retain)]
        NSNumber Result71 { get; set; }

        // @property (readonly, assign) float secShortInterval;
        [Export("secShortInterval")]
        float SecShortInterval { get; }

        // @property (readonly, assign) float secInterval;
        [Export("secInterval")]
        float SecInterval { get; }

        // -(id)initWithPortName:(NSString *)portName portSettings:(NSString *)portSettings timeout:(u_int32_t)timeout emulation:(SMEmulation)emulation;
        [Export("initWithPortName:portSettings:timeout:emulation:")]
        IntPtr Constructor(string portName, string portSettings, uint timeout, SMEmulation emulation);

        // -(BOOL)open;
        [Export("open")]
        bool Open();

        // -(int)write:(NSData *)data;
        [Export("write:")]
        int Write(NSData data);

        // -(NSData *)read:(NSUInteger)bytesToRead;
        [Export("read:")]
        NSData Read(nuint bytesToRead);

        // -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
        [Export("getParsedStatus:level:")]
        unsafe bool GetParsedStatus(StarPrinterStatus_2 starPrinterStatus, uint level);

        // -(BOOL)getOnlineStatus:(BOOL *)onlineStatus;
        [Export("getOnlineStatus:")]
        unsafe bool GetOnlineStatus(bool onlineStatus);

        // -(BOOL)retrieveFirmwareInformation;
        [Export("retrieveFirmwareInformation")]
        bool RetrieveFirmwareInformation();

        // -(BOOL)retrieveFirmwareInformation2;
        [Export("retrieveFirmwareInformation2")]
        bool RetrieveFirmwareInformation2();

        // -(BOOL)retrieveDipSwitchInformation;
        [Export("retrieveDipSwitchInformation")]
        bool RetrieveDipSwitchInformation();

        // -(NSInteger)retrieveButtonSecurityTimeout;
        [Export("retrieveButtonSecurityTimeout")]
        nint RetrieveButtonSecurityTimeout();

        // -(BOOL)beginCheckedBlock:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
        [Export("beginCheckedBlock:level:")]
        unsafe bool BeginCheckedBlock(StarPrinterStatus_2 starPrinterStatus, uint level);

        // -(BOOL)endCheckedBlock:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
        [Export("endCheckedBlock:level:")]
        unsafe bool EndCheckedBlock(StarPrinterStatus_2 starPrinterStatus, uint level);

        // -(void)close;
        [Export("close")]
        void Close();

        // -(BOOL)disconnect;
        [Export("disconnect")]
        bool Disconnect();

        // -(BOOL)startDataCancel;
        [Export("startDataCancel")]
        bool StartDataCancel();
    }

    // @interface BluetoothPort : ExternalAccessoryPort
    [BaseType(typeof(ExternalAccessoryPort))]
    interface BluetoothPort
    {
    }

    // @interface Lock : NSObject
    [BaseType(typeof(NSObject))]
    interface Lock
    {
        // +(Lock *)sharedManager;
        [Static]
        [Export("sharedManager")]
        Lock SharedManager();

        // -(void)lock;
        [Export("lock")]
        void DoLock();

        // -(void)unlock;
        [Export("unlock")]
        void Unlock();
    }

    // @interface SMBluetoothManager : NSObject
    [BaseType(typeof(NSObject))]
    interface SMBluetoothManager
    {
        // @property (readonly, retain) NSString * portName;
        [Export("portName", ArgumentSemantic.Retain)]
        string PortName { get; }

        // @property (readonly, assign) SMDeviceType deviceType;
        [Export("deviceType", ArgumentSemantic.Assign)]
        SMDeviceType DeviceType { get; }

        // @property (readonly, assign) BOOL opened;
        [Export("opened")]
        bool Opened { get; }

        // @property (retain) NSString * deviceName;
        [Export("deviceName", ArgumentSemantic.Retain)]
        string DeviceName { get; set; }

        // @property (retain) NSString * iOSPortName;
        [Export("iOSPortName", ArgumentSemantic.Retain)]
        string IOSPortName { get; set; }

        // @property (assign) BOOL autoConnect;
        [Export("autoConnect")]
        bool AutoConnect { get; set; }

        // @property (assign) SMBluetoothSecurity security;
        [Export("security", ArgumentSemantic.Assign)]
        SMBluetoothSecurity Security { get; set; }

        // @property (assign) BOOL pairingPermission;
        [Export("pairingPermission")]
        bool PairingPermission { get; set; }

        // @property (retain) NSString * pinCode;
        [Export("pinCode", ArgumentSemantic.Retain)]
        string PinCode { get; set; }

        // @property (assign) BOOL discoveryPermission;
        [Export("discoveryPermission")]
        bool DiscoveryPermission { get; set; }

        // @property (assign) BOOL bluetoothDiagnosticMode;
        [Export("bluetoothDiagnosticMode")]
        bool BluetoothDiagnosticMode { get; set; }

        // @property (readonly, assign) SMBluetoothSettingCapability deviceNameCapability;
        [Export("deviceNameCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability DeviceNameCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability iOSPortNameCapability;
        [Export("iOSPortNameCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability IOSPortNameCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability autoConnectCapability;
        [Export("autoConnectCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability AutoConnectCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability securityTypeCapability;
        [Export("securityTypeCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability SecurityTypeCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability pairingPermissionCapability;
        [Export("pairingPermissionCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability PairingPermissionCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability pinCodeCapability;
        [Export("pinCodeCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability PinCodeCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability discoveryPermissionCapability;
        [Export("discoveryPermissionCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability DiscoveryPermissionCapability { get; }

        // @property (readonly, assign) SMBluetoothSettingCapability bluetoothDiagnosticModeCapability;
        [Export("bluetoothDiagnosticModeCapability", ArgumentSemantic.Assign)]
        SMBluetoothSettingCapability BluetoothDiagnosticModeCapability { get; }

        // -(id)initWithPortName:(NSString *)portName deviceType:(SMDeviceType)deviceType;
        [Export("initWithPortName:deviceType:")]
        IntPtr Constructor(string portName, SMDeviceType deviceType);

        // -(BOOL)open;
        [Export("open")]
        bool Open();

        // -(BOOL)loadSetting;
        [Export("loadSetting")]
        bool LoadSetting();

        // -(BOOL)apply;
        [Export("apply")]
        bool Apply();

        // -(void)close;
        [Export("close")]
        void Close();
    }

    // @interface WBluetoothPort : NSObject <NSStreamDelegate>
    [BaseType(typeof(NSObject))]
    interface WBluetoothPort : INSStreamDelegate
    {
        // @property (readonly, getter = isConnected) BOOL connected;
        [Export("connected")]
        bool Connected { [Bind("isConnected")] get; }

        // @property (readwrite) u_int32_t endCheckedBlockTimeoutMillis;
        [Export("endCheckedBlockTimeoutMillis")]
        uint EndCheckedBlockTimeoutMillis { get; set; }

        // @property (readonly, retain) NSString * firmwareInformation;
        [Export("firmwareInformation", ArgumentSemantic.Retain)]
        string FirmwareInformation { get; }

        // -(id)initWithPortName:(NSString *)portName portSettings:(NSString *)portSettings timeout:(u_int32_t)timeout;
        [Export("initWithPortName:portSettings:timeout:")]
        IntPtr Constructor(string portName, string portSettings, uint timeout);

        // -(BOOL)open;
        [Export("open")]
        bool Open();

        // -(int32_t)write:(NSData *)data;
        [Export("write:")]
        int Write(NSData data);

        // -(NSData *)read:(NSUInteger)bytesToRead;
        [Export("read:")]
        NSData Read(nuint bytesToRead);

        // -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level;
        [Export("getParsedStatus:level:")]
        unsafe bool GetParsedStatus(StarPrinterStatus_2 starPrinterStatus, uint level);

        // -(BOOL)getParsedStatus:(StarPrinterStatus_2 *)starPrinterStatus level:(u_int32_t)level timeoutSec:(__darwin_time_t)timeoutSec;
        [Export("getParsedStatus:level:timeoutSec:")]
        unsafe bool GetParsedStatus(StarPrinterStatus_2 starPrinterStatus, uint level, nint timeoutSec);

        // -(BOOL)retrieveFirmwareInformation;
        [Export("retrieveFirmwareInformation")]
        bool RetrieveFirmwareInformation();

        // -(BOOL)retrieveDipSwitchInformation;
        [Export("retrieveDipSwitchInformation")]
        bool RetrieveDipSwitchInformation();

        // -(BOOL)getOnlineStatus:(BOOL *)onlineStatus;
        [Export("getOnlineStatus:")]
        unsafe bool GetOnlineStatus(bool onlineStatus);

        // -(BOOL)beginCheckedBlock;
        [Export("beginCheckedBlock")]
        bool BeginCheckedBlock();

        // -(BOOL)endCheckedBlock;
        [Export("endCheckedBlock")]
        bool EndCheckedBlock();

        // -(void)close;
        [Export("close")]
        void Close();
    }

    // @interface PortException : NSException
    [BaseType(typeof(NSException))]
    interface PortException
    {
    }

    // @interface PortInfo : NSObject
    [BaseType(typeof(NSObject))]
    interface PortInfo
    {
        // -(id)initWithPortName:(NSString *)portName_ macAddress:(NSString *)macAddress_ modelName:(NSString *)modelName_;
        [Export("initWithPortName:macAddress:modelName:")]
        IntPtr Constructor(string portName_, string macAddress_, string modelName_);

        // @property (readonly, retain) NSString * portName;
        [Export("portName", ArgumentSemantic.Retain)]
        string PortName { get; }

        // @property (readonly, retain) NSString * macAddress;
        [Export("macAddress", ArgumentSemantic.Retain)]
        string MacAddress { get; }

        // @property (readonly, retain) NSString * modelName;
        [Export("modelName", ArgumentSemantic.Retain)]
        string ModelName { get; }
    }

    // @interface SMPort : NSObject
    [BaseType(typeof(NSObject))]
    interface SMPort
    {
        // @property (assign, readwrite, nonatomic) u_int32_t endCheckedBlockTimeoutMillis;
        [Export("endCheckedBlockTimeoutMillis")]
        uint EndCheckedBlockTimeoutMillis { get; set; }

        // +(NSString *)StarIOVersion;
        [Static]
        [Export("StarIOVersion")]
        string StarIOVersion();

        // -(id)init:(NSString *)portName :(NSString *)portSettings :(u_int32_t)ioTimeoutMillis;
        [Export("init:::")]
        IntPtr Constructor(string portName, string portSettings, uint ioTimeoutMillis);

        // +(NSArray *)searchPrinter;
        [Static]
        [Export("searchPrinter")]
        PortInfo[] SearchPrinter();

        // +(NSArray *)searchPrinter:(NSString *)target;
        [Static]
        [Export("searchPrinter:")]
        PortInfo[] SearchPrinter(string target);

        // +(SMPort *)getPort:(NSString *)portName :(NSString *)portSettings :(u_int32_t)ioTimeoutMillis;
        [Static]
        [Export("getPort:::")]
        SMPort GetPort(string portName, string portSettings, uint ioTimeoutMillis);

        // +(void)releasePort:(SMPort *)port;
        [Static]
        [Export("releasePort:")]
        void ReleasePort(SMPort port);

        // -(u_int32_t)writePort:(const u_int8_t *)writeBuffer :(u_int32_t)offSet :(u_int32_t)size;
        [Export("writePort:::")]
        unsafe uint WritePort(IntPtr writeBuffer, uint offSet, uint size);

        // -(u_int32_t)readPort:(u_int8_t *)readBuffer :(u_int32_t)offSet :(u_int32_t)size;
        [Export("readPort:::")]
        unsafe uint ReadPort(IntPtr readBuffer, uint offSet, uint size);

        // -(void)getParsedStatus:(void *)starPrinterStatus :(u_int32_t)level;
        [Export("getParsedStatus::")]
        unsafe void GetParsedStatus(IntPtr starPrinterStatus, uint level);

        // -(NSDictionary *)getFirmwareInformation;
        [Export("getFirmwareInformation")]
        NSDictionary FirmwareInformation();

        // -(NSDictionary *)getDipSwitchInformation;
        [Export("getDipSwitchInformation")]
        NSDictionary DipSwitchInformation();

        // -(_Bool)getOnlineStatus;
        [Export("getOnlineStatus")]
        bool OnlineStatus();

        // -(void)beginCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level;
        [Export("beginCheckedBlock::")]
        unsafe void BeginCheckedBlock(IntPtr starPrinterStatus, uint level);

        // -(void)endCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level;
        [Export("endCheckedBlock::")]
        unsafe void EndCheckedBlock(IntPtr starPrinterStatus, uint level);

        // -(BOOL)disconnect;
        [Export("disconnect")]
        bool Disconnect();

        // +(NSMutableData *)compressRasterData:(int32_t)width :(int32_t)height :(u_int8_t *)imageData :(NSString *)portSettings;
        [Static]
        [Export("compressRasterData::::")]
        unsafe NSMutableData CompressRasterData(int width, int height, IntPtr imageData, string portSettings);

        // +(NSMutableData *)generateBitImageCommand:(int32_t)width :(int32_t)height :(u_int8_t *)imageData :(NSString *)portSettings __attribute__((deprecated("")));
        [Static]
        [Export("generateBitImageCommand::::")]
        unsafe NSMutableData GenerateBitImageCommand(int width, int height, IntPtr imageData, string portSettings);

        // -(NSString *)portName;
        [Export("portName")]
        string PortName();

        // -(NSString *)portSettings;
        [Export("portSettings")]
        string PortSettings();

        // -(u_int32_t)timeoutMillis;
        [Export("timeoutMillis")]
        uint TimeoutMillis();

        // -(BOOL)connected;
        [Export("connected")]
        bool Connected();

        // +(void)setMACAddressSourceBlock:(NSString *(^)(EAAccessory *))macAddressSourceBlock;
        [Static]
        [Export("setMACAddressSourceBlock:")]
        void SetMACAddressSourceBlock(Func<EAAccessory, NSString> macAddressSourceBlock);

        // -(u_int32_t)writePort:(const u_int8_t *)writeBuffer :(u_int32_t)offSet :(u_int32_t)size :(NSError **)error;
        [Export("writePort::::")]
        unsafe uint WritePort(IntPtr writeBuffer, uint offSet, uint size, out NSError error);

        // -(u_int32_t)readPort:(u_int8_t *)readBuffer :(u_int32_t)offSet :(u_int32_t)size :(NSError **)error;
        [Export("readPort::::")]
        unsafe uint ReadPort(IntPtr readBuffer, uint offSet, uint size, out NSError error);

        // -(u_int32_t)getParsedStatus:(void *)starPrinterStatus :(u_int32_t)level :(NSError **)error;
        [Export("getParsedStatus:::")]
        unsafe uint GetParsedStatus(IntPtr starPrinterStatus, uint level, out NSError error);

        // -(NSDictionary *)getFirmwareInformation:(NSError **)error;
        [Export("getFirmwareInformation:")]
        NSDictionary GetFirmwareInformation(out NSError error);

        // -(NSDictionary *)getDipSwitchInformation:(NSError **)error;
        [Export("getDipSwitchInformation:")]
        NSDictionary GetDipSwitchInformation(out NSError error);

        // -(u_int32_t)getOnlineStatusWithError:(NSError **)error;
        [Export("getOnlineStatusWithError:")]
        uint GetOnlineStatusWithError(out NSError error);

        // -(u_int32_t)beginCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level :(NSError **)error;
        [Export("beginCheckedBlock:::")]
        unsafe uint BeginCheckedBlock(IntPtr starPrinterStatus, uint level, out NSError error);

        // -(u_int32_t)endCheckedBlock:(void *)starPrinterStatus :(u_int32_t)level :(NSError **)error;
        [Export("endCheckedBlock:::")]
        unsafe uint EndCheckedBlock(IntPtr starPrinterStatus, uint level, out NSError error);
    }

    // @interface SMProxiPRNTManager : NSObject <CBCentralManagerDelegate>
    [BaseType(typeof(NSObject))]
    interface SMProxiPRNTManager : ICBCentralManagerDelegate
    {
        [Wrap("WeakDelegate")]
        SMProxiPRNTManagerDelegate Delegate { get; set; }

        // @property (retain, nonatomic) id<SMProxiPRNTManagerDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Retain)]
        NSObject WeakDelegate { get; set; }

        // @property (getter = getSettings, readwrite, retain, setter = setSettings:) NSDictionary * settings;
        [Export("settings", ArgumentSemantic.Retain)]
        NSDictionary Settings { [Bind("getSettings")] get; [Bind("setSettings:")] set; }

        // @property (readonly, getter = retain, retain) SMProxiPRNTManager * sharedManager;
        [Export("sharedManager", ArgumentSemantic.Retain)]
        SMProxiPRNTManager SharedManager { [Bind("retain")] get; }

        // +(SMProxiPRNTManager *)sharedManager;
        //[Static]
        //[Export("sharedManager")]
        //SMProxiPRNTManager SharedManager();

        // -(BOOL)startScan;
        [Export("startScan")]
        bool StartScan();

        // -(BOOL)startScan:(NSUInteger)samplingNumber;
        [Export("startScan:")]
        bool StartScan(nuint samplingNumber);

        // -(void)stopScan;
        [Export("stopScan")]
        void StopScan();

        // -(void)addSettingForPrinterPortName:(NSString *)portName portSettings:(NSString *)portSettings withDrawer:(BOOL)useDrawer dongleMACAddr:(NSString *)MACAddr RSSIthreshould:(NSNumber *)Threshold nickName:(NSString *)nickName;
        [Export("addSettingForPrinterPortName:portSettings:withDrawer:dongleMACAddr:RSSIthreshould:nickName:")]
        void AddSettingForPrinterPortName(string portName, string portSettings, bool useDrawer, string MACAddr, NSNumber Threshold, string nickName);

        // -(void)addSettingForDKAirCashPortName:(NSString *)portName portSettings:(NSString *)portSettings dongleMACAddr:(NSString *)MACAddr RSSIthreshould:(NSNumber *)Threshold nickName:(NSString *)nickName;
        [Export("addSettingForDKAirCashPortName:portSettings:dongleMACAddr:RSSIthreshould:nickName:")]
        void AddSettingForDKAirCashPortName(string portName, string portSettings, string MACAddr, NSNumber Threshold, string nickName);

        // -(void)removeSettingWithPortName:(NSString *)portName;
        [Export("removeSettingWithPortName:")]
        void RemoveSettingWithPortName(string portName);

        // -(NSData *)serializedSettings;
        [Export("serializedSettings")]
        NSData SerializedSettings();

        // -(BOOL)deserializeSettings:(NSData *)data;
        [Export("deserializeSettings:")]
        bool DeserializeSettings(NSData data);

        // -(int)calibrateActionArea:(NSString *)MACAddr;
        [Export("calibrateActionArea:")]
        int CalibrateActionArea(string MACAddr);

        // -(int)getRSSI:(NSString *)MACAddr;
        [Export("getRSSI:")]
        int GetRSSI(string MACAddr);
    }

    // @protocol SMProxiPRNTManagerDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface SMProxiPRNTManagerDelegate
    {
        // @optional -(void)didDiscoverPort:(NSString *)portName deviceType:(SMDeviceType)deviceType MACAddr:(NSString *)MACAddr RSSI:(NSNumber *)RSSI;
        [Export("didDiscoverPort:deviceType:MACAddr:RSSI:")]
        void DidDiscoverPort(string portName, SMDeviceType deviceType, string MACAddr, NSNumber RSSI);

        // @optional -(void)didUpdateState:(NSString *)portName MACAddr:(NSString *)MACAddr;
        [Export("didUpdateState:MACAddr:")]
        void DidUpdateState(string portName, string MACAddr);
    }

    // @interface USBPort : ExternalAccessoryPort
    [BaseType(typeof(ExternalAccessoryPort))]
    interface USBPort
    {
    }






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

}
