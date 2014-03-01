//
//  JSContext+DSIntegration.h
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import <JavaScriptCore/JavaScriptCore.h>

@interface JSContext (DSIntegration)

-(void)setObject:(NSObject *)obj forKey:(NSString *)key;

-(void)setBlock:(void (^)())block forKey:(NSString *)key;
-(void)setBlockWithParam1:(void (^)(NSString *param1))block forKey:(NSString *)key;
-(void)setNumberBlock:(NSNumber*(^)(NSNumber *param1))block forKey:(NSString *)key;

@end
