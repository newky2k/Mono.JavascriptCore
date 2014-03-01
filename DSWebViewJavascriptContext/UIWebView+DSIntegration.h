//
//  UIWebView+DSIntegration.h
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import <UIKit/UIKit.h>
#import <JavaScriptCore/JavaScriptCore.h>

@interface UIWebView (DSIntegration)

-(JSContext *)retriveJSContext:(id)notused;

@end
