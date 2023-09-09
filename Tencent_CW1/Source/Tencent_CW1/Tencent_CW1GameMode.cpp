// Copyright Epic Games, Inc. All Rights Reserved.

#include "Tencent_CW1GameMode.h"
#include "Tencent_CW1Ball.h"

ATencent_CW1GameMode::ATencent_CW1GameMode()
{
	// set default pawn class to our ball
	DefaultPawnClass = ATencent_CW1Ball::StaticClass();
}
