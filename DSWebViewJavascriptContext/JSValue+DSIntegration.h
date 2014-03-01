//
//  JSValue+DSIntegration.h
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import <JavaScriptCore/JavaScriptCore.h>

@interface JSValue (DSIntegration)

-(void)setObject:(NSObject *)obj forKey:(NSString *)key;

@end
