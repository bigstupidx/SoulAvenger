// Copyright (C) 2011-2012 by Tapjoy Inc.
//
// This file is part of the Tapjoy SDK.
//
// By using the Tapjoy SDK in your software, you agree to the terms of the Tapjoy SDK License Agreement.
//
// The Tapjoy SDK is bound by the Tapjoy SDK License Agreement and can be found here: https://www.tapjoy.com/sdk/license

// By default, this value is 'false' and the 'UIDevice uniqueIdentifier' method will not be compiled into your app binary.
// Setting this value to 'true' will ensure more accurate tracking for your users through Tapjoy's network.
#define TJC_UDID_OPT_IN			(false)

// By default, this value is 'true' and OpenUDID will be used to create a unique ID for this device.
// Setting this value to 'false' will prevent OpenUDID from being used.
#define TJC_OPENUDID_OPT_IN	(true)