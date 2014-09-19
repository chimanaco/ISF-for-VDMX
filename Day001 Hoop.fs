/*{
	"DESCRIPTION": "a simple sine wave generator",
	"CREDIT": "by carter rosenberg",
	"CATEGORIES": [
		"Generators"
	],
	"INPUTS": [
		{
			"NAME": "cycles",
			"TYPE": "float",
			"DEFAULT": 2.0,
			"MIN": 0.0,
			"MAX": 30.0
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

void main()
{
	// frontColor
	vec4 fc = vec4(0,0,0,0);
	fc = frontColor;
	float fcx = fc.x;
	float fcy = fc.y;
	float fcz = fc.z;
	float fca = fc.a;

	// position
	vec2 p = vv_FragNormCoord;
	p = p - 0.5;
	p = mod(p * 8.0, 4.0)-2.0;
	
	// ring
	float t = sin(length(p) * 10. + cycles);

	vec3 color = vec3(t);
	float cx = color.x;
	float cy = color.y;
	float cz = color.z;

	gl_FragColor = vec4(min(fcx,cx),min(fcy,cy),min(fcz,cz),fca);
}
