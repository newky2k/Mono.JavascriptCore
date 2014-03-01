//
//  DSHybridDelegate.h
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <JavaScriptCore/JavaScriptCore.h>

@protocol DSHybridDelegateExport <JSExport>

-(void)hybridApiUrl:(NSString *)customUrl;

@end

@interface DSHybridDelegate : NSObject <DSHybridDelegateExport>

-(void)hybridApiUrl:(NSString *)customUrl;

@end
