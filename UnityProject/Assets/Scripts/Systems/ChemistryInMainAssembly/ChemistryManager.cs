using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ScriptableObjects;
using UnityEngine;

public class ChemistryManager : MonoBehaviour
{
	private bool generatedReferences = false;
	public void Awake()
	{
		if (generatedReferences == false)
		{
			ChemistryReagentsSO.Instance.GenerateReagentReactionReferences();
			//new Task(ChemistryReagentsSO.Instance.GenerateReagentReactionReferences).Start();
			generatedReferences = true;
		}
	}


}