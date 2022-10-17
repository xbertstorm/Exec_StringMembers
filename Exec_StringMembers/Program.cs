using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_StringMembers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Q01();
			Q02();

			Console.Read();
		}
		/// <summary>
		/// 判斷字串是不是 http 開頭
		/// </summary>
		private static void Q01()
		{
			Console.Write("請輸入一個http開頭的字串：");
			string url = Console.ReadLine();
			bool ans = url.StartsWith("http");

			if (ans)
				Console.WriteLine("網址是正確的。");
			else
				Console.WriteLine("網址是錯誤的。");

			//TODO 判斷字串是不是 http 開頭
		}
		/// <summary>
		/// 判斷字串結尾有沒有反斜線
		/// </summary>
		/// <exception cref="NotImplementedException"></exception>
		private static void Q02()
		{
			Console.Write("請輸入一個資料夾路徑, 結尾必需是反斜線：");
			string url = Console.ReadLine();
			bool ans = url.EndsWith(@"\");

			if (ans)
				Console.WriteLine("路徑正確。");
			else
				Console.WriteLine("路徑錯誤。");

			//TODO 判斷字串結尾有沒有反斜線
		}
	}
}
