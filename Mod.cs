using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_RoadNameList
{
	public class JP_RoadNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Road Name List (CNL) v1.1"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、バニラの道路名を変更します"; }
		}

	}
}
