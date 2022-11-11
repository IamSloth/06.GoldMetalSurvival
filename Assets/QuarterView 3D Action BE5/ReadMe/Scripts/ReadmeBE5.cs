using System;
using UnityEngine;

namespace QuarterView_3D_Action_BE5.ReadMe.Scripts
{
	public class ReadmeBE5 : ScriptableObject {
		public Texture2D icon;
		public string title;
		public Section[] sections;
		public bool loadedLayout;
	
		[Serializable]
		public class Section {
			public string heading, text, linkText, url;
		}
	}
}
