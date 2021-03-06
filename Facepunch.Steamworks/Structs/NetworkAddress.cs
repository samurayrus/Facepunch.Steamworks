﻿using System.Runtime.InteropServices;

namespace Steamworks.Data
{
	[StructLayout( LayoutKind.Explicit, Size = 18, Pack = 1 )]
	public struct NetworkAddress
	{
		[FieldOffset( 0 )]
		internal IPV4 ip;

		[FieldOffset( 16 )]
		internal ushort port;

		internal struct IPV4
		{
			internal ulong m_8zeros;
			internal ushort m_0000;
			internal ushort m_ffff;
			internal byte ip0;
			internal byte ip1;
			internal byte ip2;
			internal byte ip3;
		}

		/// <summary>
		/// Any IP, specific port
		/// </summary>
		public static NetworkAddress AnyIp( ushort port )
		{
			return new NetworkAddress
			{
				ip = new IPV4
				{
					m_8zeros = 0,
					m_0000 = 0,
					m_ffff = 0,
					ip0 = 0,
					ip1 = 0,
					ip2 = 0,
					ip3 = 1,
				},

				port = port
			};
		}
	}
}