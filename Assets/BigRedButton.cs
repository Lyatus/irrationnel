using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System;

public class BigRedButton : MonoBehaviour{
	static private BigRedButton instance;
	static public BigRedButton Instance { get{ return instance;} }
	SerialPort serialPort = new SerialPort("COM3",9600);
	
	private bool pressed = false;
	public bool Pressed { get{ return pressed;} }
	
	void Start(){
		if(instance == null){
			instance = this;
			serialPort.Open();
			serialPort.ReadTimeout = 1;
		}
		else throw new Exception("WHAT THE FUCK MATE");
	}
	void OnDestroy(){
		serialPort.Close();
	}
	void Update(){
		try{
			serialPort.ReadByte();
			pressed = true;
		}
		catch(System.Exception){
			pressed = false;
		}
	}
}
