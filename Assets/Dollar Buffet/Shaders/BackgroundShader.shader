Shader "Custom/BackgroundShader"
{
	//Needed for sprite renderers, currently unused
	Properties
	{
		_MainTex ("Base (RGB)", 2D) = "white" {}
	}

	SubShader
	{
		Tags{ "RenderType" = "Opaque" }
	
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag 
			#include "UnityCG.cginc"
			
			struct vertexOutput
			{
				float4 pos : SV_POSITION;
			};

			//Pass-through vertex shader
			vertexOutput vert(appdata_base v) 
			{
				vertexOutput output;
				output.pos = mul(UNITY_MATRIX_MVP, v.vertex);
				return output;
			}

			//Crazy color magic
			float4 frag(vertexOutput input) : COLOR 
			{
				//TODO : Set it as a property ?
				float speed = 0.5f;
			
				float r = sin(_Time.y * input.pos.x * input.pos.y * speed);
				float g = cos(_Time.y * input.pos.x * speed);
				float b = cos(_Time.y * input.pos.y * 10.0f * speed);
			
				//Convert values from [-1;1] to [0;1]
				r = r*0.5f + 0.5f;
				g = g*0.5f + 0.5f;
				b = b*0.5f + 0.5f;
			
				return float4(r, g, b, 1.0f);
			}
			
			ENDCG
		}
	}
	FallBack "Diffuse"
}
