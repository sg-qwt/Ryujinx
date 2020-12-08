namespace ARMeilleure.Instructions
{
    enum InstName
    {
        // Base (AArch64)
        Adc,
        Adcs,
        Add,
        Adds,
        Adr,
        Adrp,
        And,
        Ands,
        Asrv,
        B,
        B_Cond,
        Bfm,
        Bic,
        Bics,
        Bl,
        Blr,
        Br,
        Brk,
        Cbnz,
        Cbz,
        Ccmn,
        Ccmp,
        Clrex,
        Cls,
        Clz,
        Crc32b,
        Crc32h,
        Crc32w,
        Crc32x,
        Crc32cb,
        Crc32ch,
        Crc32cw,
        Crc32cx,
        Csel,
        Csinc,
        Csinv,
        Csneg,
        Dmb,
        Dsb,
        Eon,
        Eor,
        Extr,
        Hint,
        Isb,
        Ldar,
        Ldaxp,
        Ldaxr,
        Ldp,
        Ldr,
        Ldr_Literal,
        Ldrs,
        Ldxr,
        Ldxp,
        Lslv,
        Lsrv,
        Madd,
        Movk,
        Movn,
        Movz,
        Mrs,
        Msr,
        Msub,
        Nop,
        Orn,
        Orr,
        Pfrm,
        Rbit,
        Ret,
        Rev16,
        Rev32,
        Rev64,
        Rorv,
        Sbc,
        Sbcs,
        Sbfm,
        Sdiv,
        Smaddl,
        Smsubl,
        Smulh,
        Smull,
        Smulw_,
        Ssat,
        Ssat16,
        Stlr,
        Stlxp,
        Stlxr,
        Stp,
        Str,
        Stxp,
        Stxr,
        Sub,
        Subs,
        Svc,
        Sxtb,
        Sxth,
        Sys,
        Tbnz,
        Tbz,
        Ubfm,
        Udiv,
        Umaddl,
        Umsubl,
        Umulh,
        Und,

        // FP & SIMD (AArch64)
        Abs_S,
        Abs_V,
        Add_S,
        Add_V,
        Addhn_V,
        Addp_S,
        Addp_V,
        Addv_V,
        Aesd_V,
        Aese_V,
        Aesimc_V,
        Aesmc_V,
        And_V,
        Bic_V,
        Bic_Vi,
        Bif_V,
        Bit_V,
        Bsl_V,
        Cls_V,
        Clz_V,
        Cmeq_S,
        Cmeq_V,
        Cmge_S,
        Cmge_V,
        Cmgt_S,
        Cmgt_V,
        Cmhi_S,
        Cmhi_V,
        Cmhs_S,
        Cmhs_V,
        Cmle_S,
        Cmle_V,
        Cmlt_S,
        Cmlt_V,
        Cmtst_S,
        Cmtst_V,
        Cnt_V,
        Dup_Gp,
        Dup_S,
        Dup_V,
        Eor_V,
        Ext_V,
        Fabd_S,
        Fabd_V,
        Fabs_S,
        Fabs_V,
        Facge_S,
        Facge_V,
        Facgt_S,
        Facgt_V,
        Fadd_S,
        Fadd_V,
        Faddp_S,
        Faddp_V,
        Fccmp_S,
        Fccmpe_S,
        Fcmeq_S,
        Fcmeq_V,
        Fcmge_S,
        Fcmge_V,
        Fcmgt_S,
        Fcmgt_V,
        Fcmle_S,
        Fcmle_V,
        Fcmlt_S,
        Fcmlt_V,
        Fcmp_S,
        Fcmpe_S,
        Fcsel_S,
        Fcvt_S,
        Fcvtas_Gp,
        Fcvtas_S,
        Fcvtas_V,
        Fcvtau_Gp,
        Fcvtau_S,
        Fcvtau_V,
        Fcvtl_V,
        Fcvtms_Gp,
        Fcvtmu_Gp,
        Fcvtn_V,
        Fcvtns_S,
        Fcvtns_V,
        Fcvtnu_S,
        Fcvtnu_V,
        Fcvtps_Gp,
        Fcvtpu_Gp,
        Fcvtzs_Gp,
        Fcvtzs_Gp_Fixed,
        Fcvtzs_S,
        Fcvtzs_V,
        Fcvtzs_V_Fixed,
        Fcvtzu_Gp,
        Fcvtzu_Gp_Fixed,
        Fcvtzu_S,
        Fcvtzu_V,
        Fcvtzu_V_Fixed,
        Fdiv_S,
        Fdiv_V,
        Fmadd_S,
        Fmax_S,
        Fmax_V,
        Fmaxnm_S,
        Fmaxnm_V,
        Fmaxnmp_V,
        Fmaxnmv_V,
        Fmaxp_V,
        Fmaxv_V,
        Fmin_S,
        Fmin_V,
        Fminnm_S,
        Fminnm_V,
        Fminnmp_V,
        Fminnmv_V,
        Fminp_V,
        Fminv_V,
        Fmla_Se,
        Fmla_V,
        Fmla_Ve,
        Fmls_Se,
        Fmls_V,
        Fmls_Ve,
        Fmov_S,
        Fmov_Si,
        Fmov_Vi,
        Fmov_Ftoi,
        Fmov_Itof,
        Fmov_Ftoi1,
        Fmov_Itof1,
        Fmsub_S,
        Fmul_S,
        Fmul_Se,
        Fmul_V,
        Fmul_Ve,
        Fmulx_S,
        Fmulx_Se,
        Fmulx_V,
        Fmulx_Ve,
        Fneg_S,
        Fneg_V,
        Fnmadd_S,
        Fnmsub_S,
        Fnmul_S,
        Frecpe_S,
        Frecpe_V,
        Frecps_S,
        Frecps_V,
        Frecpx_S,
        Frinta_S,
        Frinta_V,
        Frinti_S,
        Frinti_V,
        Frintm_S,
        Frintm_V,
        Frintn_S,
        Frintn_V,
        Frintp_S,
        Frintp_V,
        Frintx_S,
        Frintx_V,
        Frintz_S,
        Frintz_V,
        Frsqrte_S,
        Frsqrte_V,
        Frsqrts_S,
        Frsqrts_V,
        Fsqrt_S,
        Fsqrt_V,
        Fsub_S,
        Fsub_V,
        Ins_Gp,
        Ins_V,
        Ld__Vms,
        Ld__Vss,
        Mla_V,
        Mla_Ve,
        Mls_V,
        Mls_Ve,
        Movi_V,
        Mul_V,
        Mul_Ve,
        Mvni_V,
        Neg_S,
        Neg_V,
        Not_V,
        Orn_V,
        Orr_V,
        Orr_Vi,
        Raddhn_V,
        Rbit_V,
        Rev16_V,
        Rev32_V,
        Rev64_V,
        Rshrn_V,
        Rsubhn_V,
        Saba_V,
        Sabal_V,
        Sabd_V,
        Sabdl_V,
        Sadalp_V,
        Saddl_V,
        Saddlp_V,
        Saddlv_V,
        Saddw_V,
        Scvtf_Gp,
        Scvtf_Gp_Fixed,
        Scvtf_S,
        Scvtf_S_Fixed,
        Scvtf_V,
        Scvtf_V_Fixed,
        Sha1c_V,
        Sha1h_V,
        Sha1m_V,
        Sha1p_V,
        Sha1su0_V,
        Sha1su1_V,
        Sha256h_V,
        Sha256h2_V,
        Sha256su0_V,
        Sha256su1_V,
        Shadd_V,
        Shl_S,
        Shl_V,
        Shll_V,
        Shrn_V,
        Shsub_V,
        Sli_S,
        Sli_V,
        Smax_V,
        Smaxp_V,
        Smaxv_V,
        Smin_V,
        Sminp_V,
        Sminv_V,
        Smlal_V,
        Smlal_Ve,
        Smlsl_V,
        Smlsl_Ve,
        Smov_S,
        Smull_V,
        Smull_Ve,
        Sqabs_S,
        Sqabs_V,
        Sqadd_S,
        Sqadd_V,
        Sqdmulh_S,
        Sqdmulh_V,
        Sqneg_S,
        Sqneg_V,
        Sqrdmulh_S,
        Sqrdmulh_V,
        Sqrshl_V,
        Sqrshrn_S,
        Sqrshrn_V,
        Sqrshrun_S,
        Sqrshrun_V,
        Sqshl_V,
        Sqshrn_S,
        Sqshrn_V,
        Sqshrun_S,
        Sqshrun_V,
        Sqsub_S,
        Sqsub_V,
        Sqxtn_S,
        Sqxtn_V,
        Sqxtun_S,
        Sqxtun_V,
        Srhadd_V,
        Sri_S,
        Sri_V,
        Srshl_V,
        Srshr_S,
        Srshr_V,
        Srsra_S,
        Srsra_V,
        Sshl_S,
        Sshl_V,
        Sshll_V,
        Sshr_S,
        Sshr_V,
        Ssra_S,
        Ssra_V,
        Ssubl_V,
        Ssubw_V,
        St__Vms,
        St__Vss,
        Sub_S,
        Sub_V,
        Subhn_V,
        Suqadd_S,
        Suqadd_V,
        Tbl_V,
        Tbx_V,
        Trn1_V,
        Trn2_V,
        Uaba_V,
        Uabal_V,
        Uabd_V,
        Uabdl_V,
        Uadalp_V,
        Uaddl_V,
        Uaddlp_V,
        Uaddlv_V,
        Uaddw_V,
        Ucvtf_Gp,
        Ucvtf_Gp_Fixed,
        Ucvtf_S,
        Ucvtf_S_Fixed,
        Ucvtf_V,
        Ucvtf_V_Fixed,
        Uhadd_V,
        Uhsub_V,
        Umax_V,
        Umaxp_V,
        Umaxv_V,
        Umin_V,
        Uminp_V,
        Uminv_V,
        Umlal_V,
        Umlal_Ve,
        Umlsl_V,
        Umlsl_Ve,
        Umov_S,
        Umull_V,
        Umull_Ve,
        Uqadd_S,
        Uqadd_V,
        Uqrshl_V,
        Uqrshrn_S,
        Uqrshrn_V,
        Uqshl_V,
        Uqshrn_S,
        Uqshrn_V,
        Uqsub_S,
        Uqsub_V,
        Uqxtn_S,
        Uqxtn_V,
        Urhadd_V,
        Urshl_V,
        Urshr_S,
        Urshr_V,
        Ursra_S,
        Ursra_V,
        Ushl_S,
        Ushl_V,
        Ushll_V,
        Ushr_S,
        Ushr_V,
        Usqadd_S,
        Usqadd_V,
        Usra_S,
        Usra_V,
        Usubl_V,
        Usubw_V,
        Uzp1_V,
        Uzp2_V,
        Xtn_V,
        Zip1_V,
        Zip2_V,

        // Base (AArch32)
        Bfc,
        Bfi,
        Blx,
        Bx,
        Cmp,
        Cmn,
        Movt,
        Mul,
        Lda,
        Ldab,
        Ldaex,
        Ldaexb,
        Ldaexd,
        Ldaexh,
        Ldah,
        Ldm,
        Ldrb,
        Ldrd,
        Ldrex,
        Ldrexb,
        Ldrexd,
        Ldrexh,
        Ldrh,
        Ldrsb,
        Ldrsh,
        Mcr,
        Mla,
        Mls,
        Mov,
        Mrc,
        Mrrc,
        Mvn,
        Pkh,
        Pld,
        Rev,
        Revsh,
        Rsb,
        Rsc,
        Sbfx,
        Smla__,
        Smlal,
        Smlal__,
        Smlaw_,
        Smmla,
        Smmls,
        Smul__,
        Smmul,
        Stl,
        Stlb,
        Stlex,
        Stlexb,
        Stlexd,
        Stlexh,
        Stlh,
        Stm,
        Strb,
        Strd,
        Strex,
        Strexb,
        Strexd,
        Strexh,
        Strh,
        Sxtb16,
        Teq,
        Trap,
        Tst,
        Ubfx,
        Umaal,
        Umlal,
        Umull,
        Usat,
        Usat16,
        Uxtb,
        Uxtb16,
        Uxth,

        // FP & SIMD (AArch32)
        Vabd,
        Vabdl,
        Vabs,
        Vadd,
        Vaddl,
        Vaddw,
        Vand,
        Vbic,
        Vbif,
        Vbit,
        Vbsl,
        Vceq,
        Vcge,
        Vcgt,
        Vcle,
        Vclt,
        Vcmp,
        Vcmpe,
        Vcvt,
        Vdiv,
        Vdup,
        Veor,
        Vext,
        Vfma,
        Vfms,
        Vfnma,
        Vfnms,
        Vhadd,
        Vld1,
        Vld2,
        Vld3,
        Vld4,
        Vldm,
        Vldr,
        Vmax,
        Vmaxnm,
        Vmin,
        Vminnm,
        Vmla,
        Vmls,
        Vmlsl,
        Vmov,
        Vmovl,
        Vmovn,
        Vmrs,
        Vmsr,
        Vmul,
        Vmull,
        Vmvn,
        Vneg,
        Vnmul,
        Vnmla,
        Vnmls,
        Vorr,
        Vpadd,
        Vpmax,
        Vpmin,
        Vqrshrn,
        Vqrshrun,
        Vqshrn,
        Vrev,
        Vrint,
        Vrshr,
        Vsel,
        Vshl,
        Vshll,
        Vshr,
        Vshrn,
        Vst1,
        Vst2,
        Vst3,
        Vst4,
        Vstm,
        Vstr,
        Vsqrt,
        Vrecpe,
        Vrecps,
        Vrsqrte,
        Vrsqrts,
        Vsra,
        Vsub,
        Vsubw,
        Vtbl,
        Vtrn,
        Vtst,
        Vuzp,
        Vzip,
    }
}
