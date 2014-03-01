//
//  JSValue+DSIntegration.m
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import "JSValue+DSIntegration.h"

@implementation JSValue (DSIntegration)

-(void)setObject:(NSObject *)obj forKey:(NSString *)key
{
    self[key] = obj;
}


@end
