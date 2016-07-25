#pragma strict
@script RequireComponent(AudioSource)
var waterLevel: float;
private var isUnderwater: boolean;
var normalColor: Color;
var underwaterColor: Color;
var splashSound: AudioClip;
private var audioSources: AudioSource[];

function Start () {
 normalColor=RenderSettings.fogColor;
 audioSources=GetComponents.<AudioSource>();
}

function Update () {
if((transform.position.y < waterLevel) != isUnderwater){
	audioSources[1].clip=splashSound;
	audioSources[1].Play();
	isUnderwater = transform.position.y < waterLevel;
	if(isUnderwater) SetUnderwater();
	if(!isUnderwater) SetNormal();

}
}

function SetNormal(){
RenderSettings.fogColor=normalColor;
RenderSettings.fogDensity=0.01f;

}

function SetUnderwater(){
RenderSettings.fogColor= underwaterColor;
RenderSettings.fogDensity = 0.5f;
}