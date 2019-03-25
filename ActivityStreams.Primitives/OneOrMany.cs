// MIT License

// Copyright(c) 2017 Muhammad Rehan Saeed

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

namespace ActivityStreams.Primitives
{

	/// <summary>
	/// A single or list of values.
	/// </summary>
	/// <typeparam name="T">The type of the values.</typeparam>
	/// <seealso cref="ICollection{T}" />
	public class OneOrMany<T> : IEnumerable<T>, IValue
	{
		private readonly List<T> collection;
		private readonly T item;

		/// <summary>
		/// Initializes a new instance of the <see cref="OneOrMany{T}"/> class.
		/// </summary>
		/// <param name="item">The single item value.</param>
		public OneOrMany(T item)
		{
			if (item == null)
			{
				throw new ArgumentNullException(nameof(item));
			}

			this.collection = null;
			this.item = item;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OneOrMany{T}"/> class.
		/// </summary>
		/// <param name="collection">The collection of values.</param>
		public OneOrMany(IEnumerable<T> collection)
			: this(collection == null ? null : new List<T>(collection))
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="OneOrMany{T}"/> class.
		/// </summary>
		/// <param name="list">The list of values.</param>
		public OneOrMany(List<T> list)
		{
			if (list == null)
			{
				throw new ArgumentNullException(nameof(list));
			}

			if (list.Count == 1)
			{
				collection = null;
				item = list[0];
			}
			else
			{
				collection = list;
				item = default;
			}
		}

		/// <summary>
		/// Gets the number of elements contained in the <see cref="OneOrMany{T}"/>.
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
					return collection.Count;
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

				return collection;
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
		public bool HasMany => collection != null;

		/// <summary>
		/// Performs an implicit conversion from <typeparamref name="T"/> to <see cref="OneOrMany{T}"/>.
		/// </summary>
		/// <param name="item">The single item value.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator OneOrMany<T>(T item) => new OneOrMany<T>(item);

		/// <summary>
		/// Performs an implicit conversion from <typeparamref name="T[]"/> to <see cref="OneOrMany{T}"/>.
		/// </summary>
		/// <param name="array">The array of values.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator OneOrMany<T>(T[] array) => new OneOrMany<T>(array);

		/// <summary>
		/// Performs an implicit conversion from <see cref="List{T}"/> to <see cref="OneOrMany{T}"/>.
		/// </summary>
		/// <param name="list">The list of values.</param>
		/// <returns>The result of the conversion.</returns>
		public static implicit operator OneOrMany<T>(List<T> list) => new OneOrMany<T>(list);

		/// <summary>
		/// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
		/// </summary>
		/// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
		public IEnumerator<T> GetEnumerator() => (collection ?? new List<T>() { item }).GetEnumerator();

		/// <summary>
		/// Returns an enumerator that iterates through the <see cref="OneOrMany{T}"/>.
		/// </summary>
		/// <returns>An enumerator for the <see cref="OneOrMany{T}"/>.</returns>
		IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
	}
}