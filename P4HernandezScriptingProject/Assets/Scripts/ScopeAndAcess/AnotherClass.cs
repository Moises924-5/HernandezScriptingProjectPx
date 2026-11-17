using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass : MonoBehaviour
{

    //adding 2 public variable to the class
    public int apples = 5;
    public int bananas = 10;

    //adding 2 private variable to the class
    private int stapler;
    private int sellotape;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //creating a method that takes in 2 parameters
    public  void FruitMachine(int a,  int  b)
    {
       
        //create a local variable to the method
        int answer = a + b;
        //print  the answer to the  console
        Debug.Log("Office total is: " + answer);
    }

    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Office Supplies total: " + answer);
    }
}
