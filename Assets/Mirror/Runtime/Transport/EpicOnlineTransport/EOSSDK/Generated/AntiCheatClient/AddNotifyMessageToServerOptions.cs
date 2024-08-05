// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

namespace Epic.OnlineServices.AntiCheatClient
{
	public class AddNotifyMessageToServerOptions
	{
	}

	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	internal struct AddNotifyMessageToServerOptionsInternal : ISettable, System.IDisposable
	{
		private int m_ApiVersion;

		public void Set(AddNotifyMessageToServerOptions other)
		{
			if (other != null)
			{
				m_ApiVersion = AntiCheatClientInterface.AddnotifymessagetoserverApiLatest;
			}
		}

		public void Set(object other)
		{
			Set(other as AddNotifyMessageToServerOptions);
		}

		public void Dispose()
		{
		}
	}
}