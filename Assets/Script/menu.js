var isQuit=false;

function OnMouseEnter(){
	GetComponent.<Renderer>().material.color=Color.red;
}

function OnMouseExit(){
	GetComponent.<Renderer>().material.color=Color.white;
}

function OnMouseUp(){
	if(isQuit==true)
	{
		Application.Quit();
	}
	else{
	Application.LoadLevel(1);
	}
}

function Update()
{
	if(Input.GetKey(KeyCode.Escape))
	{
		Application.Quit();
	}
}
	