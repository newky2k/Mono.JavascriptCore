XBUILD=/Applications/Xcode.app/Contents/Developer/usr/bin/xcodebuild
#BTOUCH=/Developer/MonoTouch/usr/bin/btouch
PROJECT_ROOT=.
PROJECT=$(PROJECT_ROOT)/DSWebViewJavascriptContext.xcodeproj
TARGET=DSWebViewJavascriptContext

all: libDSWebViewJavascriptContextSDK.a

libDSWebViewJavascriptContext-i386.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphonesimulator -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphonesimulator/lib$(TARGET).a $@

libDSWebViewJavascriptContext-armv7.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDSWebViewJavascriptContext-armv7s.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch armv7s -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDSWebViewJavascriptContext-arm64.a:
	$(XBUILD) -project $(PROJECT) -target $(TARGET) -sdk iphoneos -arch arm64 -configuration Release clean build
	-mv $(PROJECT_ROOT)/build/Release-iphoneos/lib$(TARGET).a $@

libDSWebViewJavascriptContextSDK.a: libDSWebViewJavascriptContext-i386.a libDSWebViewJavascriptContext-armv7.a libDSWebViewJavascriptContext-armv7s.a libDSWebViewJavascriptContext-arm64.a
	lipo -create -output $@ $^

clean:
	-rm -f *.a *.dll