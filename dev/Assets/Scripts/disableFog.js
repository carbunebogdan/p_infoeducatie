private var revertFogState = false;
 
function OnPreRender () {
	revertFogState = RenderSettings.fog;
	RenderSettings.fog = false;
}
 
function OnPostRender () {
	RenderSettings.fog = revertFogState;
}
 
@script AddComponentMenu ("Rendering/Fog Layer")
@script RequireComponent (Camera)