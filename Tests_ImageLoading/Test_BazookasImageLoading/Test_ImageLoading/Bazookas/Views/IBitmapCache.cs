//
// IBitmapCache.cs
//
// Author:
//       Philippe Creytens <philippe@bazookas.be>
//
// Copyright (c) 2016 Philippe Creytens
using System;

namespace Bazookas.Kinepolis.BL.Interfaces
{
	public interface IBitmapCache<T>
	{
		void AddBitmapToMemoryCache(string key, T bitmap);

		T GetBitmapFromMemCache(string key);

		void RemoveBitmapFromMemCache(string key);

		void GenerateBitmap(string localLocation, string key, int width, int height, object imageView);

		void GenerateScaledAndBlurredBitmap(string localLocation, string key, int width, int height, IBitmapScaled imageView, int blurRadius);

		void CancelBitmap(string key);

		void ContinueLoading();

		void PauseLoading();
	}
}

