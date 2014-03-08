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

-(void)setBlockWith1Param:(void (^)(id param1))block forKey:(NSString *)key;
-(void)setBlockWith2Param:(void (^)(id par1, id par2))block forKey:(NSString *)key;
-(void)setBlockWith3Param:(void (^)(id par1, id par2, id par3))block forKey:(NSString *)key;
-(void)setBlockWith4Param:(void (^)(id par1, id par2, id par3, id par4))block forKey:(NSString *)key;
-(void)setBlockWith5Param:(void (^)(id par1, id par2, id par3, id par4, id par5))block forKey:(NSString *)key;
-(void)setBlockWith6Param:(void (^)(id par1, id par2, id par3, id par4, id par5,id par6))block forKey:(NSString *)key;

-(void)setNumberBlock:(NSNumber*(^)())block forKey:(NSString *)key;
-(void)setNumberBlockWith1Param:(NSNumber*(^)(id param1))block forKey:(NSString *)key;
-(void)setNumberBlockWith2Param:(NSNumber*(^)(id par1, id par2))block forKey:(NSString *)key;
-(void)setNumberBlockWith3Param:(NSNumber*(^)(id par1, id par2, id par3))block forKey:(NSString *)key;
-(void)setNumberBlockWith4Param:(NSNumber*(^)(id par1, id par2, id par3, id par4))block forKey:(NSString *)key;
-(void)setNumberBlockWith5Param:(NSNumber*(^)(id par1, id par2, id par3, id par4, id par5))block forKey:(NSString *)key;
-(void)setNumberBlockWith6Param:(NSNumber*(^)(id par1, id par2, id par3, id par4, id par5,id par6))block forKey:(NSString *)key;
@end
