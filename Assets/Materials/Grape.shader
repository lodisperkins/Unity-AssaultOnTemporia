// Upgrade NOTE: replaced '_Object2World' with 'unity_ObjectToWorld'

// Shader created with Shader Forge v1.38 
// Shader Forge (c) Neat Corporation / Joachim Holmer - http://www.acegikmo.com/shaderforge/
// Note: Manually altering this data may prevent you from opening it in Shader Forge
/*SF_DATA;ver:1.38;sub:START;pass:START;ps:flbk:,iptp:0,cusa:False,bamd:0,cgin:,lico:1,lgpr:1,limd:3,spmd:1,trmd:0,grmd:1,uamb:True,mssp:True,bkdf:True,hqlp:False,rprd:True,enco:False,rmgx:True,imps:True,rpth:0,vtps:0,hqsc:True,nrmq:1,nrsp:0,vomd:0,spxs:False,tesm:0,olmd:1,culm:0,bsrc:3,bdst:7,dpts:2,wrdp:False,dith:0,atcv:False,rfrpo:True,rfrpn:Refraction,coma:15,ufog:True,aust:True,igpj:True,qofs:0,qpre:3,rntp:2,fgom:False,fgoc:False,fgod:False,fgor:False,fgmd:0,fgcr:0.5,fgcg:0.5,fgcb:0.5,fgca:1,fgde:0.01,fgrn:0,fgrf:300,stcl:False,atwp:False,stva:128,stmr:255,stmw:255,stcp:6,stps:0,stfa:0,stfz:0,ofsf:0,ofsu:0,f2p0:False,fnsp:False,fnfb:False,fsmp:False;n:type:ShaderForge.SFN_Final,id:2865,x:34843,y:32839,varname:node_2865,prsc:2|diff-7122-OUT,spec-8368-OUT,gloss-852-OUT,alpha-9243-OUT,voffset-7512-OUT,tess-2643-OUT;n:type:ShaderForge.SFN_Color,id:6665,x:30443,y:31267,ptovrint:False,ptlb:ColorB,ptin:_ColorB,varname:_Color,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.2532205,c2:0.01561943,c3:0.3679245,c4:1;n:type:ShaderForge.SFN_Color,id:325,x:30443,y:31086,ptovrint:False,ptlb:ColorA,ptin:_ColorA,varname:node_325,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,c1:0.4947236,c2:0.1744393,c3:0.754717,c4:1;n:type:ShaderForge.SFN_Vector1,id:2145,x:30936,y:32844,varname:node_2145,prsc:2,v1:5;n:type:ShaderForge.SFN_Vector1,id:8368,x:32135,y:32390,cmnt:Metallic,varname:node_8368,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:852,x:32135,y:32471,cmnt:Roughness,varname:node_852,prsc:2,v1:0.8;n:type:ShaderForge.SFN_Divide,id:2594,x:30257,y:32047,varname:node_2594,prsc:2|A-3719-OUT,B-4228-OUT;n:type:ShaderForge.SFN_DepthBlend,id:3719,x:30052,y:31882,varname:node_3719,prsc:2|DIST-6563-OUT;n:type:ShaderForge.SFN_Dot,id:4228,x:29933,y:32242,varname:node_4228,prsc:2,dt:4|A-3543-OUT,B-9164-OUT;n:type:ShaderForge.SFN_ViewVector,id:3543,x:29673,y:32177,varname:node_3543,prsc:2;n:type:ShaderForge.SFN_NormalVector,id:9164,x:29673,y:32341,prsc:2,pt:False;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:5418,x:30662,y:32569,varname:node_5418,prsc:2|IN-4646-OUT,IMIN-7280-OUT,IMAX-5600-OUT,OMIN-8422-OUT,OMAX-6903-OUT;n:type:ShaderForge.SFN_Clamp01,id:4646,x:30517,y:32052,varname:node_4646,prsc:2|IN-2594-OUT;n:type:ShaderForge.SFN_Vector1,id:8422,x:29657,y:32527,varname:node_8422,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:6903,x:29657,y:32659,varname:node_6903,prsc:2,v1:1;n:type:ShaderForge.SFN_Slider,id:7280,x:30372,y:32302,ptovrint:False,ptlb:FoamMin,ptin:_FoamMin,varname:node_7280,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.4,max:1;n:type:ShaderForge.SFN_Slider,id:5600,x:30372,y:32406,ptovrint:False,ptlb:FoamMax,ptin:_FoamMax,varname:node_5600,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.6,max:1;n:type:ShaderForge.SFN_RemapRangeAdvanced,id:6720,x:31216,y:32141,varname:node_6720,prsc:2|IN-4646-OUT,IMIN-178-OUT,IMAX-5867-OUT,OMIN-7471-OUT,OMAX-9165-OUT;n:type:ShaderForge.SFN_Slider,id:178,x:30751,y:32187,ptovrint:False,ptlb:DepthMin,ptin:_DepthMin,varname:node_178,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0,max:1;n:type:ShaderForge.SFN_Slider,id:5867,x:30751,y:32273,ptovrint:False,ptlb:DepthMax,ptin:_DepthMax,varname:node_5867,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:1;n:type:ShaderForge.SFN_Vector1,id:7471,x:30862,y:32343,varname:node_7471,prsc:2,v1:0;n:type:ShaderForge.SFN_Vector1,id:9165,x:30861,y:32417,varname:node_9165,prsc:2,v1:1;n:type:ShaderForge.SFN_ComponentMask,id:623,x:31789,y:32957,varname:node_623,prsc:2,cc1:0,cc2:-1,cc3:-1,cc4:-1|IN-1007-OUT;n:type:ShaderForge.SFN_Vector1,id:6752,x:31832,y:33236,varname:node_6752,prsc:2,v1:1;n:type:ShaderForge.SFN_Clamp01,id:9243,x:32458,y:33096,varname:node_9243,prsc:2|IN-6348-OUT;n:type:ShaderForge.SFN_Clamp01,id:1007,x:31624,y:32579,varname:node_1007,prsc:2|IN-8138-OUT;n:type:ShaderForge.SFN_Add,id:4501,x:31851,y:31779,varname:node_4501,prsc:2|A-2670-OUT,B-1007-OUT;n:type:ShaderForge.SFN_Clamp01,id:7122,x:32033,y:31779,varname:node_7122,prsc:2|IN-4501-OUT;n:type:ShaderForge.SFN_Multiply,id:1190,x:32018,y:33096,varname:node_1190,prsc:2|A-623-OUT,B-6752-OUT;n:type:ShaderForge.SFN_Add,id:6348,x:32251,y:33096,varname:node_6348,prsc:2|A-1190-OUT,B-6720-OUT;n:type:ShaderForge.SFN_OneMinus,id:2360,x:31045,y:32577,varname:node_2360,prsc:2|IN-9081-OUT;n:type:ShaderForge.SFN_Clamp01,id:9081,x:30849,y:32561,varname:node_9081,prsc:2|IN-5418-OUT;n:type:ShaderForge.SFN_Tex2d,id:8038,x:30437,y:31544,ptovrint:False,ptlb:FoamTexture,ptin:_FoamTexture,varname:node_8038,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f1d5f351035876445987cf4224c812ca,ntxv:0,isnm:False|UVIN-2599-UVOUT;n:type:ShaderForge.SFN_Lerp,id:2670,x:30802,y:31247,varname:node_2670,prsc:2|A-325-RGB,B-6665-RGB,T-4646-OUT;n:type:ShaderForge.SFN_Multiply,id:830,x:31007,y:31383,varname:node_830,prsc:2|A-2670-OUT,B-8038-RGB;n:type:ShaderForge.SFN_Multiply,id:6800,x:31233,y:31480,varname:node_6800,prsc:2|A-830-OUT,B-2360-OUT;n:type:ShaderForge.SFN_Multiply,id:3099,x:31422,y:31607,varname:node_3099,prsc:2|A-6800-OUT,B-9876-OUT;n:type:ShaderForge.SFN_Power,id:9565,x:31235,y:32577,varname:node_9565,prsc:2|VAL-2360-OUT,EXP-2145-OUT;n:type:ShaderForge.SFN_Add,id:8138,x:31441,y:32557,varname:node_8138,prsc:2|A-3099-OUT,B-9565-OUT;n:type:ShaderForge.SFN_TexCoord,id:6298,x:29469,y:31521,varname:node_6298,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_Panner,id:2599,x:29969,y:31530,varname:node_2599,prsc:2,spu:0.07,spv:0.07|UVIN-6298-UVOUT;n:type:ShaderForge.SFN_Slider,id:2643,x:32302,y:33308,ptovrint:False,ptlb:Tessellation,ptin:_Tessellation,varname:node_2643,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;n:type:ShaderForge.SFN_Tex2d,id:4024,x:32357,y:33537,ptovrint:False,ptlb:WaveDistortion,ptin:_WaveDistortion,varname:node_4024,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,tex:f1d5f351035876445987cf4224c812ca,ntxv:0,isnm:False|UVIN-5555-UVOUT;n:type:ShaderForge.SFN_Panner,id:5555,x:32076,y:33547,varname:node_5555,prsc:2,spu:1,spv:1|UVIN-5175-UVOUT,DIST-5287-OUT;n:type:ShaderForge.SFN_TexCoord,id:5175,x:31759,y:33440,varname:node_5175,prsc:2,uv:0,uaff:False;n:type:ShaderForge.SFN_FragmentPosition,id:8519,x:31746,y:33893,varname:node_8519,prsc:2;n:type:ShaderForge.SFN_Add,id:1625,x:31988,y:33913,varname:node_1625,prsc:2|A-8519-X,B-5287-OUT;n:type:ShaderForge.SFN_Multiply,id:9801,x:32264,y:33913,varname:node_9801,prsc:2|A-1625-OUT,B-1472-OUT;n:type:ShaderForge.SFN_Sin,id:4703,x:32496,y:33913,varname:node_4703,prsc:2|IN-9801-OUT;n:type:ShaderForge.SFN_Multiply,id:8760,x:32695,y:33913,varname:node_8760,prsc:2|A-4703-OUT,B-5994-OUT;n:type:ShaderForge.SFN_Add,id:6655,x:32952,y:33917,varname:node_6655,prsc:2|A-8760-OUT,B-6052-OUT;n:type:ShaderForge.SFN_RemapRange,id:6080,x:33207,y:33896,varname:node_6080,prsc:2,frmn:-1,frmx:1,tomn:0,tomx:1|IN-6655-OUT;n:type:ShaderForge.SFN_Multiply,id:3489,x:33474,y:33611,varname:node_3489,prsc:2|A-4024-R,B-6080-OUT;n:type:ShaderForge.SFN_Slider,id:2980,x:32995,y:34260,ptovrint:False,ptlb:WaveHeight,ptin:_WaveHeight,varname:node_2980,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.07,max:10;n:type:ShaderForge.SFN_Multiply,id:2319,x:33983,y:34082,varname:node_2319,prsc:2|A-3489-OUT,B-2980-OUT;n:type:ShaderForge.SFN_Append,id:1635,x:34254,y:33955,varname:node_1635,prsc:2|A-3292-OUT,B-2319-OUT;n:type:ShaderForge.SFN_Vector1,id:3292,x:33992,y:33788,varname:node_3292,prsc:2,v1:0;n:type:ShaderForge.SFN_Append,id:7512,x:34504,y:33955,varname:node_7512,prsc:2|A-1635-OUT,B-1686-OUT;n:type:ShaderForge.SFN_Vector1,id:1686,x:34275,y:34147,varname:node_1686,prsc:2,v1:0;n:type:ShaderForge.SFN_Multiply,id:5287,x:31759,y:33644,varname:node_5287,prsc:2|A-3803-TSL,B-2425-OUT;n:type:ShaderForge.SFN_Time,id:3803,x:31418,y:33438,varname:node_3803,prsc:2;n:type:ShaderForge.SFN_Slider,id:6563,x:29625,y:31881,ptovrint:False,ptlb:Depth,ptin:_Depth,varname:node_6563,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:10,max:10;n:type:ShaderForge.SFN_Slider,id:9876,x:30892,y:31820,ptovrint:False,ptlb:FoamPower,ptin:_FoamPower,varname:node_9876,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.7,max:10;n:type:ShaderForge.SFN_Slider,id:2425,x:31261,y:33704,ptovrint:False,ptlb:WaveSpeed,ptin:_WaveSpeed,varname:node_2425,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:5,max:5;n:type:ShaderForge.SFN_Slider,id:6052,x:32623,y:34127,ptovrint:False,ptlb:WaveWidth,ptin:_WaveWidth,varname:node_6052,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:2,max:10;n:type:ShaderForge.SFN_Slider,id:5994,x:32282,y:34097,ptovrint:False,ptlb:WaveSpread,ptin:_WaveSpread,varname:node_5994,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:0.3,max:5;n:type:ShaderForge.SFN_Slider,id:1472,x:31901,y:34128,ptovrint:False,ptlb:WaveCount,ptin:_WaveCount,varname:node_1472,prsc:2,glob:False,taghide:False,taghdr:False,tagprd:False,tagnsco:False,tagnrm:False,min:0,cur:1,max:10;proporder:6665-325-7280-5600-178-5867-8038-2643-4024-2980-6563-9876-2425-5994-6052-1472;pass:END;sub:END;*/

Shader "Shader Forge/WaterShader" {
    Properties {
        _ColorB ("ColorB", Color) = (0.2532205,0.01561943,0.3679245,1)
        _ColorA ("ColorA", Color) = (0.4947236,0.1744393,0.754717,1)
        _FoamMin ("FoamMin", Range(0, 1)) = 0.4
        _FoamMax ("FoamMax", Range(0, 1)) = 0.6
        _DepthMin ("DepthMin", Range(0, 1)) = 0
        _DepthMax ("DepthMax", Range(0, 1)) = 1
        _FoamTexture ("FoamTexture", 2D) = "white" {}
        _Tessellation ("Tessellation", Range(0, 10)) = 1
        _WaveDistortion ("WaveDistortion", 2D) = "white" {}
        _WaveHeight ("WaveHeight", Range(0, 10)) = 0.07
        _Depth ("Depth", Range(0, 10)) = 10
        _FoamPower ("FoamPower", Range(0, 10)) = 0.7
        _WaveSpeed ("WaveSpeed", Range(0, 5)) = 5
        _WaveSpread ("WaveSpread", Range(0, 5)) = 0.3
        _WaveWidth ("WaveWidth", Range(0, 10)) = 2
        _WaveCount ("WaveCount", Range(0, 10)) = 1
        [HideInInspector]_Cutoff ("Alpha cutoff", Range(0,1)) = 0.5
    }
    SubShader {
        Tags {
            "IgnoreProjector"="True"
            "Queue"="Transparent"
            "RenderType"="Transparent"
        }
        Pass {
            Name "FORWARD"
            Tags {
                "LightMode"="ForwardBase"
            }
            Blend SrcAlpha OneMinusSrcAlpha
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDBASE
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdbase
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform float _DepthMin;
            uniform float _DepthMax;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform float _Tessellation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveHeight;
            uniform float _Depth;
            uniform float _FoamPower;
            uniform float _WaveSpeed;
            uniform float _WaveWidth;
            uniform float _WaveSpread;
            uniform float _WaveCount;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                UNITY_FOG_COORDS(8)
                #if defined(LIGHTMAP_ON) || defined(UNITY_SHOULD_SAMPLE_SH)
                    float4 ambientOrLightmapUV : TEXCOORD9;
                #endif
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                #ifdef LIGHTMAP_ON
                    o.ambientOrLightmapUV.xy = v.texcoord1.xy * unity_LightmapST.xy + unity_LightmapST.zw;
                    o.ambientOrLightmapUV.zw = 0;
                #elif UNITY_SHOULD_SAMPLE_SH
                #endif
                #ifdef DYNAMICLIGHTMAP_ON
                    o.ambientOrLightmapUV.zw = v.texcoord2.xy * unity_DynamicLightmapST.xy + unity_DynamicLightmapST.zw;
                #endif
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_3803 = _Time;
                float node_5287 = (node_3803.r*_WaveSpeed);
                float2 node_5555 = (o.uv0+node_5287*float2(1,1));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_5555, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_5287)*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float3 viewReflectDirection = reflect( -viewDirection, normalDirection );
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(_WorldSpaceLightPos0.xyz);
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = 1;
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - 0.8; // Convert roughness to gloss
                float perceptualRoughness = 0.8;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
/////// GI Data:
                UnityLight light;
                #ifdef LIGHTMAP_OFF
                    light.color = lightColor;
                    light.dir = lightDirection;
                    light.ndotl = LambertTerm (normalDirection, light.dir);
                #else
                    light.color = half3(0.f, 0.f, 0.f);
                    light.ndotl = 0.0f;
                    light.dir = half3(0.f, 0.f, 0.f);
                #endif
                UnityGIInput d;
                d.light = light;
                d.worldPos = i.posWorld.xyz;
                d.worldViewDir = viewDirection;
                d.atten = attenuation;
                #if defined(LIGHTMAP_ON) || defined(DYNAMICLIGHTMAP_ON)
                    d.ambient = 0;
                    d.lightmapUV = i.ambientOrLightmapUV;
                #else
                    d.ambient = i.ambientOrLightmapUV;
                #endif
                #if UNITY_SPECCUBE_BLENDING || UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMin[0] = unity_SpecCube0_BoxMin;
                    d.boxMin[1] = unity_SpecCube1_BoxMin;
                #endif
                #if UNITY_SPECCUBE_BOX_PROJECTION
                    d.boxMax[0] = unity_SpecCube0_BoxMax;
                    d.boxMax[1] = unity_SpecCube1_BoxMax;
                    d.probePosition[0] = unity_SpecCube0_ProbePosition;
                    d.probePosition[1] = unity_SpecCube1_ProbePosition;
                #endif
                d.probeHDR[0] = unity_SpecCube0_HDR;
                d.probeHDR[1] = unity_SpecCube1_HDR;
                Unity_GlossyEnvironmentData ugls_en_data;
                ugls_en_data.roughness = 1.0 - gloss;
                ugls_en_data.reflUVW = viewReflectDirection;
                UnityGI gi = UnityGlobalIllumination(d, 1, normalDirection, ugls_en_data );
                lightDirection = gi.light.dir;
                lightColor = gi.light.color;
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_4646 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_2670 = lerp(_ColorA.rgb,_ColorB.rgb,node_4646);
                float4 node_5289 = _Time;
                float2 node_2599 = (i.uv0+node_5289.g*float2(0.07,0.07));
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_2599, _FoamTexture));
                float node_8422 = 0.0;
                float node_2360 = (1.0 - saturate((node_8422 + ( (node_4646 - _FoamMin) * (1.0 - node_8422) ) / (_FoamMax - _FoamMin))));
                float3 node_1007 = saturate(((((node_2670*_FoamTexture_var.rgb)*node_2360)*_FoamPower)+pow(node_2360,5.0)));
                float3 diffuseColor = saturate((node_2670+node_1007)); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                half surfaceReduction;
                #ifdef UNITY_COLORSPACE_GAMMA
                    surfaceReduction = 1.0-0.28*roughness*perceptualRoughness;
                #else
                    surfaceReduction = 1.0/(roughness*roughness + 1.0);
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                half grazingTerm = saturate( gloss + specularMonochrome );
                float3 indirectSpecular = (gi.indirect.specular);
                indirectSpecular *= FresnelLerp (specularColor, grazingTerm, NdotV);
                indirectSpecular *= surfaceReduction;
                float3 specular = (directSpecular + indirectSpecular);
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 indirectDiffuse = float3(0,0,0);
                indirectDiffuse += gi.indirect.diffuse;
                float3 diffuse = (directDiffuse + indirectDiffuse) * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_7471 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor,saturate(((node_1007.r*1.0)+(node_7471 + ( (node_4646 - _DepthMin) * (1.0 - node_7471) ) / (_DepthMax - _DepthMin)))));
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "FORWARD_DELTA"
            Tags {
                "LightMode"="ForwardAdd"
            }
            Blend One One
            ZWrite Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_FORWARDADD
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "AutoLight.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma multi_compile_fwdadd
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform float _DepthMin;
            uniform float _DepthMax;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform float _Tessellation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveHeight;
            uniform float _Depth;
            uniform float _FoamPower;
            uniform float _WaveSpeed;
            uniform float _WaveWidth;
            uniform float _WaveSpread;
            uniform float _WaveCount;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float3 tangentDir : TEXCOORD5;
                float3 bitangentDir : TEXCOORD6;
                float4 projPos : TEXCOORD7;
                LIGHTING_COORDS(8,9)
                UNITY_FOG_COORDS(10)
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                o.tangentDir = normalize( mul( unity_ObjectToWorld, float4( v.tangent.xyz, 0.0 ) ).xyz );
                o.bitangentDir = normalize(cross(o.normalDir, o.tangentDir) * v.tangent.w);
                float4 node_3803 = _Time;
                float node_5287 = (node_3803.r*_WaveSpeed);
                float2 node_5555 = (o.uv0+node_5287*float2(1,1));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_5555, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_5287)*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                float3 lightColor = _LightColor0.rgb;
                o.pos = UnityObjectToClipPos( v.vertex );
                UNITY_TRANSFER_FOG(o,o.pos);
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                TRANSFER_VERTEX_TO_FRAGMENT(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                i.normalDir = normalize(i.normalDir);
                float3x3 tangentTransform = float3x3( i.tangentDir, i.bitangentDir, i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                float3 lightDirection = normalize(lerp(_WorldSpaceLightPos0.xyz, _WorldSpaceLightPos0.xyz - i.posWorld.xyz,_WorldSpaceLightPos0.w));
                float3 lightColor = _LightColor0.rgb;
                float3 halfDirection = normalize(viewDirection+lightDirection);
////// Lighting:
                float attenuation = LIGHT_ATTENUATION(i);
                float3 attenColor = attenuation * _LightColor0.xyz;
                float Pi = 3.141592654;
                float InvPi = 0.31830988618;
///////// Gloss:
                float gloss = 1.0 - 0.8; // Convert roughness to gloss
                float perceptualRoughness = 0.8;
                float roughness = perceptualRoughness * perceptualRoughness;
                float specPow = exp2( gloss * 10.0 + 1.0 );
////// Specular:
                float NdotL = saturate(dot( normalDirection, lightDirection ));
                float LdotH = saturate(dot(lightDirection, halfDirection));
                float3 specularColor = 0.0;
                float specularMonochrome;
                float node_4646 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_2670 = lerp(_ColorA.rgb,_ColorB.rgb,node_4646);
                float4 node_2509 = _Time;
                float2 node_2599 = (i.uv0+node_2509.g*float2(0.07,0.07));
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_2599, _FoamTexture));
                float node_8422 = 0.0;
                float node_2360 = (1.0 - saturate((node_8422 + ( (node_4646 - _FoamMin) * (1.0 - node_8422) ) / (_FoamMax - _FoamMin))));
                float3 node_1007 = saturate(((((node_2670*_FoamTexture_var.rgb)*node_2360)*_FoamPower)+pow(node_2360,5.0)));
                float3 diffuseColor = saturate((node_2670+node_1007)); // Need this for specular when using metallic
                diffuseColor = DiffuseAndSpecularFromMetallic( diffuseColor, specularColor, specularColor, specularMonochrome );
                specularMonochrome = 1.0-specularMonochrome;
                float NdotV = abs(dot( normalDirection, viewDirection ));
                float NdotH = saturate(dot( normalDirection, halfDirection ));
                float VdotH = saturate(dot( viewDirection, halfDirection ));
                float visTerm = SmithJointGGXVisibilityTerm( NdotL, NdotV, roughness );
                float normTerm = GGXTerm(NdotH, roughness);
                float specularPBL = (visTerm*normTerm) * UNITY_PI;
                #ifdef UNITY_COLORSPACE_GAMMA
                    specularPBL = sqrt(max(1e-4h, specularPBL));
                #endif
                specularPBL = max(0, specularPBL * NdotL);
                #if defined(_SPECULARHIGHLIGHTS_OFF)
                    specularPBL = 0.0;
                #endif
                specularPBL *= any(specularColor) ? 1.0 : 0.0;
                float3 directSpecular = attenColor*specularPBL*FresnelTerm(specularColor, LdotH);
                float3 specular = directSpecular;
/////// Diffuse:
                NdotL = max(0.0,dot( normalDirection, lightDirection ));
                half fd90 = 0.5 + 2 * LdotH * LdotH * (1-gloss);
                float nlPow5 = Pow5(1-NdotL);
                float nvPow5 = Pow5(1-NdotV);
                float3 directDiffuse = ((1 +(fd90 - 1)*nlPow5) * (1 + (fd90 - 1)*nvPow5) * NdotL) * attenColor;
                float3 diffuse = directDiffuse * diffuseColor;
/// Final Color:
                float3 finalColor = diffuse + specular;
                float node_7471 = 0.0;
                fixed4 finalRGBA = fixed4(finalColor * saturate(((node_1007.r*1.0)+(node_7471 + ( (node_4646 - _DepthMin) * (1.0 - node_7471) ) / (_DepthMax - _DepthMin)))),0);
                UNITY_APPLY_FOG(i.fogCoord, finalRGBA);
                return finalRGBA;
            }
            ENDCG
        }
        Pass {
            Name "ShadowCaster"
            Tags {
                "LightMode"="ShadowCaster"
            }
            Offset 1, 1
            Cull Back
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_SHADOWCASTER
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform float _Tessellation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveHeight;
            uniform float _WaveSpeed;
            uniform float _WaveWidth;
            uniform float _WaveSpread;
            uniform float _WaveCount;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                V2F_SHADOW_CASTER;
                float2 uv0 : TEXCOORD1;
                float2 uv1 : TEXCOORD2;
                float2 uv2 : TEXCOORD3;
                float4 posWorld : TEXCOORD4;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                float4 node_3803 = _Time;
                float node_5287 = (node_3803.r*_WaveSpeed);
                float2 node_5555 = (o.uv0+node_5287*float2(1,1));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_5555, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_5287)*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityObjectToClipPos( v.vertex );
                TRANSFER_SHADOW_CASTER(o)
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : COLOR {
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                SHADOW_CASTER_FRAGMENT(i)
            }
            ENDCG
        }
        Pass {
            Name "Meta"
            Tags {
                "LightMode"="Meta"
            }
            Cull Off
            
            CGPROGRAM
            #pragma hull hull
            #pragma domain domain
            #pragma vertex tessvert
            #pragma fragment frag
            #define UNITY_PASS_META 1
            #define SHOULD_SAMPLE_SH ( defined (LIGHTMAP_OFF) && defined(DYNAMICLIGHTMAP_OFF) )
            #define _GLOSSYENV 1
            #include "UnityCG.cginc"
            #include "Lighting.cginc"
            #include "Tessellation.cginc"
            #include "UnityPBSLighting.cginc"
            #include "UnityStandardBRDF.cginc"
            #include "UnityMetaPass.cginc"
            #pragma fragmentoption ARB_precision_hint_fastest
            #pragma multi_compile_shadowcaster
            #pragma multi_compile LIGHTMAP_OFF LIGHTMAP_ON
            #pragma multi_compile DIRLIGHTMAP_OFF DIRLIGHTMAP_COMBINED DIRLIGHTMAP_SEPARATE
            #pragma multi_compile DYNAMICLIGHTMAP_OFF DYNAMICLIGHTMAP_ON
            #pragma multi_compile_fog
            #pragma only_renderers d3d9 d3d11 glcore gles 
            #pragma target 5.0
            uniform sampler2D _CameraDepthTexture;
            uniform float4 _ColorB;
            uniform float4 _ColorA;
            uniform float _FoamMin;
            uniform float _FoamMax;
            uniform sampler2D _FoamTexture; uniform float4 _FoamTexture_ST;
            uniform float _Tessellation;
            uniform sampler2D _WaveDistortion; uniform float4 _WaveDistortion_ST;
            uniform float _WaveHeight;
            uniform float _Depth;
            uniform float _FoamPower;
            uniform float _WaveSpeed;
            uniform float _WaveWidth;
            uniform float _WaveSpread;
            uniform float _WaveCount;
            struct VertexInput {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
                float4 tangent : TANGENT;
                float2 texcoord0 : TEXCOORD0;
                float2 texcoord1 : TEXCOORD1;
                float2 texcoord2 : TEXCOORD2;
            };
            struct VertexOutput {
                float4 pos : SV_POSITION;
                float2 uv0 : TEXCOORD0;
                float2 uv1 : TEXCOORD1;
                float2 uv2 : TEXCOORD2;
                float4 posWorld : TEXCOORD3;
                float3 normalDir : TEXCOORD4;
                float4 projPos : TEXCOORD5;
            };
            VertexOutput vert (VertexInput v) {
                VertexOutput o = (VertexOutput)0;
                o.uv0 = v.texcoord0;
                o.uv1 = v.texcoord1;
                o.uv2 = v.texcoord2;
                o.normalDir = UnityObjectToWorldNormal(v.normal);
                float4 node_3803 = _Time;
                float node_5287 = (node_3803.r*_WaveSpeed);
                float2 node_5555 = (o.uv0+node_5287*float2(1,1));
                float4 _WaveDistortion_var = tex2Dlod(_WaveDistortion,float4(TRANSFORM_TEX(node_5555, _WaveDistortion),0.0,0));
                v.vertex.xyz += float3(float2(0.0,((_WaveDistortion_var.r*(((sin(((mul(unity_ObjectToWorld, v.vertex).r+node_5287)*_WaveCount))*_WaveSpread)+_WaveWidth)*0.5+0.5))*_WaveHeight)),0.0);
                o.posWorld = mul(unity_ObjectToWorld, v.vertex);
                o.pos = UnityMetaVertexPosition(v.vertex, v.texcoord1.xy, v.texcoord2.xy, unity_LightmapST, unity_DynamicLightmapST );
                o.projPos = ComputeScreenPos (o.pos);
                COMPUTE_EYEDEPTH(o.projPos.z);
                return o;
            }
            #ifdef UNITY_CAN_COMPILE_TESSELLATION
                struct TessVertex {
                    float4 vertex : INTERNALTESSPOS;
                    float3 normal : NORMAL;
                    float4 tangent : TANGENT;
                    float2 texcoord0 : TEXCOORD0;
                    float2 texcoord1 : TEXCOORD1;
                    float2 texcoord2 : TEXCOORD2;
                };
                struct OutputPatchConstant {
                    float edge[3]         : SV_TessFactor;
                    float inside          : SV_InsideTessFactor;
                    float3 vTangent[4]    : TANGENT;
                    float2 vUV[4]         : TEXCOORD;
                    float3 vTanUCorner[4] : TANUCORNER;
                    float3 vTanVCorner[4] : TANVCORNER;
                    float4 vCWts          : TANWEIGHTS;
                };
                TessVertex tessvert (VertexInput v) {
                    TessVertex o;
                    o.vertex = v.vertex;
                    o.normal = v.normal;
                    o.tangent = v.tangent;
                    o.texcoord0 = v.texcoord0;
                    o.texcoord1 = v.texcoord1;
                    o.texcoord2 = v.texcoord2;
                    return o;
                }
                float Tessellation(TessVertex v){
                    return _Tessellation;
                }
                float4 Tessellation(TessVertex v, TessVertex v1, TessVertex v2){
                    float tv = Tessellation(v);
                    float tv1 = Tessellation(v1);
                    float tv2 = Tessellation(v2);
                    return float4( tv1+tv2, tv2+tv, tv+tv1, tv+tv1+tv2 ) / float4(2,2,2,3);
                }
                OutputPatchConstant hullconst (InputPatch<TessVertex,3> v) {
                    OutputPatchConstant o = (OutputPatchConstant)0;
                    float4 ts = Tessellation( v[0], v[1], v[2] );
                    o.edge[0] = ts.x;
                    o.edge[1] = ts.y;
                    o.edge[2] = ts.z;
                    o.inside = ts.w;
                    return o;
                }
                [domain("tri")]
                [partitioning("fractional_odd")]
                [outputtopology("triangle_cw")]
                [patchconstantfunc("hullconst")]
                [outputcontrolpoints(3)]
                TessVertex hull (InputPatch<TessVertex,3> v, uint id : SV_OutputControlPointID) {
                    return v[id];
                }
                [domain("tri")]
                VertexOutput domain (OutputPatchConstant tessFactors, const OutputPatch<TessVertex,3> vi, float3 bary : SV_DomainLocation) {
                    VertexInput v = (VertexInput)0;
                    v.vertex = vi[0].vertex*bary.x + vi[1].vertex*bary.y + vi[2].vertex*bary.z;
                    v.normal = vi[0].normal*bary.x + vi[1].normal*bary.y + vi[2].normal*bary.z;
                    v.tangent = vi[0].tangent*bary.x + vi[1].tangent*bary.y + vi[2].tangent*bary.z;
                    v.texcoord0 = vi[0].texcoord0*bary.x + vi[1].texcoord0*bary.y + vi[2].texcoord0*bary.z;
                    v.texcoord1 = vi[0].texcoord1*bary.x + vi[1].texcoord1*bary.y + vi[2].texcoord1*bary.z;
                    VertexOutput o = vert(v);
                    return o;
                }
            #endif
            float4 frag(VertexOutput i) : SV_Target {
                i.normalDir = normalize(i.normalDir);
                float3 viewDirection = normalize(_WorldSpaceCameraPos.xyz - i.posWorld.xyz);
                float3 normalDirection = i.normalDir;
                float sceneZ = max(0,LinearEyeDepth (UNITY_SAMPLE_DEPTH(tex2Dproj(_CameraDepthTexture, UNITY_PROJ_COORD(i.projPos)))) - _ProjectionParams.g);
                float partZ = max(0,i.projPos.z - _ProjectionParams.g);
                UnityMetaInput o;
                UNITY_INITIALIZE_OUTPUT( UnityMetaInput, o );
                
                o.Emission = 0;
                
                float node_4646 = saturate((saturate((sceneZ-partZ)/_Depth)/0.5*dot(viewDirection,i.normalDir)+0.5));
                float3 node_2670 = lerp(_ColorA.rgb,_ColorB.rgb,node_4646);
                float4 node_7610 = _Time;
                float2 node_2599 = (i.uv0+node_7610.g*float2(0.07,0.07));
                float4 _FoamTexture_var = tex2D(_FoamTexture,TRANSFORM_TEX(node_2599, _FoamTexture));
                float node_8422 = 0.0;
                float node_2360 = (1.0 - saturate((node_8422 + ( (node_4646 - _FoamMin) * (1.0 - node_8422) ) / (_FoamMax - _FoamMin))));
                float3 node_1007 = saturate(((((node_2670*_FoamTexture_var.rgb)*node_2360)*_FoamPower)+pow(node_2360,5.0)));
                float3 diffColor = saturate((node_2670+node_1007));
                float specularMonochrome;
                float3 specColor;
                diffColor = DiffuseAndSpecularFromMetallic( diffColor, 0.0, specColor, specularMonochrome );
                float roughness = 0.8;
                o.Albedo = diffColor + specColor * roughness * roughness * 0.5;
                
                return UnityMetaFragment( o );
            }
            ENDCG
        }
    }
    FallBack "Diffuse"
    CustomEditor "ShaderForgeMaterialInspector"
}
