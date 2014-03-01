//
//  JSContext+DSIntegration.m
//  DSWebViewJavascriptContext
//
//  Created by Dave Humphreys on 01/03/2014.
//  Copyright (c) 2014 Dave Humphreys. All rights reserved.
//

#import "JSContext+DSIntegration.h"

@implementation JSContext (DSIntegration)

-(void)setObject:(NSObject *)obj forKey:(NSString *)key
{
    self[key] = obj;
}

-(void)setBlock:(void (^)())block forKey:(NSString *)key
{
    self[key] = ^{
        
        dispatch_async( dispatch_get_main_queue(), ^{
            
            
            block();
        });
    };
    
}

-(void)setBlockWithParam1:(void (^)(NSString *param1))block forKey:(NSString *)key
{
    self[key] = ^(NSString *aParam){
        
        dispatch_async( dispatch_get_main_queue(), ^{
            
            
            block(aParam);
        });
    };
}

-(void)setNumberBlock:(NSNumber*(^)(NSNumber *param1))block forKey:(NSString *)key
{
    self[key] = ^(NSNumber *x) {
        
        return block(x);
    };
}

@end
