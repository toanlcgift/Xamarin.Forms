using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms
{
	public class ModalBehavior : BindableObject
	{
		public static readonly BindableProperty ModalProperty =
			BindableProperty.Create(nameof(Modal), typeof(bool), typeof(ModalBehavior), true);

		public static readonly BindableProperty AnimatedProperty =
			BindableProperty.Create(nameof(Animated), typeof(bool), typeof(ModalBehavior), false);

		public bool Modal
		{
			get => (bool)GetValue(ModalProperty);
			set => SetValue(ModalProperty, value);
		}

		public bool Animated
		{
			get => (bool)GetValue(AnimatedProperty);
			set => SetValue(AnimatedProperty, value);
		}
	}
}
