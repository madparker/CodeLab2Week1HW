using UnityEngine;
using System.Collections;

public class GetOrderedColor : GetColor {

	public int[] order;
	int index;

	public override int GetSpriteColor(){
		int result = order[index%order.Length];
		index++;
		return result;
	}
}
