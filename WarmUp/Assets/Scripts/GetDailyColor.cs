using UnityEngine;
using System;
using System.Collections;

public class GetDailyColor : GetColor {

	public void Start(){

		int dayOfYear = DateTime.Now.DayOfYear;

		UnityEngine.Random.InitState(dayOfYear);
	}

}
