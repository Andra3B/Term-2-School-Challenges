using System;
using System.Collections.Generic;

public static class Utilities
{
	public static void Error(string message)
	{
		Console.ForegroundColor = ConsoleColor.Red;
		Console.WriteLine("\n\t{0}\n", message);
		Console.ForegroundColor = ConsoleColor.White;
	}

	public static Dictionary<string, T> GetInputs<T>(string prompt,params string[] keys) where T : IConvertible
	{
		var inputTypeCode = typeof(T);
		Dictionary<string, T> result = new Dictionary<string, T>();
		result.EnsureCapacity(keys.Length);

		for (uint i = 0; i < keys.Length; i++)
		{
			string key = keys[i];
			if (string.IsNullOrWhiteSpace(key))
				continue;

			T element;
			while (true)
			{
				try
				{
					Console.Write(prompt);
					element = (T)Convert.ChangeType(Console.ReadLine(), inputTypeCode);
				}
				catch (OverflowException)
                { Error("Invalid " + key.Substring(0, 1).ToUpper() + key.Substring(1, key.Length - 1) + "!"); continue; }
				catch (FormatException)
				{ Error("Invalid " + key.Substring(0, 1).ToUpper() + key.Substring(1, key.Length - 1) + "!"); continue; }
				catch (Exception) 
				{ element = default; }

				result.Add(key, element);
				break;
			}
		}

		return result;
	}

	public static Dictionary<string, T> GetInputs<T>(params (string prompt, string key)[] inputs) where T : IConvertible
	{
		Dictionary<string, T> result = new Dictionary<string, T>();
		result.EnsureCapacity(inputs.Length);

		for (int i = 0; i < inputs.Length; i++) 
		{ result.Add(inputs[i].key, GetInputs<T>(inputs[i].prompt, inputs[i].key)[inputs[i].key]); }

		return result;
	}

	public static Dictionary<string, T> GetInputs<T>(string prompt, uint length) where T : IConvertible
	{
		string[] inputs = new string[length];

		for (uint i = 0; i < inputs.Length; i++) 
		{ inputs[i] = i.ToString(); }

		return GetInputs<T>(prompt, inputs);
	}
}