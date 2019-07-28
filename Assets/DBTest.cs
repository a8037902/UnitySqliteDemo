using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBTest : MonoBehaviour {
    public DBManager dbManager;
	// Use this for initialization
	void Start () {
        dbManager.CreateTable<Test>();

        Test test = new Test();
        //test.id = 1;
        test.name = "124";
        dbManager.Insert<Test>(test);
        dbManager.Insert<Test>(test);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
