using Ormona.Planets.Scripts;
using UnityEngine;

namespace Ormona.Planets.Meshes
{
    public static class MeshDefinition
    {
        #region Planet Mesh Definition

        //1
        public static readonly Mesh RightBottomTopBackFrontQuad;

        //2
        public static readonly Mesh LeftBottomTopBackFrontQuad;

        //3
        public static readonly Mesh BottomTopBackFrontQuad;
        public static readonly Mesh BottomTopBackFrontQuad_RightPPRectangleTriangle;

        //4
        public static readonly Mesh LeftRightTopBackFrontQuad;

        //5
        public static readonly Mesh LeftTopRamp_BackMMRectangleTriangle_FrontMMRectangleTriangle;
        public static readonly Mesh DiagonalQuadRightFront_TopMMRectangleTriangle_BackQuad;

        //6
        public static readonly Mesh RightTopRamp_BackPMRectangleTriangle_FrontPMRectangleTriangle;
        public static readonly Mesh TriangleUpPM_BackPMRectangleTriangle;
        public static readonly Mesh RightTopRampWithOneVertexDown_BackPMRectangleTriangle;
        public static readonly Mesh DiagonalQuadLeftFront_TopPMRectangleTriangle_BackQuad;


        //7
        public static readonly Mesh TopBackFrontQuad;

        //8
        public static readonly Mesh LeftRightBottomBackFrontQuad;

        //9
        public static readonly Mesh RightBottomBackFrontQuad;

        //10
        public static readonly Mesh LeftBottomBackFrontQuad;

        //11
        public static readonly Mesh BottomBackFrontQuad;

        //12
        public static readonly Mesh LeftRightBackFrontQuad;

        //13
        public static readonly Mesh RightBackFrontQuad;
        public static readonly Mesh FrontRightDiagonalQuad_BackQuad;

        //14
        public static readonly Mesh LeftBackFrontQuad;
        public static readonly Mesh FrontLeftDiagonalQuad_BackQuad;

        //15
        public static readonly Mesh BackFrontQuad;

        //16
        public static readonly Mesh LeftRightBottomTopFrontQuad;

        //17
        public static readonly Mesh MMTriangleUp_BottomMMRectangleTriangle;

        //18
        public static readonly Mesh TriangleUpPM_BottomPMRectangleTriangle;

        //19
        public static readonly Mesh BottomTopFrontQuad;
        public static readonly Mesh TriangleDownPP_TopMMRectangleTrianlge_BottomQuad_FrontMMRectangleTriangle;

        //20
        public static readonly Mesh BackTopRamp_LeftMMRectangleTriangle_RightMMRectangleTriangle;
        public static readonly Mesh BackTopRampWithOneVertexDown_LeftMMRectangleTriangle;
        public static readonly Mesh BackTopRampWithOneVertexDown_RightMMRectangleTriangle;
        public static readonly Mesh TriangleUpMM_LeftMMTriangleRectangle;





        //21
        public static readonly Mesh TriangleUpMM;
        public static readonly Mesh DiagonalQuadRightFront_TopMMRectangleTriangle;

        //22
        public static readonly Mesh TriangleUpPM;
        public static readonly Mesh DiagonalQuadLeftFront_TopPMRectangleTriangle;
        
        

        //23
        public static readonly Mesh BackTopRamp;
        public static readonly Mesh BackTopRamp_BackMPRectangleTriangle;
        public static readonly Mesh BackTopRamp_BackPPRectangleTriangle;
        public static readonly Mesh BackTopRamp_BottomPPRectangleTriangle;

        //24
        public static readonly Mesh LeftRightBottomFrontQuad;

        //25
        public static readonly Mesh DiagonalQuadRightFront_BottomMMRectangleTriangle;

        //26
        public static readonly Mesh DiagonalQuadLeftFront_BottomPMRectangleTriangle;

        //27
        public static readonly Mesh BottomFrontQuad;

        //28
        public static readonly Mesh LeftRightFrontQuad;
        public static readonly Mesh LeftQuad_RightFrontDiagonalQuad;
        public static readonly Mesh LeftRightFrontQuad_BackMPRectangleTriangle;
        public static readonly Mesh DiagonalQuadLeftFront_RightQuad;
        public static readonly Mesh DiagonalQuadRightFront_LeftQuad;
        
        //29
        public static readonly Mesh DiagonalQuadRightFront;
        public static readonly Mesh DiagonalQuadRightFront_BackPPRectangleTriangle;
        public static readonly Mesh DiagonalQuadRightFront_LeftPPRectangleTriangle;



        //30
        public static readonly Mesh DiagonalQuadLeftFront;
        public static readonly Mesh DiagonalQuadLeftFront_BackMPRectangleTriangle;

        //31
        public static readonly Mesh TopMPRectangleTriangle_FrontQuad;
        public static readonly Mesh TopPPRectangleTriangle_FrontQuad;
        public static readonly Mesh MPTriangleDown_PMFrontRectangleTriangle;
        public static readonly Mesh PPTriangleDown_MMFrontRectangleTriangle;
        public static readonly Mesh BottomPPRectangleTriangle_TopPPRectangleTriangle_FrontQuad;
        public static readonly Mesh LeftPPRectangleTriangle_FrontQuad;
        public static readonly Mesh RightPPRectangleTriangle_FrontQuad;




        //32
        public static readonly Mesh LeftRightBottomTopBackQuad;

        //33
        public static readonly Mesh TriangleUpMP_BottomMPRectangleTriangle;

        //34
        public static readonly Mesh TriangleUpPP_BottomPPRectangleTriangle;

        //35
        public static readonly Mesh BottomTopBackQuad;

        //36
        public static readonly Mesh FrontTopRamp_LeftMPRectangleTriangle_RightMPRectangleTriangle;
        public static readonly Mesh FrontTopRampWithOneVertexDown_RightMPRectangleTriangle;

        
        //37
        public static readonly Mesh TriangleUpMP;
        public static readonly Mesh DiagonalQuadRightBack_TopMPRectangleTriangle;

        //38
        public static readonly Mesh TriangleUpPP;
        public static readonly Mesh DiagonalQuadLeftBack_TopPPRectangleTriangle;

        //39
        public static readonly Mesh FrontTopRamp;
        public static readonly Mesh FrontTopRamp_FrontPPRectangleTriangle;
        public static readonly Mesh FrontTopRamp_FrontMPRectangleTriangle;

        //40
        public static readonly Mesh LeftRightBottomBackQuad;

        //41
        public static readonly Mesh DiagonalQuadRightBack_BottomMPRectangleTriangle;
        public static readonly Mesh PMInTriangleDown_BackMPRectangleTriangle;
        public static readonly Mesh RightBottomRamp;

        //42
        public static readonly Mesh DiagonalQuadLeftBack_BottomPPRectangleTriangle;
        public static readonly Mesh LeftBottomRamp_BackPPRectangleTriangle;
        public static readonly Mesh LeftBottomRamp;

        //43
        public static readonly Mesh BackBottomRamp;

        //44
        public static readonly Mesh LeftRightBack;

        //45
        public static readonly Mesh DiagonalQuadRightBack;
        public static readonly Mesh RightPPRectangleTriangle_BackMPRectangleTriangleTriangleUpPMIn;
        public static readonly Mesh TriangleUpPMIn_RightPPRectangleTriangle_BackMPRectangleTriangle;


        //46
        public static readonly Mesh DiagonalQuadLeftBack;
        public static readonly Mesh LeftBackQuad_FrontMPRectangleTriangle;
        
        

        //47
        public static readonly Mesh MMTriangleDown_PMBackRectangleTriangle;
        public static readonly Mesh PMTriangleDown_MMBackRectangleTriangle;
        public static readonly Mesh RightMMRectangleTriangle_BackQuad;
        public static readonly Mesh LeftMMRectangleTriangle_BackQuad;
        public static readonly Mesh TriangleUpPMIn_BackMPRectangleTriangle;

        //48
        public static readonly Mesh LeftRightBottomTop;

        //49
        public static readonly Mesh RightBottomTop;

        //50
        public static readonly Mesh LeftBottomTop;
        public static readonly Mesh LeftBottomTopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle;
        public static readonly Mesh LeftBottomTopBackQuad_FrontMPRectangleTriangle;
        public static readonly Mesh LeftBottomTopFrontQuad_BackMPRectangleTriangle;

        //51
        public static readonly Mesh BottomTop;

        //52
        public static readonly Mesh LeftQuad_RightQuad_TopQuad_BackPPRectangleTriangle;
        public static readonly Mesh LeftQuad_RightQuad_TopQuad_BackMPRectangleTriangle;
        public static readonly Mesh LeftQuad_RightQuad_TopQuad_FrontPPRectangleTriangle;
        public static readonly Mesh LeftQuad_RightQuad_TopQuad_FrontMPRectangleTriangle;

        //53
        public static readonly Mesh LeftTopRamp;
        public static readonly Mesh LeftTopRamp_LeftPPRectangleTriangle;

        //54
        public static readonly Mesh RightTopRamp;
        public static readonly Mesh RightTopRamp_RightPPRectangleTriangle;
        public static readonly Mesh RightTopRamp_RightPMRectangleTriangle;
        public static readonly Mesh RightTopRampWithOneTriangleDown;

        //55
        public static readonly Mesh MMTriangleDown_PPTriangleDown;
        public static readonly Mesh PMTriangleDown_MPTriangleDown;
        public static readonly Mesh TopMMRectangleTriangle_PPTriangleDown;
        public static readonly Mesh TopMPRectangleTriangle_PMTriangleDown;
        public static readonly Mesh TopPMRectangleTriangle_MPTriangleDown;
        public static readonly Mesh TopPPRectangleTriangle_MMTriangleDown;
        public static readonly Mesh TopQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle;
        public static readonly Mesh TopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle;
        public static readonly Mesh LeftPPRectangleTriangle_RightPPRectangleTriangle_TopQuad;
        public static readonly Mesh LeftPMRectangleTriangle_RightPMRectangleTriangle_TopQuad;
        public static readonly Mesh TopQuad_RightPPRectangleTriangle;
        public static readonly Mesh TopQuad_LeftPPRectangleTriangle;
        public static readonly Mesh TopMMRectangleTriangle_PPTriangleDown_BottomPPRectangleTriangle;
        public static readonly Mesh TopQuad_FrontPPRectangleTriangle;
        public static readonly Mesh TopQuad_FrontMPRectangleTriangle;





        //56
        public static readonly Mesh LeftRightBottomQuad;

        //57
        public static readonly Mesh RightBottomQuad;

        //58
        public static readonly Mesh LeftBottomQuad;

        //59
        public static readonly Mesh BottomQuad;

        //60
        public static readonly Mesh LeftRightQuad;

        //61
        public static readonly Mesh RightQuad_TopPMRectangleTriangle;
        public static readonly Mesh PPTriangleDown_RightMMTriangleRectangle;
        public static readonly Mesh RightQuad_FrontPPRectangleTriangle;
        public static readonly Mesh TopPPRectangleTriangle_RightQuad;
        public static readonly Mesh LeftPPRectangleTriangle_RightQuad_FrontPPRectangleTriangle;
        public static readonly Mesh RightQuad_BackPPRectangleTriangle;
        public static readonly Mesh RightQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle;
        public static readonly Mesh RightMPRectangleTriangle_TriangleDownPM;


        //62
        public static readonly Mesh LeftQuad_BackMPRectangleTriangle;
        public static readonly Mesh LeftMPRectangleTriangle_TriangleDownMM;
        public static readonly Mesh RightMPRectangleTriangle_TriangleDownMM;
        public static readonly Mesh LeftQuad_TopPPRetcangleTriangle_FrontMPRectangleTriangle;
        public static readonly Mesh LeftQuad_TopMMRectangleTriangle;


        //63
        public static readonly Mesh TopPPRectangleTriangle_FrontPPRectangleTriangle;
        public static readonly Mesh RightPPRectangleTriangle_FrontPPRectangleTriangle;
        public static readonly Mesh LeftPMRectangleTriangle_TopMPRectangleTriangle;
        public static readonly Mesh LeftPMRectangleTriangle_BackMPRectangleTriangle;
        public static readonly Mesh LeftPPRectangleTriangle_FrontMPRectangleTriangle;

        public static readonly Mesh TriangleDownMP_TopMPRectangleTriangle_RightMPRectangleTriangle_BackPPRectangleTriangle;












        public static readonly Mesh MMTriangleDown;
        public static readonly Mesh MPTriangleDown;
        public static readonly Mesh PPTriangleDown;

        public static readonly Mesh MPTriangleDown_LeftMMTriangleRectangle;







        //63
        public static readonly Mesh RightPPRectangleTriangle_TopPMRectangleTriangle;
        public static readonly Mesh RightPPRectangleTriangle_TopPPRectangleTriangle;
        public static readonly Mesh BackMPRectangleTriangle_FrontMPRectangleTriangle;
        public static readonly Mesh BackPPRectangleTriangle_FrontPPRectangleTriangle;

        public static readonly Mesh TopMPRectangleTriangle_FrontPPRectangleTriangle;



        public static readonly Mesh LeftMMRectangleTriangle;
        public static readonly Mesh LeftMPRectangleTriangle;
        public static readonly Mesh LeftPMRectangleTriangle;
        public static readonly Mesh LeftPPRectangleTriangle;

        public static readonly Mesh RightMMRectangleTriangle;
        public static readonly Mesh RightMPRectangleTriangle;
        public static readonly Mesh RightPMRectangleTriangle;
        public static readonly Mesh RightPPRectangleTriangle;

        public static readonly Mesh BottomMMRectangleTriangle;
        public static readonly Mesh BottomMPRectangleTriangle;
        public static readonly Mesh BottomPMRectangleTriangle;
        public static readonly Mesh BottomPPRectangleTriangle;

        public static readonly Mesh TopMMRectangleTriangle;
        public static readonly Mesh TopMPRectangleTriangle;
        public static readonly Mesh TopPMRectangleTriangle;
        public static readonly Mesh TopPPRectangleTriangle;

        public static readonly Mesh BackMMRectangleTriangle;
        public static readonly Mesh BackMPRectangleTriangle;
        public static readonly Mesh BackPMRectangleTriangle;
        public static readonly Mesh BackPPRectangleTriangle;

        public static readonly Mesh FrontMMRectangleTriangle;
        public static readonly Mesh FrontMPRectangleTriangle;
        public static readonly Mesh FrontPMRectangleTriangle;
        public static readonly Mesh FrontPPRectangleTriangle;





        public static readonly Mesh FrontBottomRamp;


        //63
        public static readonly Mesh TopPMRectangleTriangle_BackMPRectangleTriangle;
        public static readonly Mesh TopPMRectangleTriangle_BackPPRectangleTriangle;


        public static readonly Mesh TriangleDownMM;
        public static readonly Mesh TriangleDownMP;
        public static readonly Mesh TriangleDownPM;
        public static readonly Mesh TriangleDownPP;


        //55
        public static readonly Mesh TopQuad;

        //62
        public static readonly Mesh LeftQuad_RightPPRectangleTriangle;
        public static readonly Mesh LeftQuad_FrontMPRectangleTriangle;

        #endregion

        #region Pillar Mesh Definition

        public static readonly Mesh Pillar_0;
        public static readonly Mesh Pillar_1;
        public static readonly Mesh Pillar_2;
        public static readonly Mesh Pillar_3;
        public static readonly Mesh Pillar_4;
        public static readonly Mesh Pillar_5;
        public static readonly Mesh Pillar_6;
        public static readonly Mesh Pillar_7;
        public static readonly Mesh Pillar_8;
        public static readonly Mesh Pillar_9;
        public static readonly Mesh Pillar_10;
        public static readonly Mesh Pillar_11;
        public static readonly Mesh Pillar_12;
        public static readonly Mesh Pillar_13;
        public static readonly Mesh Pillar_14;
        public static readonly Mesh Pillar_15;
        public static readonly Mesh Pillar_16;
        public static readonly Mesh Pillar_17;
        public static readonly Mesh Pillar_18;
        public static readonly Mesh Pillar_19;
        public static readonly Mesh Pillar_20;
        public static readonly Mesh Pillar_21;
        public static readonly Mesh Pillar_22;
        public static readonly Mesh Pillar_23;
        public static readonly Mesh Pillar_24;
        public static readonly Mesh Pillar_25;
        public static readonly Mesh Pillar_26;
        public static readonly Mesh Pillar_27;
        public static readonly Mesh Pillar_28;
        public static readonly Mesh Pillar_29;
        public static readonly Mesh Pillar_30;
        public static readonly Mesh Pillar_31;
        public static readonly Mesh Pillar_32;
        public static readonly Mesh Pillar_33;
        public static readonly Mesh Pillar_34;
        public static readonly Mesh Pillar_35;
        public static readonly Mesh Pillar_36;
        public static readonly Mesh Pillar_37;
        public static readonly Mesh Pillar_38;
        public static readonly Mesh Pillar_39;
        public static readonly Mesh Pillar_40;
        public static readonly Mesh Pillar_41;
        public static readonly Mesh Pillar_42;
        public static readonly Mesh Pillar_43;
        public static readonly Mesh Pillar_44;
        public static readonly Mesh Pillar_45;
        public static readonly Mesh Pillar_46;
        public static readonly Mesh Pillar_47;
        public static readonly Mesh Pillar_48;
        public static readonly Mesh Pillar_49;
        public static readonly Mesh Pillar_50;
        public static readonly Mesh Pillar_51;
        public static readonly Mesh Pillar_52;
        public static readonly Mesh Pillar_53;
        public static readonly Mesh Pillar_54;
        public static readonly Mesh Pillar_55;
        public static readonly Mesh Pillar_56;
        public static readonly Mesh Pillar_57;
        public static readonly Mesh Pillar_58;
        public static readonly Mesh Pillar_59;
        public static readonly Mesh Pillar_60;
        public static readonly Mesh Pillar_61;
        public static readonly Mesh Pillar_62;
        public static readonly Mesh Pillar_63;

        #endregion

        static MeshDefinition()
        {
            #region Planet Mesh Definition

            //1
            RightBottomTopBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //2                                             
            LeftBottomTopBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //3                                          
            BottomTopBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );


            BottomTopBackFrontQuad_RightPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //4                               
            LeftRightTopBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //5
            LeftTopRamp_BackMMRectangleTriangle_FrontMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.LeftTop),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MMOut)
            );

            DiagonalQuadRightFront_TopMMRectangleTriangle_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut),
                MeshCreation.CreateQuad(Direction.Back)
            );

            //6
            RightTopRamp_BackPMRectangleTriangle_FrontPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.RightTop),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PMOut)
            );
            
            DiagonalQuadLeftFront_TopPMRectangleTriangle_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut),
                MeshCreation.CreateQuad(Direction.Back)
            );
            

            TriangleUpPM_BackPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PMOut)
            );

            RightTopRampWithOneVertexDown_BackPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRampWithOneUpVertexDown(RampDirection.RightTop, true),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PMOut)
            );

            //7
            TopBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //8
            LeftRightBottomBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //9
            RightBottomBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //10
            LeftBottomBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //11
            BottomBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //12
            LeftRightBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //13
            RightBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            FrontRightDiagonalQuad_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateQuad(Direction.Back)
            );


            //14            
            LeftBackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );
            
            FrontLeftDiagonalQuad_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront),
                MeshCreation.CreateQuad(Direction.Back)
            );
            
            //15            
            BackFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //16
            LeftRightBottomTopFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //17
            MMTriangleUp_BottomMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MMOut)
            );

            //18
            TriangleUpPM_BottomPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PMOut)
            );

            //19
            BottomTopFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Front)
            );

            TriangleDownPP_TopMMRectangleTrianlge_BottomQuad_FrontMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut),
                MeshCreation.CreateQuad(Direction.Bottom)
            );

            //20
            BackTopRamp_LeftMMRectangleTriangle_RightMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.BackTop),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MMOut)
            );

            BackTopRampWithOneVertexDown_LeftMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRampWithOneUpVertexDown(RampDirection.BackTop, true),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut)
            );

            BackTopRampWithOneVertexDown_RightMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRampWithOneUpVertexDown(RampDirection.BackTop, false),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MMOut)
            );

            TriangleUpMM_LeftMMTriangleRectangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut)
            );


            //21
            TriangleUpMM = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.MMOut)
            );

            DiagonalQuadRightFront_TopMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateRectangleTriangle(Direction.Top,TriangleOrigin.MMOut)
            );
            
            
            //22
            TriangleUpPM = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMOut)
            );
            
            DiagonalQuadLeftFront_TopPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront),
                MeshCreation.CreateRectangleTriangle(Direction.Top,TriangleOrigin.PMOut)
            );

            
            //23
            BackTopRamp = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.BackTop)
            );
            BackTopRamp_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.BackTop),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );
            BackTopRamp_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.BackTop),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );
            BackTopRamp_BottomPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.BackTop),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut)
            );

            //24
            LeftRightBottomFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //25
            DiagonalQuadRightFront_BottomMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MMOut)
            );

            //26
            DiagonalQuadLeftFront_BottomPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PMOut)
            );

            //27
            BottomFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Front)
            );

            //28
            LeftRightFrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Front)
            );

            LeftQuad_RightFrontDiagonalQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront)
            );

            LeftRightFrontQuad_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Front),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            DiagonalQuadRightFront_LeftQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront)
            );
            
            DiagonalQuadLeftFront_RightQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront)
            );
            
            
            //29
            DiagonalQuadRightFront = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront)
            );

            DiagonalQuadRightFront_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );

            DiagonalQuadRightFront_LeftPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightFront),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut)
            );
            

            //30
            DiagonalQuadLeftFront = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront)
            );

            DiagonalQuadLeftFront_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftFront),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            //31
            TopMPRectangleTriangle_FrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut),
                MeshCreation.CreateQuad(Direction.Front)
            );
            
            TopPPRectangleTriangle_FrontQuad = CombineMeshes.CombineAllAtOrigin(

                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Front)
            );
            
            MPTriangleDown_PMFrontRectangleTriangle = CombineMeshes.CombineAllAtOrigin(

                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut)
            );
            
            PPTriangleDown_MMFrontRectangleTriangle = CombineMeshes.CombineAllAtOrigin(

                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut)
            );
            
            BottomPPRectangleTriangle_TopPPRectangleTriangle_FrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Front)
            );
            
            LeftPPRectangleTriangle_FrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Front)
            );

            RightPPRectangleTriangle_FrontQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Front)
            );
            
            //32
            LeftRightBottomTopBackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back)
            );

            //33
            TriangleUpMP_BottomMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MPOut)
            );

            //34
            TriangleUpPP_BottomPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut)
            );

            //35
            BottomTopBackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back)
            );

            //36
            FrontTopRamp_LeftMPRectangleTriangle_RightMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.FrontTop),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MPOut)
            );

            FrontTopRampWithOneVertexDown_RightMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRampWithOneUpVertexDown(RampDirection.FrontTop, false),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MPOut)
            );
            
            //37
            TriangleUpMP = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.MPOut)
            );
            
            DiagonalQuadRightBack_TopMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightBack),
                MeshCreation.CreateRectangleTriangle(Direction.Top,TriangleOrigin.MPOut)
            );

            //38
            TriangleUpPP = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PPOut)
            );

            DiagonalQuadLeftBack_TopPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftBack),
                MeshCreation.CreateRectangleTriangle(Direction.Top,TriangleOrigin.PPOut)
            );
            
            //39
            FrontTopRamp = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.FrontTop)
            );

            FrontTopRamp_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.FrontTop),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            FrontTopRamp_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.FrontTop),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );

            //40
            LeftRightBottomBackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Back)
            );

            //41
            DiagonalQuadRightBack_BottomMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightBack),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MPOut)
            );
            
            PMInTriangleDown_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMIn),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );
            
            RightBottomRamp = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.RightBottom)
            );

            //42
            DiagonalQuadLeftBack_BottomPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftBack),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut)
            );
            LeftBottomRamp_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.LeftBottom),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );
            
            LeftBottomRamp = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateRamp(RampDirection.LeftBottom));

            //43
            BackBottomRamp = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateRamp(RampDirection.BackBottom));

            //44
            LeftRightBack = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Back)
            );

            //45
            DiagonalQuadRightBack = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.RightBack)
            );

            RightPPRectangleTriangle_BackMPRectangleTriangleTriangleUpPMIn = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut),
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMIn)
            );

            TriangleUpPMIn_RightPPRectangleTriangle_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMIn),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            //46
            DiagonalQuadLeftBack = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateDiagonalQuad(DiagonalQuadDirection.LeftBack)
            );
            
            LeftBackQuad_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateRectangleTriangle(Direction.Front,TriangleOrigin.MPOut)
            );

            //47
            MMTriangleDown_PMBackRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut)
            );
            
            PMTriangleDown_MMBackRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (

                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PMOut)
            );
            
            RightMMRectangleTriangle_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MMOut),
                MeshCreation.CreateQuad(Direction.Back)
            );
            
            LeftMMRectangleTriangle_BackQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut),
                MeshCreation.CreateQuad(Direction.Back)
            );

            TriangleUpPMIn_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingUp(TriangleOrigin.PMIn),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            //48
            LeftRightBottomTop = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top)
            );

            //49
            RightBottomTop = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top)
            );

            //50
            LeftBottomTop = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top)
            );
            
            LeftBottomTopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Back,TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front,TriangleOrigin.MPOut)
            );
            
            LeftBottomTopBackQuad_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Back),
                MeshCreation.CreateRectangleTriangle(Direction.Front,TriangleOrigin.MPOut)
            );
            
            LeftBottomTopFrontQuad_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateQuad(Direction.Front),
                MeshCreation.CreateRectangleTriangle(Direction.Back,TriangleOrigin.MPOut)
            );
        

            //51
            BottomTop = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom),
                MeshCreation.CreateQuad(Direction.Top)
            );

            //52
            LeftQuad_RightQuad_TopQuad_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );
            
            LeftQuad_RightQuad_TopQuad_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );
            
            LeftQuad_RightQuad_TopQuad_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );
            
            LeftQuad_RightQuad_TopQuad_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );

            //53
            LeftTopRamp = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.LeftTop)
            );
            
            LeftTopRamp_LeftPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.LeftTop),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut)
            );

            //54
            RightTopRamp = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateRamp(RampDirection.RightTop));
            
            RightTopRampWithOneTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRampWithOneUpVertexDown(RampDirection.RightTop, true)
            );
            

            RightTopRamp_RightPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.RightTop),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut)
            );
            
            RightTopRamp_RightPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.RightTop),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PMOut)
            );
            
            //55
            MMTriangleDown_PPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut)
            );

            PMTriangleDown_MPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut)
            );
            
            TopMMRectangleTriangle_PPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut)
            );
            
            TopMPRectangleTriangle_PMTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PMOut)
            );
            
            TopPMRectangleTriangle_MPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut)
            );
            
            TopPPRectangleTriangle_MMTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut)
            );
            
            TopQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );
            
            TopQuad_BackMPRectangleTriangle_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );
            
            LeftPPRectangleTriangle_RightPPRectangleTriangle_TopQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Top)
            );
            
            LeftPMRectangleTriangle_RightPMRectangleTriangle_TopQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PMOut),
                MeshCreation.CreateQuad(Direction.Top)
            );
            
            TopQuad = MeshCreation.CreateQuad(Direction.Top);

            TopQuad_LeftPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut)
            );

            TopQuad_RightPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut)
            );

            TopMMRectangleTriangle_PPTriangleDown_BottomPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut)
            );

            TopQuad_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            TopQuad_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Top),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );

            //56
            LeftRightBottomQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom)

            );

            //57               
            RightBottomQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateQuad(Direction.Bottom)
            );

            //58             
            LeftBottomQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Bottom)
            );

            //59              
            BottomQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Bottom)
            );

            //60
            LeftRightQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateQuad(Direction.Right)
            );

            //61
            PPTriangleDown_RightMMTriangleRectangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut)
            );

            RightQuad_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            TopPPRectangleTriangle_RightQuad = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Right)
            );

            LeftPPRectangleTriangle_RightQuad_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut),
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            RightQuad_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );


            RightQuad_BackPPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            RightMPRectangleTriangle_TriangleDownPM = CombineMeshes.CombineAllAtOrigin(

                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MPOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PMOut)
            );

            //62
            MPTriangleDown_LeftMMTriangleRectangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut)
            );

            LeftQuad_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            LeftMPRectangleTriangle_TriangleDownMM = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MPOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut)
            );

            RightMPRectangleTriangle_TriangleDownMM = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MPOut),
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut)
            );

            //63
            TopPPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            RightPPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            LeftPMRectangleTriangle_TopMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut)
            );

            TriangleDownMP_TopMPRectangleTriangle_RightMPRectangleTriangle_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );
            
            LeftPMRectangleTriangle_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );
            

            //62
            LeftQuad_RightPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut)
            );

            LeftQuad_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );

            //63
            MMTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut)
            );
            
            MPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut)
            );
            
            PPTriangleDown = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut)
            );

            RightPPRectangleTriangle_TopPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut)
            );

            RightPPRectangleTriangle_TopPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut)
            );
            
            BackMPRectangleTriangle_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );

            BackPPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            RightQuad_TopPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Right),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut)
            );

            TopMPRectangleTriangle_FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            LeftQuad_TopPPRetcangleTriangle_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );
            
            LeftQuad_TopMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateQuad(Direction.Left),
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut)
            );
            
            LeftPPRectangleTriangle_FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );
                
            
            LeftMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MMOut)
            );
            
            LeftMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.MPOut)
            );
            
            LeftPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PMOut)
            );
            
            LeftPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Left, TriangleOrigin.PPOut)
            );

            RightMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MMOut)
            );
            
            RightMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.MPOut)
            );
            
            RightPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PMOut)
            );
            
            RightPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Right, TriangleOrigin.PPOut)
            );

            BottomMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MMOut)
            );
            
            BottomMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.MPOut)
            );
            
            BottomPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PMOut)
            );
            
            BottomPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Bottom, TriangleOrigin.PPOut)
            );

            TopMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MMOut)
            );
            
            TopMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.MPOut)
            );
            
            TopPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut)
            );
            
            TopPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PPOut)
            );

            BackMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MMOut)
            );
            
            BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );
            
            BackPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PMOut)
            );
            
            BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );

            FrontMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MMOut)
            );
            
            FrontMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MPOut)
            );
            
            FrontPMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PMOut)
            );
            
            FrontPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.PPOut)
            );

            LeftTopRamp_BackMMRectangleTriangle_FrontMMRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRamp(RampDirection.LeftTop),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Front, TriangleOrigin.MMOut)
            );

            FrontBottomRamp = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateRamp(RampDirection.FrontBottom));

            TriangleDownMM = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MMOut));
            
            TriangleDownMP = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateTrianglePointingDown(TriangleOrigin.MPOut));
            
            TriangleDownPM = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PMOut));
            
            TriangleDownPP = CombineMeshes.CombineAllAtOrigin(MeshCreation.CreateTrianglePointingDown(TriangleOrigin.PPOut));

            //63
            TopPMRectangleTriangle_BackMPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.MPOut)
            );

            TopPMRectangleTriangle_BackPPRectangleTriangle = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreateRectangleTriangle(Direction.Top, TriangleOrigin.PMOut),
                MeshCreation.CreateRectangleTriangle(Direction.Back, TriangleOrigin.PPOut)
            );

            #endregion

            #region Pillar Mesh Definition

            Pillar_0 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, .1f, new Vector3(.45f, .2f, .45f))
            );

            Pillar_1 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f))
            );

            Pillar_2 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f))
            );

            Pillar_3 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f))
            );

            Pillar_4 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_5 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_6 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_7 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_8 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_9 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, .3f, .45f))
            );

            Pillar_10 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, .3f, .45f))
            );

            Pillar_11 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, .3f, .45f))
            );

            Pillar_12 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_13 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_14 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_15 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_16 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, .55f, new Vector3(.45f, .2f, 0))
            );

            Pillar_17 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_18 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_19 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_20 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, .55f, new Vector3(.45f, .2f, 0)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_21 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_22 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_23 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_24 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_25 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_26 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_27 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_28 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_29 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_30 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_31 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_32 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, .55f, new Vector3(.45f, .2f, .45f))
            );

            Pillar_33 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_34 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_35 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(1f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_36 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, .55f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_37 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_38 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_39 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );




            Pillar_44 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_45 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_46 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_47 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f))
            );

            Pillar_48 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, 1f, new Vector3(.45f, .2f, 0))
            );

            Pillar_49 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, 1f, new Vector3(.45f, .2f, 0))
            );

            Pillar_50 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, 1f, new Vector3(.45f, .2f, 0))
            );

            Pillar_51 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, 1f, new Vector3(.45f, .2f, 0))
            );

            Pillar_52 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .1f, 1f, new Vector3(.45f, .2f, 0)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f))
            );

            Pillar_53 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_54 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.55f, .1f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .2f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_55 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_56 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_57 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_58 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_59 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .3f, .1f, new Vector3(.45f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_60 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_61 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );

            Pillar_62 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
            
            Pillar_63 = CombineMeshes.CombineAllAtOrigin
            (
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(0, .2f, .45f)),
                MeshCreation.CreatePillar(.45f, .1f, .1f, new Vector3(.55f, .2f, .45f)),
                MeshCreation.CreatePillar(.1f, .5f, .1f, new Vector3(.45f, 0, .45f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, .55f)),
                MeshCreation.CreatePillar(.1f, .1f, .45f, new Vector3(.45f, .2f, 0))
            );
        }

        #endregion
    }
}