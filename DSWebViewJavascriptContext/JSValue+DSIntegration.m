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

#pragma mark void functions

-(void)setBlock:(void (^)())block forKey:(NSString *)key
{
    self[key] = ^{
        
        block();
        
    };
    
}

-(void)setBlockWith1Param:(void (^)(id par1))block forKey:(NSString *)key
{
    self[key] = ^(id par1) {
        
        block(par1);
    };
}

-(void)setBlockWith2Param:(void (^)(id par1, id par2))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2) {
        
        block(par1,par2);
    };
}

-(void)setBlockWith3Param:(void (^)(id par1, id par2, id par3))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3) {
        
        block(par1,par2,par3);
    };
}

-(void)setBlockWith4Param:(void (^)(id par1, id par2, id par3, id par4))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4) {
        
        block(par1,par2,par3, par4);
    };
}

-(void)setBlockWith5Param:(void (^)(id par1, id par2, id par3, id par4, id par5))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4,id par5) {
        
        block(par1,par2,par3, par4,par5);
    };
}

-(void)setBlockWith6Param:(void (^)(id par1, id par2, id par3, id par4, id par5,id par6))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4,id par5,id par6) {
        
        block(par1,par2,par3, par4,par5,par6);
    };
}



#pragma mark Number functions
-(void)setNumberBlock:(NSNumber*(^)())block forKey:(NSString *)key
{
    self[key] = ^{
        
        return block();
        
    };
}

-(void)setNumberBlockWith1Param:(NSNumber*(^)(id param1))block forKey:(NSString *)key
{
    self[key] = ^(id x) {
        
        return block(x);
    };
}

-(void)setNumberBlockWith2Param:(NSNumber*(^)(id par1, id par2))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2) {
        
        return block(par1,par2);
    };
}

-(void)setNumberBlockWith3Param:(NSNumber*(^)(id par1, id par2, id par3))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3) {
        
        return block(par1,par2,par3);
    };
}

-(void)setNumberBlockWith4Param:(NSNumber*(^)(id par1, id par2, id par3, id par4))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4) {
        
        return block(par1,par2,par3, par4);
    };
}

-(void)setNumberBlockWith5Param:(NSNumber*(^)(id par1, id par2, id par3, id par4, id par5))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4,id par5) {
        
        return block(par1,par2,par3, par4,par5);
    };
}

-(void)setNumberBlockWith6Param:(NSNumber*(^)(id par1, id par2, id par3, id par4, id par5,id par6))block forKey:(NSString *)key
{
    self[key] = ^(id par1,id par2,id par3,id par4,id par5,id par6) {
        
        block(par1,par2,par3, par4,par5,par6);
    };
}

@end
