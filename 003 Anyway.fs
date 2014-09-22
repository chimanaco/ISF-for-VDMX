/*{
	"DESCRIPTION": "3/30 Anyway",
	"CREDIT": "by chimanaco",
	"CATEGORIES": [
		"Generators"
	],
	"INPUTS": [
		{
			"NAME": "x",
			"TYPE": "float",
			"DEFAULT": 1.0,
			"MIN": -10.0,
			"MAX": 10.0
		},
		{
			"NAME": "y",
			"TYPE": "float",
			"DEFAULT": 1.0,
			"MIN": -10.0,
			"MAX": 10.0
		},
		{
			"NAME": "number",
			"TYPE": "float",
			"DEFAULT": 10.0,
			"MIN": 0.0,
			"MAX": 20.0
		},
		{
			"NAME": "speed",
			"TYPE": "float",
			"DEFAULT": 1.0,
			"MIN": 1.0,
			"MAX": 20.0
		},
		{
			"NAME": "frontColor",
			"TYPE": "color",
			"DEFAULT": [
				1.0,
				1.0,
				1.0,
				1.0
			]
		}
		
	]
}*/

/*

Use with RandomOnPulse Plugin where each boolean in button should be linked with Measure Position.

*/


vec4 colorMin(vec4 color1, vec4 color2) {
	vec4 newColor = vec4(min(color1.x,color2.x),min(color1.y,color2.y),min(color1.z,color2.z),color1.a);
	return newColor;
}

void main() {
	// position
	vec2 p = vv_FragNormCoord;
	p = p - 0.5;

	// color
	float c = sin(distance(p.x * x, p.y * y) * - number + TIME * speed);
	
	gl_FragColor = colorMin( frontColor, vec4(c) );
}
