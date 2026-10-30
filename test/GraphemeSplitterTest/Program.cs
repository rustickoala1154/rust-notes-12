// Copyright (C) Tom <17379620>. All Rights Reserved.
// AntdUI WinForm Library | Licensed under Apache-2.0 License
// Gitee: https://gitee.com/AntdUI/AntdUI
// GitHub: https://github.com/AntdUI/AntdUI
// GitCode: https://gitcode.com/AntdUI/AntdUI

using AntdUI;

namespace GraphemeSplitterTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            SvgDb.Emoji = FluentFlat.Emoji;

            Test("🧑🏿‍🎨⚓");
            TestEmoji("🧑🏿‍🦽", "🧑‍🦽", "🧑🏻‍🦽", "🧑🏽‍🦽", "🧑🏾‍🦽", "🧑🏼‍🦽", "🧑🏿‍🦽‍➡️", "🧑‍🦽‍➡️", "🧑🏻‍🦽‍➡️", "🧑🏽‍🦽‍➡️", "🧑🏾‍🦽‍➡️", "🧑🏼‍🦽‍➡️", "🧑🏿‍🦼", "🧑‍🦼", "🧑🏻‍🦼", "🧑🏽‍🦼", "🧑🏾‍🦼", "🧑🏼‍🦼", "🧑🏿‍🦼‍➡️", "🧑‍🦼‍➡️", "🧑🏻‍🦼‍➡️", "🧑🏽‍🦼‍➡️", "🧑🏾‍🦼‍➡️", "🧑🏼‍🦼‍➡️");

            var emojis = new List<string>(SvgDb.Emoji.Count);
            foreach (var it in SvgDb.Emoji) emojis.Add(it.Key);
            Console.WriteLine("一共 " + SvgDb.Emoji.Count + " 个Emoji");
            TestEmoji(emojis);

            Console.WriteLine("\n测试完成，按任意键退出...");
            Console.ReadKey();
        }
        static void Test(string testString)
        {
            Console.WriteLine($"测试字符串: {testString}");
            Console.WriteLine($"字符串长度: {testString.Length}");
            Console.WriteLine($"Grapheme count: {GraphemeSplitter.EachCount(testString)}");

            Console.WriteLine("\n分割结果:");
            int index = 0;
            GraphemeSplitter.Each(testString, (str, start, length, type) =>
            {
                string substring = str.Substring(start, length);
                Console.WriteLine($"{index++}: '{substring}' (长度: {length})");
            });
            Console.WriteLine("\n测试完成");
        }

        static void TestEmoji(List<string> emoji)
        {
            var testString = string.Join("", emoji);
            Console.WriteLine($"测试字符串: {testString}");
            Console.WriteLine($"字符串长度: {testString.Length}");
            Console.WriteLine($"Emoji数量: {emoji.Count}");
            Console.WriteLine($"Grapheme count: {GraphemeSplitter.EachCount(testString)}");

            Console.WriteLine("\n分割结果:");
            int index = 0;
            GraphemeSplitter.Each(testString, (str, start, length, type) =>
            {
                string substring = str.Substring(start, length);
                var ok = SvgDb.Emoji.ContainsKey(substring);
                Console.WriteLine($"{(ok ? "✅" : "❌")} {index++}: '{substring}' (长度: {length})");
                if (!ok)
                { }
            });
            Console.WriteLine("\n测试完成");
        }
        static void TestEmoji(params string[] emoji)
        {
            var testString = string.Join("", emoji);
            Console.WriteLine($"测试字符串: {testString}");
            Console.WriteLine($"字符串长度: {testString.Length}");
            Console.WriteLine($"Emoji数量: {emoji.Length}");
            Console.WriteLine($"Grapheme count: {GraphemeSplitter.EachCount(testString)}");

            Console.WriteLine("\n分割结果:");
            int index = 0;
            GraphemeSplitter.Each(testString, (str, start, length, type) =>
            {
                string substring = str.Substring(start, length);
                var ok = SvgDb.Emoji.ContainsKey(substring);
                Console.WriteLine($"{(ok ? "✅" : "❌")} {index++}: '{substring}' (长度: {length})");
            });
            Console.WriteLine("\n测试完成");
        }
    }
}

// f82f7f

// 74e5eb
