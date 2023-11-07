﻿using System.Runtime.InteropServices;

namespace Moth;

public static class ListExtensions
{
	public static ReadOnlySpan<T> AsReadonlySpan<T>(this List<T> list)
	{
		var span = CollectionsMarshal.AsSpan(list);
		return span[..list.Count];
	}
}