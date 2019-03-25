// MIT License

// Portions copyright(c) 2017 Muhammad Rehan Saeed

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ActivityStreams.Primitives
{
	/// <summary>
	/// A single string or dictionary of string, string.
	/// </summary>
	/// <seealso cref="IDictionary{string, string}" />
	public class StringMap: IDictionary<string, string>, IValue
	{
		private readonly string item;
		private readonly IDictionary<string, string> dictionary;

		public StringMap(string value)
		{
			item = value;
			dictionary = null;
		}

		public StringMap(Dictionary<string, string> values)
		{
			if (values == null)
			{
				throw new ArgumentNullException(nameof(values));
			}

			if (values.Count == 1)
			{
				dictionary = null;
				item = values.First().Value;
			}
			else
			{
				dictionary = values;
				item = default;
			}
		}

		/// <summary>
		/// Gets the number of elements contained in the <see cref="StringMap"/>.
		/// </summary>
		public int Count
		{
			get
			{
				if (HasOne)
				{
					return 1;
				}
				else if (HasMany)
				{
					return dictionary.Count;
				}

				return 0;
			}
		}

		/// <summary>
		/// Gets the non-null object representing the instance.
		/// </summary>
		object IValue.Value
		{
			get
			{
				if (HasOne)
				{
					return item;
				}

				return dictionary;
			}
		}

		/// <summary>
		/// Gets a value indicating whether this instance has a single item value.
		/// </summary>
		/// <value><c>true</c> if this instance has a single item value; otherwise, <c>false</c>.</value>
		public bool HasOne => item != null;

		/// <summary>
		/// Gets a value indicating whether this instance has more than one value.
		/// </summary>
		/// <value><c>true</c> if this instance has more than one value; otherwise, <c>false</c>.</value>
		public bool HasMany => dictionary != null;

		/// <summary>
		/// Performs an implicit conversion from <see cref="String"/> to <see cref="StringMap"/>.
		/// </summary>
		/// <param name="value">The string value.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator StringMap(string value) => new StringMap(value);

		/// <summary>
		/// Performs an implicit conversion from <see cref="IDictionary{string, string}"/> to <see cref="StringMap"/>.
		/// </summary>
		/// <param name="values">The dictionary of string values.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator StringMap(Dictionary<string, string> values) => new StringMap(values);

		public ICollection<string> Keys
		{
			get
			{
				return dictionary != null
					? dictionary.Keys
					: new HashSet<string>();
			}
		}

		public ICollection<string> Values
		{
			get
			{
				return dictionary != null
					? dictionary.Values
					: new HashSet<string>();
			}
		}
		
		public bool IsReadOnly => dictionary == null ? true : false;

		public string this[string key]
		{ 
			get
			{
				return dictionary[key];
			}
			set
			{
				dictionary[key] = value;
			}
		}

		public void Add(string key, string value)
		{
			dictionary.Add(key, value);
		}

		public bool ContainsKey(string key)
		{
			return dictionary.ContainsKey(key);
		}

		public bool Remove(string key)
		{
			return dictionary.Remove(key);
		}

		public bool TryGetValue(string key, out string value)
		{
			return dictionary.TryGetValue(key, out value);
		}

		public void Add(KeyValuePair<string, string> item)
		{
			dictionary.Add(item);
		}

		public void Clear()
		{
			dictionary.Clear();
		}

		public bool Contains(KeyValuePair<string, string> item)
		{
			return dictionary.Contains(item);
		}

		public void CopyTo(KeyValuePair<string, string>[] array, int arrayIndex)
		{
			dictionary.CopyTo(array, arrayIndex);
		}

		public bool Remove(KeyValuePair<string, string> item)
		{
			return dictionary.Remove(item);
		}

		public IEnumerator<KeyValuePair<string, string>> GetEnumerator()
		{
			return dictionary?.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}