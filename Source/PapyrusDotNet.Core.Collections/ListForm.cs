﻿/*
    This file is part of PapyrusDotNet.

    PapyrusDotNet is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    PapyrusDotNet is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with PapyrusDotNet.  If not, see <http://www.gnu.org/licenses/>.
	
	Copyright 2014, Karl Patrik Johansson, zerratar@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PapyrusDotNet.Core.Collections
{
	/// <summary>
	/// Example List<ValueType> converted class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	[GenericType]
	internal class ListForm : Form
	{
		private Form[] ArrayHolder_0 = new Form[128];
		private Form[] ArrayHolder_1 = new Form[128];
		private Form[] ArrayHolder_2 = new Form[128];
		private Form[] ArrayHolder_3 = new Form[128];
		private Form[] ArrayHolder_4 = new Form[128];
		private Form[] ArrayHolder_5 = new Form[128];
		private Form[] ArrayHolder_6 = new Form[128];
		private Form[] ArrayHolder_7 = new Form[128];
		private Form[] ArrayHolder_8 = new Form[128];
		private Form[] ArrayHolder_9 = new Form[128];

		private int ItemIndex;

		private int ItemCount;

		// Max = 1280;

		private int ArrayIndex(int bigIndex)
		{
			return bigIndex / 128;
		}

		private Form[] ArrayFromIndex(int index)
		{
			if (index == 0) return ArrayHolder_0;
			if (index == 1) return ArrayHolder_1;
			if (index == 2) return ArrayHolder_2;
			if (index == 3) return ArrayHolder_3;
			if (index == 4) return ArrayHolder_4;
			if (index == 5) return ArrayHolder_5;
			if (index == 6) return ArrayHolder_6;
			if (index == 7) return ArrayHolder_7;
			if (index == 8) return ArrayHolder_8;
			if (index == 9) return ArrayHolder_9;
			return ArrayHolder_0;
		}
		public int Count()
		{

			return ItemCount;
		}

		public int Size()
		{
			return ItemIndex;
		}

		public void Add(Form obj)
		{
			int iArray = ArrayIndex(ItemIndex);
			int offset = iArray * 128;
			int index = ItemIndex - offset;
			var array = ArrayFromIndex(iArray);
			array[index] = obj;
			ItemIndex++;
			ItemCount++;
		}

		public Form Get(int index)
		{
			int iArray = ArrayIndex(index);
			int offset = iArray * 128;
			int i = index - offset;
			var array = ArrayFromIndex(iArray);
			return array[i];
		}

		public void RemoveAt(int index)
		{
			int iArray = ArrayIndex(index);
			int offset = iArray * 128;
			int i = index - offset;
			var array = ArrayFromIndex(iArray);

			array[i] = null;

			ItemCount--;
		}

		/// <summary>
		/// Obviously you shouldnt use this function in a List<bool>.
		/// </summary>
		/// <param name="form"></param>
		public void Remove(Form form)
		{
			for (int iArray = 0; iArray < 10; iArray++)
			{
				var arrayToCheck = ArrayFromIndex(iArray);
				for (int i = 0; i < 128; i++)
				{
					int x = 0;

					if (arrayToCheck[i] != null)
					{
						var form1Id = form.GetFormID();
						var form2Id = arrayToCheck[i].GetFormID();
						if (form1Id == form2Id)
						{
							arrayToCheck[i] = null;
							ItemCount--;
							return;
						}
					}
				}
			}
		}

	}
}
