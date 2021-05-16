// Copyright Epic Games, Inc. All Rights Reserved.

#include "Lyra_LibraeGameMode.h"
#include "Lyra_LibraePawn.h"

ALyra_LibraeGameMode::ALyra_LibraeGameMode()
{
	// set default pawn class to our flying pawn
	DefaultPawnClass = ALyra_LibraePawn::StaticClass();
}
