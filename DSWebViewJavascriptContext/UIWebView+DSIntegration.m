//
//  UIWebView+DSIntegration.m
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import "UIWebView+DSIntegration.h"
#import "UIWebView+TS_JavaScriptContext.h"

@implementation UIWebView (DSIntegration)

-(JSContext *)retriveJSContext:(id)notused
{
    return [self ts_javaScriptContext];
}

@end
