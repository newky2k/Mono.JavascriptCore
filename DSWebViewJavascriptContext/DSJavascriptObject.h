//
//  DSJavascriptObject.h
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <JavaScriptCore/JavaScriptCore.h>

@protocol DSJavascriptObjectExport <JSExport>

-(id)getProperty:(NSString *)name;
-(void)setNumberPropertyWithName:(NSString *)name number:(NSNumber *)value;;

@end

@interface DSJavascriptObject : NSObject <DSJavascriptObjectExport>

-(id)getProperty:(NSString *)name;
-(void)setNumberPropertyWithName:(NSString *)name number:(NSNumber *)value;

@end
