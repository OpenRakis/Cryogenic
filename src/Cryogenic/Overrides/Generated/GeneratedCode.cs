namespace Cryogenic.Overrides;

public partial class Overrides : CSharpOverrideHelper {

/*  private ushort cs1; // 0x1000
  private ushort cs2; // 0x334B
  private ushort cs3; // 0x5635
  private ushort cs4; // 0x563E
  private ushort cs5; // 0xF000
  
  public Overrides(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, Machine machine, ushort entrySegment = 0x1000) : base(functionInformations, machine) {
    // Observed cs1 address at generation time is 0x1000. Do not set entrySegment to something else if the program is not relocatable.
    this.cs1 = (ushort)(entrySegment + 0x0);
    this.cs2 = (ushort)(entrySegment + 0x234B);
    this.cs3 = (ushort)(entrySegment + 0x4635);
    this.cs4 = (ushort)(entrySegment + 0x463E);
    this.cs5 = (ushort)(entrySegment + 0xE000);
    
    DefineGeneratedCodeOverrides();
    DetectCodeRewrites();
  }
  
  */
  public void DefineGeneratedCodeOverrides() {
    // 0x1000
    DefineFunction(cs1, 0x0, entry_1000_0000_10000, false);
    DefineFunction(cs1, 0x3A, spice86_generated_label_jump_target_1000_003A_01003A, false);
    DefineFunction(cs1, 0x83, spice86_generated_label_call_target_1000_0083_010083, false);
    DefineFunction(cs1, 0x98, spice86_generated_label_call_target_1000_0098_010098, false);
    DefineFunction(cs1, 0xB0, spice86_generated_label_call_target_1000_00B0_0100B0, false);
    DefineFunction(cs1, 0xD1, spice86_generated_label_call_target_1000_00D1_0100D1, false);
    DefineFunction(cs1, 0x169, spice86_generated_label_call_target_1000_0169_010169, false);
    DefineFunction(cs1, 0x1E0, spice86_generated_label_call_target_1000_01E0_0101E0, false);
    DefineFunction(cs1, 0x21C, spice86_generated_label_call_target_1000_021C_01021C, false);
    DefineFunction(cs1, 0x309, spice86_generated_label_call_target_1000_0309_010309, false);
    DefineFunction(cs1, 0x579, spice86_generated_label_call_target_1000_0579_010579, false);
    DefineFunction(cs1, 0x580, spice86_generated_label_call_target_1000_0580_010580, false);
    DefineFunction(cs1, 0x61C, spice86_generated_label_call_target_1000_061C_01061C, false);
    DefineFunction(cs1, 0x625, spice86_generated_label_call_target_1000_0625_010625, false);
    DefineFunction(cs1, 0x64D, load_CRYO_HNM_ida_1000_064D_1064D, false);
    DefineFunction(cs1, 0x658, load_CRYO2_HNM_ida_1000_0658_10658, false);
    DefineFunction(cs1, 0x661, play_CRYO_OR_CRYO2_HNM_ida_1000_0661_10661, false);
    DefineFunction(cs1, 0x678, load_PRESENT_HNM_ida_1000_0678_10678, false);
    DefineFunction(cs1, 0x684, play_PRESENT_HNM_ida_1000_0684_10684, false);
    DefineFunction(cs1, 0x69E, load_INTRO_HNM_ida_1000_069E_1069E, false);
    DefineFunction(cs1, 0x6AA, play_hnm_86_frames_ida_1000_06AA_106AA, false);
    DefineFunction(cs1, 0x6BD, play_hnm_skippable_ida_1000_06BD_106BD, false);
    DefineFunction(cs1, 0x8F0, split_1000_08F0_0108F0, false);
    DefineFunction(cs1, 0x911, spice86_generated_label_call_target_1000_0911_010911, false);
    DefineFunction(cs1, 0x93F, spice86_generated_label_call_target_1000_093F_01093F, false);
    DefineFunction(cs1, 0x945, spice86_generated_label_call_target_1000_0945_010945, false);
    DefineFunction(cs1, 0x9EF, play_CREDITS_HNM_ida_1000_09EF_109EF, false);
    DefineFunction(cs1, 0xA3E, spice86_generated_label_call_target_1000_0A3E_010A3E, false);
    DefineFunction(cs1, 0xB21, spice86_generated_label_call_target_1000_0B21_010B21, false);
    DefineFunction(cs1, 0xF66, spice86_generated_label_call_target_1000_0F66_010F66, false);
    DefineFunction(cs1, 0xFA7, split_1000_0FA7_010FA7, false);
    DefineFunction(cs1, 0xFD9, spice86_generated_label_call_target_1000_0FD9_010FD9, false);
    DefineFunction(cs1, 0x121F, split_1000_121F_01121F, false);
    DefineFunction(cs1, 0x127C, spice86_generated_label_call_target_1000_127C_01127C, false);
    DefineFunction(cs1, 0x16FC, split_1000_16FC_0116FC, false);
    DefineFunction(cs1, 0x1797, spice86_generated_label_call_target_1000_1797_011797, false);
    DefineFunction(cs1, 0x17BE, spice86_generated_label_call_target_1000_17BE_0117BE, false);
    DefineFunction(cs1, 0x17E6, spice86_generated_label_call_target_1000_17E6_0117E6, false);
    DefineFunction(cs1, 0x1803, spice86_generated_label_call_target_1000_1803_011803, false);
    DefineFunction(cs1, 0x181E, spice86_generated_label_call_target_1000_181E_01181E, false);
    DefineFunction(cs1, 0x1834, spice86_generated_label_call_target_1000_1834_011834, false);
    DefineFunction(cs1, 0x1843, spice86_generated_label_call_target_1000_1843_011843, false);
    DefineFunction(cs1, 0x1860, spice86_generated_label_call_target_1000_1860_011860, false);
    DefineFunction(cs1, 0x18BA, spice86_generated_label_call_target_1000_18BA_0118BA, false);
    DefineFunction(cs1, 0x1A0F, spice86_generated_label_call_target_1000_1A0F_011A0F, false);
    DefineFunction(cs1, 0x1A34, spice86_generated_label_call_target_1000_1A34_011A34, false);
    DefineFunction(cs1, 0x1A9B, spice86_generated_label_call_target_1000_1A9B_011A9B, false);
    DefineFunction(cs1, 0x1AC5, spice86_generated_label_call_target_1000_1AC5_011AC5, false);
    DefineFunction(cs1, 0x1AD1, spice86_generated_label_call_target_1000_1AD1_011AD1, false);
    DefineFunction(cs1, 0x1AE0, spice86_generated_label_call_target_1000_1AE0_011AE0, false);
    DefineFunction(cs1, 0x1AE7, spice86_generated_label_call_target_1000_1AE7_011AE7, false);
    DefineFunction(cs1, 0x1B0D, spice86_generated_label_call_target_1000_1B0D_011B0D, false);
    DefineFunction(cs1, 0x1B23, spice86_generated_label_ret_target_1000_1B23_011B23, false);
    DefineFunction(cs1, 0x1BEC, spice86_generated_label_call_target_1000_1BEC_011BEC, false);
    DefineFunction(cs1, 0x1C18, spice86_generated_label_call_target_1000_1C18_011C18, false);
    DefineFunction(cs1, 0x1C46, spice86_generated_label_call_target_1000_1C46_011C46, false);
    DefineFunction(cs1, 0x1CDA, spice86_generated_label_call_target_1000_1CDA_011CDA, false);
    DefineFunction(cs1, 0x1D10, spice86_generated_label_jump_target_1000_1D10_011D10, false);
    DefineFunction(cs1, 0x1D66, spice86_generated_label_call_target_1000_1D66_011D66, false);
    DefineFunction(cs1, 0x1D9F, spice86_generated_label_call_target_1000_1D9F_011D9F, false);
    DefineFunction(cs1, 0x1DD3, spice86_generated_label_call_target_1000_1DD3_011DD3, false);
    DefineFunction(cs1, 0x1DDA, spice86_generated_label_call_target_1000_1DDA_011DDA, false);
    DefineFunction(cs1, 0x1DFE, spice86_generated_label_call_target_1000_1DFE_011DFE, false);
    DefineFunction(cs1, 0x1E01, spice86_generated_label_call_target_1000_1E01_011E01, false);
    DefineFunction(cs1, 0x1E43, spice86_generated_label_call_target_1000_1E43_011E43, false);
    DefineFunction(cs1, 0x1EA8, split_1000_1EA8_011EA8, false);
    DefineFunction(cs1, 0x1F64, spice86_generated_label_jump_target_1000_1F64_011F64, false);
    DefineFunction(cs1, 0x2098, split_1000_2098_012098, false);
    DefineFunction(cs1, 0x2170, spice86_generated_label_call_target_1000_2170_012170, false);
    DefineFunction(cs1, 0x26DA, split_1000_26DA_0126DA, false);
    DefineFunction(cs1, 0x2A34, split_1000_2A34_012A34, false);
    DefineFunction(cs1, 0x2AAF, spice86_generated_label_call_target_1000_2AAF_012AAF, false);
    DefineFunction(cs1, 0x2B2A, spice86_generated_label_call_target_1000_2B2A_012B2A, false);
    DefineFunction(cs1, 0x2D74, spice86_generated_label_call_target_1000_2D74_012D74, false);
    DefineFunction(cs1, 0x2DB1, spice86_generated_label_call_target_1000_2DB1_012DB1, false);
    DefineFunction(cs1, 0x2DBF, spice86_generated_label_call_target_1000_2DBF_012DBF, false);
    DefineFunction(cs1, 0x2E52, spice86_generated_label_ret_target_1000_2E52_012E52, false);
    DefineFunction(cs1, 0x2E98, spice86_generated_label_call_target_1000_2E98_012E98, false);
    DefineFunction(cs1, 0x2EB2, spice86_generated_label_call_target_1000_2EB2_012EB2, false);
    DefineFunction(cs1, 0x2EFB, spice86_generated_label_call_target_1000_2EFB_012EFB, false);
    DefineFunction(cs1, 0x2FFB, spice86_generated_label_call_target_1000_2FFB_012FFB, false);
    DefineFunction(cs1, 0x3090, spice86_generated_label_call_target_1000_3090_013090, false);
    DefineFunction(cs1, 0x30B9, spice86_generated_label_call_target_1000_30B9_0130B9, false);
    DefineFunction(cs1, 0x3120, spice86_generated_label_call_target_1000_3120_013120, false);
    DefineFunction(cs1, 0x3127, spice86_generated_label_call_target_1000_3127_013127, false);
    DefineFunction(cs1, 0x316E, spice86_generated_label_call_target_1000_316E_01316E, false);
    DefineFunction(cs1, 0x331E, spice86_generated_label_call_target_1000_331E_01331E, false);
    DefineFunction(cs1, 0x3385, spice86_generated_label_call_target_1000_3385_013385, false);
    DefineFunction(cs1, 0x33BE, spice86_generated_label_call_target_1000_33BE_0133BE, false);
    DefineFunction(cs1, 0x33D9, spice86_generated_label_call_target_1000_33D9_0133D9, false);
    DefineFunction(cs1, 0x3406, spice86_generated_label_call_target_1000_3406_013406, false);
    DefineFunction(cs1, 0x342D, spice86_generated_label_call_target_1000_342D_01342D, false);
    DefineFunction(cs1, 0x34A5, spice86_generated_label_call_target_1000_34A5_0134A5, false);
    DefineFunction(cs1, 0x34D0, spice86_generated_label_call_target_1000_34D0_0134D0, false);
    DefineFunction(cs1, 0x3520, spice86_generated_label_call_target_1000_3520_013520, false);
    DefineFunction(cs1, 0x35AD, spice86_generated_label_call_target_1000_35AD_0135AD, false);
    DefineFunction(cs1, 0x36D3, spice86_generated_label_call_target_1000_36D3_0136D3, false);
    DefineFunction(cs1, 0x36EE, spice86_generated_label_call_target_1000_36EE_0136EE, false);
    DefineFunction(cs1, 0x3722, split_1000_3722_013722, false);
    DefineFunction(cs1, 0x37B2, spice86_generated_label_call_target_1000_37B2_0137B2, false);
    DefineFunction(cs1, 0x37B5, spice86_generated_label_ret_target_1000_37B5_0137B5, false);
    DefineFunction(cs1, 0x37EB, spice86_generated_label_call_target_1000_37EB_0137EB, false);
    DefineFunction(cs1, 0x37F4, split_1000_37F4_0137F4, false);
    DefineFunction(cs1, 0x380C, spice86_generated_label_call_target_1000_380C_01380C, false);
    DefineFunction(cs1, 0x388D, spice86_generated_label_ret_target_1000_388D_01388D, false);
    DefineFunction(cs1, 0x38B4, spice86_generated_label_call_target_1000_38B4_0138B4, false);
    DefineFunction(cs1, 0x38E1, spice86_generated_label_call_target_1000_38E1_0138E1, false);
    DefineFunction(cs1, 0x3916, spice86_generated_label_call_target_1000_3916_013916, false);
    DefineFunction(cs1, 0x395C, spice86_generated_label_call_target_1000_395C_01395C, false);
    DefineFunction(cs1, 0x3971, spice86_generated_label_call_target_1000_3971_013971, false);
    DefineFunction(cs1, 0x398C, spice86_generated_label_call_target_1000_398C_01398C, false);
    DefineFunction(cs1, 0x39B9, spice86_generated_label_call_target_1000_39B9_0139B9, false);
    DefineFunction(cs1, 0x39E6, spice86_generated_label_call_target_1000_39E6_0139E6, false);
    DefineFunction(cs1, 0x39EC, split_1000_39EC_0139EC, false);
    DefineFunction(cs1, 0x3A73, spice86_generated_label_call_target_1000_3A73_013A73, false);
    DefineFunction(cs1, 0x3A7C, spice86_generated_label_call_target_1000_3A7C_013A7C, false);
    DefineFunction(cs1, 0x3A95, spice86_generated_label_call_target_1000_3A95_013A95, false);
    DefineFunction(cs1, 0x3AA9, spice86_generated_label_call_target_1000_3AA9_013AA9, false);
    DefineFunction(cs1, 0x3AE9, spice86_generated_label_call_target_1000_3AE9_013AE9, false);
    DefineFunction(cs1, 0x3AF9, spice86_generated_label_call_target_1000_3AF9_013AF9, false);
    DefineFunction(cs1, 0x3B59, spice86_generated_label_call_target_1000_3B59_013B59, false);
    DefineFunction(cs1, 0x3BE9, spice86_generated_label_call_target_1000_3BE9_013BE9, false);
    DefineFunction(cs1, 0x3D12, split_1000_3D12_013D12, false);
    DefineFunction(cs1, 0x3D2F, spice86_generated_label_call_target_1000_3D2F_013D2F, false);
    DefineFunction(cs1, 0x3D83, spice86_generated_label_call_target_1000_3D83_013D83, false);
    DefineFunction(cs1, 0x3DF4, spice86_generated_label_call_target_1000_3DF4_013DF4, false);
    DefineFunction(cs1, 0x3E13, spice86_generated_label_call_target_1000_3E13_013E13, false);
    DefineFunction(cs1, 0x3E80, spice86_generated_label_call_target_1000_3E80_013E80, false);
    DefineFunction(cs1, 0x3EFE, spice86_generated_label_call_target_1000_3EFE_013EFE, false);
    DefineFunction(cs1, 0x3F14, split_1000_3F14_013F14, false);
    DefineFunction(cs1, 0x3F1F, spice86_generated_label_call_target_1000_3F1F_013F1F, false);
    DefineFunction(cs1, 0x3F27, split_1000_3F27_013F27, false);
    DefineFunction(cs1, 0x407E, spice86_generated_label_call_target_1000_407E_01407E, false);
    DefineFunction(cs1, 0x409A, spice86_generated_label_call_target_1000_409A_01409A, false);
    DefineFunction(cs1, 0x40AE, spice86_generated_label_call_target_1000_40AE_0140AE, false);
    DefineFunction(cs1, 0x40C3, spice86_generated_label_call_target_1000_40C3_0140C3, false);
    DefineFunction(cs1, 0x40C9, spice86_generated_label_call_target_1000_40C9_0140C9, false);
    DefineFunction(cs1, 0x40D5, spice86_generated_label_call_target_1000_40D5_0140D5, false);
    DefineFunction(cs1, 0x4182, spice86_generated_label_call_target_1000_4182_014182, false);
    DefineFunction(cs1, 0x41C5, spice86_generated_label_call_target_1000_41C5_0141C5, false);
    DefineFunction(cs1, 0x41E1, spice86_generated_label_call_target_1000_41E1_0141E1, false);
    DefineFunction(cs1, 0x425B, spice86_generated_label_call_target_1000_425B_01425B, false);
    DefineFunction(cs1, 0x42E9, split_1000_42E9_0142E9, false);
    DefineFunction(cs1, 0x439F, spice86_generated_label_call_target_1000_439F_01439F, false);
    DefineFunction(cs1, 0x43E3, spice86_generated_label_call_target_1000_43E3_0143E3, false);
    DefineFunction(cs1, 0x4415, spice86_generated_label_call_target_1000_4415_014415, false);
    DefineFunction(cs1, 0x445D, spice86_generated_label_call_target_1000_445D_01445D, false);
    DefineFunction(cs1, 0x44AB, spice86_generated_label_call_target_1000_44AB_0144AB, false);
    DefineFunction(cs1, 0x450E, spice86_generated_label_call_target_1000_450E_01450E, false);
    DefineFunction(cs1, 0x456C, spice86_generated_label_call_target_1000_456C_01456C, false);
    DefineFunction(cs1, 0x4586, spice86_generated_label_call_target_1000_4586_014586, false);
    DefineFunction(cs1, 0x45DE, spice86_generated_label_call_target_1000_45DE_0145DE, false);
    DefineFunction(cs1, 0x4658, spice86_generated_label_call_target_1000_4658_014658, false);
    DefineFunction(cs1, 0x469B, spice86_generated_label_call_target_1000_469B_01469B, false);
    DefineFunction(cs1, 0x46B5, spice86_generated_label_call_target_1000_46B5_0146B5, false);
    DefineFunction(cs1, 0x4703, split_1000_4703_014703, false);
    DefineFunction(cs1, 0x4795, spice86_generated_label_call_target_1000_4795_014795, false);
    DefineFunction(cs1, 0x4821, spice86_generated_label_call_target_1000_4821_014821, false);
    DefineFunction(cs1, 0x4944, spice86_generated_label_call_target_1000_4944_014944, false);
    DefineFunction(cs1, 0x4988, spice86_generated_label_call_target_1000_4988_014988, false);
    DefineFunction(cs1, 0x49EA, spice86_generated_label_call_target_1000_49EA_0149EA, false);
    DefineFunction(cs1, 0x4A00, spice86_generated_label_call_target_1000_4A00_014A00, false);
    DefineFunction(cs1, 0x4A1A, spice86_generated_label_call_target_1000_4A1A_014A1A, false);
    DefineFunction(cs1, 0x4A5A, spice86_generated_label_call_target_1000_4A5A_014A5A, false);
    DefineFunction(cs1, 0x4AB8, spice86_generated_label_call_target_1000_4AB8_014AB8, false);
    DefineFunction(cs1, 0x4ABE, split_1000_4ABE_014ABE, false);
    DefineFunction(cs1, 0x4AC4, spice86_generated_label_call_target_1000_4AC4_014AC4, false);
    DefineFunction(cs1, 0x4ACA, spice86_generated_label_call_target_1000_4ACA_014ACA, false);
    DefineFunction(cs1, 0x4AEB, split_1000_4AEB_014AEB, false);
    DefineFunction(cs1, 0x4B2B, spice86_generated_label_call_target_1000_4B2B_014B2B, false);
    DefineFunction(cs1, 0x4B3B, spice86_generated_label_call_target_1000_4B3B_014B3B, false);
    DefineFunction(cs1, 0x4D00, spice86_generated_label_call_target_1000_4D00_014D00, false);
    DefineFunction(cs1, 0x4D06, split_1000_4D06_014D06, false);
    DefineFunction(cs1, 0x4E12, spice86_generated_label_call_target_1000_4E12_014E12, false);
    DefineFunction(cs1, 0x4E8E, split_1000_4E8E_014E8E, false);
    DefineFunction(cs1, 0x4EC6, spice86_generated_label_call_target_1000_4EC6_014EC6, false);
    DefineFunction(cs1, 0x4F0C, spice86_generated_label_call_target_1000_4F0C_014F0C, false);
    DefineFunction(cs1, 0x503C, spice86_generated_label_call_target_1000_503C_01503C, false);
    DefineFunction(cs1, 0x50BE, spice86_generated_label_call_target_1000_50BE_0150BE, false);
    DefineFunction(cs1, 0x5119, split_1000_5119_015119, false);
    DefineFunction(cs1, 0x5124, spice86_generated_label_call_target_1000_5124_015124, false);
    DefineFunction(cs1, 0x5133, spice86_generated_label_call_target_1000_5133_015133, false);
    DefineFunction(cs1, 0x514E, spice86_generated_label_call_target_1000_514E_01514E, false);
    DefineFunction(cs1, 0x5198, spice86_generated_label_call_target_1000_5198_015198, false);
    DefineFunction(cs1, 0x51CB, spice86_generated_label_call_target_1000_51CB_0151CB, false);
    DefineFunction(cs1, 0x5206, spice86_generated_label_call_target_1000_5206_015206, false);
    DefineFunction(cs1, 0x5274, spice86_generated_label_call_target_1000_5274_015274, false);
    DefineFunction(cs1, 0x5323, spice86_generated_label_call_target_1000_5323_015323, false);
    DefineFunction(cs1, 0x5575, split_1000_5575_015575, false);
    DefineFunction(cs1, 0x55DD, map_func_ida_1000_55DD_155DD, false);
    DefineFunction(cs1, 0x5982, split_1000_5982_015982, false);
    DefineFunction(cs1, 0x5A02, split_1000_5A02_015A02, false);
    DefineFunction(cs1, 0x5A1A, split_1000_5A1A_015A1A, false);
    DefineFunction(cs1, 0x5A56, spice86_generated_label_call_target_1000_5A56_015A56, false);
    DefineFunction(cs1, 0x5A9A, spice86_generated_label_call_target_1000_5A9A_015A9A, false);
    DefineFunction(cs1, 0x5ADF, spice86_generated_label_call_target_1000_5ADF_015ADF, false);
    DefineFunction(cs1, 0x5B10, split_1000_5B10_015B10, false);
    DefineFunction(cs1, 0x5B5D, spice86_generated_label_call_target_1000_5B5D_015B5D, false);
    DefineFunction(cs1, 0x5B69, spice86_generated_label_call_target_1000_5B69_015B69, false);
    DefineFunction(cs1, 0x5B8D, spice86_generated_label_call_target_1000_5B8D_015B8D, false);
    DefineFunction(cs1, 0x5B93, spice86_generated_label_ret_target_1000_5B93_015B93, false);
    DefineFunction(cs1, 0x5B96, spice86_generated_label_call_target_1000_5B96_015B96, false);
    DefineFunction(cs1, 0x5B99, spice86_generated_label_call_target_1000_5B99_015B99, false);
    DefineFunction(cs1, 0x5BA0, spice86_generated_label_call_target_1000_5BA0_015BA0, false);
    DefineFunction(cs1, 0x5BA8, spice86_generated_label_call_target_1000_5BA8_015BA8, false);
    DefineFunction(cs1, 0x5BB0, spice86_generated_label_call_target_1000_5BB0_015BB0, false);
    DefineFunction(cs1, 0x5C03, spice86_generated_label_call_target_1000_5C03_015C03, false);
    DefineFunction(cs1, 0x5D1D, spice86_generated_label_call_target_1000_5D1D_015D1D, false);
    DefineFunction(cs1, 0x5D36, spice86_generated_label_call_target_1000_5D36_015D36, false);
    DefineFunction(cs1, 0x5D50, split_1000_5D50_015D50, false);
    DefineFunction(cs1, 0x5D6D, split_1000_5D6D_015D6D, false);
    DefineFunction(cs1, 0x5DCE, spice86_generated_label_call_target_1000_5DCE_015DCE, false);
    DefineFunction(cs1, 0x5E42, spice86_generated_label_call_target_1000_5E42_015E42, false);
    DefineFunction(cs1, 0x5E4F, spice86_generated_label_call_target_1000_5E4F_015E4F, false);
    DefineFunction(cs1, 0x5E6D, spice86_generated_label_call_target_1000_5E6D_015E6D, false);
    DefineFunction(cs1, 0x5F79, spice86_generated_label_call_target_1000_5F79_015F79, false);
    DefineFunction(cs1, 0x5F9F, split_1000_5F9F_015F9F, false);
    DefineFunction(cs1, 0x6231, spice86_generated_label_call_target_1000_6231_016231, false);
    DefineFunction(cs1, 0x629D, spice86_generated_label_call_target_1000_629D_01629D, false);
    DefineFunction(cs1, 0x62A6, spice86_generated_label_call_target_1000_62A6_0162A6, false);
    DefineFunction(cs1, 0x62C9, spice86_generated_label_call_target_1000_62C9_0162C9, false);
    DefineFunction(cs1, 0x62D6, spice86_generated_label_call_target_1000_62D6_0162D6, false);
    DefineFunction(cs1, 0x6314, spice86_generated_label_call_target_1000_6314_016314, false);
    DefineFunction(cs1, 0x633B, spice86_generated_label_call_target_1000_633B_01633B, false);
    DefineFunction(cs1, 0x634D, spice86_generated_label_call_target_1000_634D_01634D, false);
    DefineFunction(cs1, 0x636A, spice86_generated_label_call_target_1000_636A_01636A, false);
    DefineFunction(cs1, 0x639A, spice86_generated_label_call_target_1000_639A_01639A, false);
    DefineFunction(cs1, 0x63F0, spice86_generated_label_call_target_1000_63F0_0163F0, false);
    DefineFunction(cs1, 0x642E, spice86_generated_label_call_target_1000_642E_01642E, false);
    DefineFunction(cs1, 0x65B6, split_1000_65B6_0165B6, false);
    DefineFunction(cs1, 0x6603, spice86_generated_label_call_target_1000_6603_016603, false);
    DefineFunction(cs1, 0x6639, spice86_generated_label_call_target_1000_6639_016639, false);
    DefineFunction(cs1, 0x6715, spice86_generated_label_call_target_1000_6715_016715, false);
    DefineFunction(cs1, 0x6757, spice86_generated_label_call_target_1000_6757_016757, false);
    DefineFunction(cs1, 0x6770, spice86_generated_label_call_target_1000_6770_016770, false);
    DefineFunction(cs1, 0x686E, spice86_generated_label_call_target_1000_686E_01686E, false);
    DefineFunction(cs1, 0x6906, spice86_generated_label_call_target_1000_6906_016906, false);
    DefineFunction(cs1, 0x6B34, spice86_generated_label_call_target_1000_6B34_016B34, false);
    DefineFunction(cs1, 0x6C46, spice86_generated_label_call_target_1000_6C46_016C46, false);
    DefineFunction(cs1, 0x6C6F, spice86_generated_label_call_target_1000_6C6F_016C6F, false);
    DefineFunction(cs1, 0x6D19, spice86_generated_label_call_target_1000_6D19_016D19, false);
    DefineFunction(cs1, 0x6EFD, spice86_generated_label_call_target_1000_6EFD_016EFD, false);
    DefineFunction(cs1, 0x71B2, split_1000_71B2_0171B2, false);
    DefineFunction(cs1, 0x739E, map_func_ida_1000_739E_1739E, false);
    DefineFunction(cs1, 0x7429, split_1000_7429_017429, false);
    DefineFunction(cs1, 0x751D, split_1000_751D_01751D, false);
    DefineFunction(cs1, 0x780A, split_1000_780A_01780A, false);
    DefineFunction(cs1, 0x79DB, split_1000_79DB_0179DB, false);
    DefineFunction(cs1, 0x7B1B, spice86_generated_label_call_target_1000_7B1B_017B1B, false);
    DefineFunction(cs1, 0x7B2B, split_1000_7B2B_017B2B, false);
    DefineFunction(cs1, 0x7B36, spice86_generated_label_call_target_1000_7B36_017B36, false);
    DefineFunction(cs1, 0x7C8F, spice86_generated_label_call_target_1000_7C8F_017C8F, false);
    DefineFunction(cs1, 0x7F27, spice86_generated_label_call_target_1000_7F27_017F27, false);
    DefineFunction(cs1, 0x80DF, split_1000_80DF_0180DF, false);
    DefineFunction(cs1, 0x8770, spice86_generated_label_call_target_1000_8770_018770, false);
    DefineFunction(cs1, 0x878C, spice86_generated_label_call_target_1000_878C_01878C, false);
    DefineFunction(cs1, 0x8888, split_1000_8888_018888, false);
    DefineFunction(cs1, 0x88F1, spice86_generated_label_call_target_1000_88F1_0188F1, false);
    DefineFunction(cs1, 0x8944, spice86_generated_label_call_target_1000_8944_018944, false);
    DefineFunction(cs1, 0x8B10, split_1000_8B10_018B10, false);
    DefineFunction(cs1, 0x8C0F, split_1000_8C0F_018C0F, false);
    DefineFunction(cs1, 0x8C8A, spice86_generated_label_call_target_1000_8C8A_018C8A, false);
    DefineFunction(cs1, 0x8CCD, spice86_generated_label_call_target_1000_8CCD_018CCD, false);
    DefineFunction(cs1, 0x8DF0, spice86_generated_label_call_target_1000_8DF0_018DF0, false);
    DefineFunction(cs1, 0x8E16, spice86_generated_label_call_target_1000_8E16_018E16, false);
    DefineFunction(cs1, 0x8E9E, spice86_generated_label_call_target_1000_8E9E_018E9E, false);
    DefineFunction(cs1, 0x8ED3, spice86_generated_label_call_target_1000_8ED3_018ED3, false);
    DefineFunction(cs1, 0x8F28, spice86_generated_label_call_target_1000_8F28_018F28, false);
    DefineFunction(cs1, 0x9025, spice86_generated_label_call_target_1000_9025_019025, false);
    DefineFunction(cs1, 0x9046, spice86_generated_label_call_target_1000_9046_019046, false);
    DefineFunction(cs1, 0x908C, spice86_generated_label_call_target_1000_908C_01908C, false);
    DefineFunction(cs1, 0x90BD, spice86_generated_label_call_target_1000_90BD_0190BD, false);
    DefineFunction(cs1, 0x9123, spice86_generated_label_call_target_1000_9123_019123, false);
    DefineFunction(cs1, 0x9197, spice86_generated_label_call_target_1000_9197_019197, false);
    DefineFunction(cs1, 0x91A0, spice86_generated_label_call_target_1000_91A0_0191A0, false);
    DefineFunction(cs1, 0x920F, spice86_generated_label_call_target_1000_920F_01920F, false);
    DefineFunction(cs1, 0x9215, spice86_generated_label_call_target_1000_9215_019215, false);
    DefineFunction(cs1, 0x9285, spice86_generated_label_call_target_1000_9285_019285, false);
    DefineFunction(cs1, 0x92C9, spice86_generated_label_call_target_1000_92C9_0192C9, false);
    DefineFunction(cs1, 0x92EB, split_1000_92EB_0192EB, false);
    DefineFunction(cs1, 0x9381, split_1000_9381_019381, false);
    DefineFunction(cs1, 0x93DF, spice86_generated_label_call_target_1000_93DF_0193DF, false);
    DefineFunction(cs1, 0x945B, split_1000_945B_01945B, false);
    DefineFunction(cs1, 0x94F3, spice86_generated_label_call_target_1000_94F3_0194F3, false);
    DefineFunction(cs1, 0x961A, split_1000_961A_01961A, false);
    DefineFunction(cs1, 0x9673, split_1000_9673_019673, false);
    DefineFunction(cs1, 0x96B5, spice86_generated_label_call_target_1000_96B5_0196B5, false);
    DefineFunction(cs1, 0x96F1, spice86_generated_label_call_target_1000_96F1_0196F1, false);
    DefineFunction(cs1, 0x978E, spice86_generated_label_call_target_1000_978E_01978E, false);
    DefineFunction(cs1, 0x97CF, spice86_generated_label_call_target_1000_97CF_0197CF, false);
    DefineFunction(cs1, 0x9849, split_1000_9849_019849, false);
    DefineFunction(cs1, 0x98B2, spice86_generated_label_call_target_1000_98B2_0198B2, false);
    DefineFunction(cs1, 0x98E6, spice86_generated_label_call_target_1000_98E6_0198E6, false);
    DefineFunction(cs1, 0x98F5, spice86_generated_label_call_target_1000_98F5_0198F5, false);
    DefineFunction(cs1, 0x9901, Set479ETo0_1000_9901_19901, false);
    DefineFunction(cs1, 0x9908, spice86_generated_label_call_target_1000_9908_019908, false);
    DefineFunction(cs1, 0x994F, spice86_generated_label_call_target_1000_994F_01994F, false);
    DefineFunction(cs1, 0x996C, spice86_generated_label_call_target_1000_996C_01996C, false);
    DefineFunction(cs1, 0x9985, spice86_generated_label_call_target_1000_9985_019985, false);
    DefineFunction(cs1, 0x99BE, spice86_generated_label_call_target_1000_99BE_0199BE, false);
    DefineFunction(cs1, 0x9B49, spice86_generated_label_call_target_1000_9B49_019B49, false);
    DefineFunction(cs1, 0x9B8B, spice86_generated_label_call_target_1000_9B8B_019B8B, false);
    DefineFunction(cs1, 0x9BAC, spice86_generated_label_call_target_1000_9BAC_019BAC, false);
    DefineFunction(cs1, 0x9BB1, spice86_generated_label_call_target_1000_9BB1_019BB1, false);
    DefineFunction(cs1, 0x9BCC, split_1000_9BCC_019BCC, false);
    DefineFunction(cs1, 0x9BEE, spice86_generated_label_call_target_1000_9BEE_019BEE, false);
    DefineFunction(cs1, 0x9C2D, spice86_generated_label_call_target_1000_9C2D_019C2D, false);
    DefineFunction(cs1, 0x9C54, spice86_generated_label_call_target_1000_9C54_019C54, false);
    DefineFunction(cs1, 0x9CC6, spice86_generated_label_call_target_1000_9CC6_019CC6, false);
    DefineFunction(cs1, 0x9D16, spice86_generated_label_call_target_1000_9D16_019D16, false);
    DefineFunction(cs1, 0x9ED5, split_1000_9ED5_019ED5, false);
    DefineFunction(cs1, 0x9EFD, spice86_generated_label_call_target_1000_9EFD_019EFD, false);
    DefineFunction(cs1, 0x9F40, spice86_generated_label_call_target_1000_9F40_019F40, false);
    DefineFunction(cs1, 0x9F8B, split_1000_9F8B_019F8B, false);
    DefineFunction(cs1, 0x9F9C, split_1000_9F9C_019F9C, false);
    DefineFunction(cs1, 0xA026, split_1000_A026_01A026, false);
    DefineFunction(cs1, 0xA0F1, spice86_generated_label_call_target_1000_A0F1_01A0F1, false);
    DefineFunction(cs1, 0xA1C4, spice86_generated_label_call_target_1000_A1C4_01A1C4, false);
    DefineFunction(cs1, 0xA1E2, spice86_generated_label_call_target_1000_A1E2_01A1E2, false);
    DefineFunction(cs1, 0xA1E8, IncUnknown47A8_1000_A1E8_1A1E8, false);
    DefineFunction(cs1, 0xA30B, spice86_generated_label_call_target_1000_A30B_01A30B, false);
    DefineFunction(cs1, 0xA334, spice86_generated_label_call_target_1000_A334_01A334, false);
    DefineFunction(cs1, 0xA396, spice86_generated_label_call_target_1000_A396_01A396, false);
    DefineFunction(cs1, 0xA3F9, split_1000_A3F9_01A3F9, false);
    DefineFunction(cs1, 0xA42C, spice86_generated_label_call_target_1000_A42C_01A42C, false);
    DefineFunction(cs1, 0xA44C, spice86_generated_label_call_target_1000_A44C_01A44C, false);
    DefineFunction(cs1, 0xA453, spice86_generated_label_call_target_1000_A453_01A453, false);
    DefineFunction(cs1, 0xA45C, spice86_generated_label_call_target_1000_A45C_01A45C, false);
    DefineFunction(cs1, 0xA465, spice86_generated_label_call_target_1000_A465_01A465, false);
    DefineFunction(cs1, 0xA47D, spice86_generated_label_call_target_1000_A47D_01A47D, false);
    DefineFunction(cs1, 0xA4C6, spice86_generated_label_call_target_1000_A4C6_01A4C6, false);
    DefineFunction(cs1, 0xA502, spice86_generated_label_call_target_1000_A502_01A502, false);
    DefineFunction(cs1, 0xA540, split_1000_A540_01A540, false);
    DefineFunction(cs1, 0xA541, spice86_generated_label_call_target_1000_A541_01A541, false);
    DefineFunction(cs1, 0xA553, split_1000_A553_01A553, false);
    DefineFunction(cs1, 0xA594, spice86_generated_label_call_target_1000_A594_01A594, false);
    DefineFunction(cs1, 0xA5AA, spice86_generated_label_call_target_1000_A5AA_01A5AA, false);
    DefineFunction(cs1, 0xA5B0, split_1000_A5B0_01A5B0, false);
    DefineFunction(cs1, 0xA5DF, spice86_generated_label_call_target_1000_A5DF_01A5DF, false);
    DefineFunction(cs1, 0xA637, spice86_generated_label_call_target_1000_A637_01A637, false);
    DefineFunction(cs1, 0xA650, spice86_generated_label_call_target_1000_A650_01A650, false);
    DefineFunction(cs1, 0xA672, spice86_generated_label_call_target_1000_A672_01A672, false);
    DefineFunction(cs1, 0xA685, spice86_generated_label_call_target_1000_A685_01A685, false);
    DefineFunction(cs1, 0xA69E, split_1000_A69E_01A69E, false);
    DefineFunction(cs1, 0xA69F, spice86_generated_label_call_target_1000_A69F_01A69F, false);
    DefineFunction(cs1, 0xA6B2, spice86_generated_label_call_target_1000_A6B2_01A6B2, false);
    DefineFunction(cs1, 0xA6CB, split_1000_A6CB_01A6CB, false);
    DefineFunction(cs1, 0xA6CC, spice86_generated_label_call_target_1000_A6CC_01A6CC, false);
    DefineFunction(cs1, 0xA75C, split_1000_A75C_01A75C, false);
    DefineFunction(cs1, 0xA789, split_1000_A789_01A789, false);
    DefineFunction(cs1, 0xA7A5, spice86_generated_label_call_target_1000_A7A5_01A7A5, false);
    DefineFunction(cs1, 0xA7C2, spice86_generated_label_call_target_1000_A7C2_01A7C2, false);
    DefineFunction(cs1, 0xA83F, spice86_generated_label_call_target_1000_A83F_01A83F, false);
    DefineFunction(cs1, 0xA87E, spice86_generated_label_call_target_1000_A87E_01A87E, false);
    DefineFunction(cs1, 0xA8B1, spice86_generated_label_call_target_1000_A8B1_01A8B1, false);
    DefineFunction(cs1, 0xA8BC, spice86_generated_label_call_target_1000_A8BC_01A8BC, false);
    DefineFunction(cs1, 0xA90B, open_res_file_ida_1000_A90B_1A90B, false);
    DefineFunction(cs1, 0xA93F, read_audio_file_ida_1000_A93F_1A93F, false);
    DefineFunction(cs1, 0xA9A1, spice86_generated_label_call_target_1000_A9A1_01A9A1, false);
    DefineFunction(cs1, 0xA9B8, split_1000_A9B8_01A9B8, false);
    DefineFunction(cs1, 0xA9B9, split_1000_A9B9_01A9B9, false);
    DefineFunction(cs1, 0xA9E7, pcm_test_audio_done_ida_1000_A9E7_1A9E7, false);
    DefineFunction(cs1, 0xAA0F, spice86_generated_label_call_target_1000_AA0F_01AA0F, false);
    DefineFunction(cs1, 0xAA70, transfer_sd_block_qq_ida_1000_AA70_1AA70, false);
    DefineFunction(cs1, 0xAA96, spice86_generated_label_call_target_1000_AA96_01AA96, false);
    DefineFunction(cs1, 0xAB15, spice86_generated_label_call_target_1000_AB15_01AB15, false);
    DefineFunction(cs1, 0xAB45, spice86_generated_label_call_target_1000_AB45_01AB45, false);
    DefineFunction(cs1, 0xAB4F, spice86_generated_label_call_target_1000_AB4F_01AB4F, false);
    DefineFunction(cs1, 0xABA3, check_res_file_open_ida_1000_ABA3_1ABA3, false);
    DefineFunction(cs1, 0xABA9, spice86_generated_label_call_target_1000_ABA9_01ABA9, false);
    DefineFunction(cs1, 0xABCC, spice86_generated_label_call_target_1000_ABCC_01ABCC, false);
    DefineFunction(cs1, 0xABD5, spice86_generated_label_call_target_1000_ABD5_01ABD5, false);
    DefineFunction(cs1, 0xABE9, open_voc_resource_ida_1000_ABE9_1ABE9, false);
    DefineFunction(cs1, 0xAC14, spice86_generated_label_call_target_1000_AC14_01AC14, false);
    DefineFunction(cs1, 0xAC30, spice86_generated_label_call_target_1000_AC30_01AC30, false);
    DefineFunction(cs1, 0xAC3A, spice86_generated_label_call_target_1000_AC3A_01AC3A, false);
    DefineFunction(cs1, 0xACE6, spice86_generated_label_call_target_1000_ACE6_01ACE6, false);
    DefineFunction(cs1, 0xAD43, spice86_generated_label_call_target_1000_AD43_01AD43, false);
    DefineFunction(cs1, 0xAD57, spice86_generated_label_call_target_1000_AD57_01AD57, false);
    DefineFunction(cs1, 0xAD5E, spice86_generated_label_call_target_1000_AD5E_01AD5E, false);
    DefineFunction(cs1, 0xAD95, split_1000_AD95_01AD95, false);
    DefineFunction(cs1, 0xADBE, spice86_generated_label_call_target_1000_ADBE_01ADBE, false);
    DefineFunction(cs1, 0xADED, split_1000_ADED_01ADED, false);
    DefineFunction(cs1, 0xAE04, spice86_generated_label_call_target_1000_AE04_01AE04, false);
    DefineFunction(cs1, 0xAE28, spice86_generated_label_call_target_1000_AE28_01AE28, false);
    DefineFunction(cs1, 0xAE2F, spice86_generated_label_call_target_1000_AE2F_01AE2F, false);
    DefineFunction(cs1, 0xAE3F, spice86_generated_label_call_target_1000_AE3F_01AE3F, false);
    DefineFunction(cs1, 0xAE54, spice86_generated_label_call_target_1000_AE54_01AE54, false);
    DefineFunction(cs1, 0xAE62, spice86_generated_label_call_target_1000_AE62_01AE62, false);
    DefineFunction(cs1, 0xAEB7, spice86_generated_label_call_target_1000_AEB7_01AEB7, false);
    DefineFunction(cs1, 0xAEC6, spice86_generated_label_call_target_1000_AEC6_01AEC6, false);
    DefineFunction(cs1, 0xB17A, spice86_generated_label_call_target_1000_B17A_01B17A, false);
    DefineFunction(cs1, 0xB2B3, spice86_generated_label_call_target_1000_B2B3_01B2B3, false);
    DefineFunction(cs1, 0xB2B9, spice86_generated_label_call_target_1000_B2B9_01B2B9, false);
    DefineFunction(cs1, 0xB2BE, spice86_generated_label_call_target_1000_B2BE_01B2BE, false);
    DefineFunction(cs1, 0xB2C4, spice86_generated_label_call_target_1000_B2C4_01B2C4, false);
    DefineFunction(cs1, 0xB30F, spice86_generated_label_call_target_1000_B30F_01B30F, false);
    DefineFunction(cs1, 0xB389, spice86_generated_label_call_target_1000_B389_01B389, false);
    DefineFunction(cs1, 0xB427, spice86_generated_label_call_target_1000_B427_01B427, false);
    DefineFunction(cs1, 0xB4EA, spice86_generated_label_call_target_1000_B4EA_01B4EA, false);
    DefineFunction(cs1, 0xB532, spice86_generated_label_call_target_1000_B532_01B532, false);
    DefineFunction(cs1, 0xB53B, spice86_generated_label_call_target_1000_B53B_01B53B, false);
    DefineFunction(cs1, 0xB56C, spice86_generated_label_call_target_1000_B56C_01B56C, false);
    DefineFunction(cs1, 0xB58B, spice86_generated_label_call_target_1000_B58B_01B58B, false);
    DefineFunction(cs1, 0xB5A0, spice86_generated_label_call_target_1000_B5A0_01B5A0, false);
    DefineFunction(cs1, 0xB5C5, spice86_generated_label_call_target_1000_B5C5_01B5C5, false);
    DefineFunction(cs1, 0xB647, spice86_generated_label_call_target_1000_B647_01B647, false);
    DefineFunction(cs1, 0xB683, spice86_generated_label_call_target_1000_B683_01B683, false);
    DefineFunction(cs1, 0xB6C3, spice86_generated_label_call_target_1000_B6C3_01B6C3, false);
    DefineFunction(cs1, 0xB7D2, spice86_generated_label_call_target_1000_B7D2_01B7D2, false);
    DefineFunction(cs1, 0xB827, spice86_generated_label_call_target_1000_B827_01B827, false);
    DefineFunction(cs1, 0xB84A, spice86_generated_label_call_target_1000_B84A_01B84A, false);
    DefineFunction(cs1, 0xB87E, spice86_generated_label_call_target_1000_B87E_01B87E, false);
    DefineFunction(cs1, 0xB8A7, spice86_generated_label_call_target_1000_B8A7_01B8A7, false);
    DefineFunction(cs1, 0xB8C6, spice86_generated_label_call_target_1000_B8C6_01B8C6, false);
    DefineFunction(cs1, 0xB8F3, spice86_generated_label_call_target_1000_B8F3_01B8F3, false);
    DefineFunction(cs1, 0xB930, spice86_generated_label_call_target_1000_B930_01B930, false);
    DefineFunction(cs1, 0xB941, spice86_generated_label_call_target_1000_B941_01B941, false);
    DefineFunction(cs1, 0xB977, spice86_generated_label_call_target_1000_B977_01B977, false);
    DefineFunction(cs1, 0xB98B, spice86_generated_label_call_target_1000_B98B_01B98B, false);
    DefineFunction(cs1, 0xB9AE, spice86_generated_label_call_target_1000_B9AE_01B9AE, false);
    DefineFunction(cs1, 0xB9E0, spice86_generated_label_call_target_1000_B9E0_01B9E0, false);
    DefineFunction(cs1, 0xB9F6, spice86_generated_label_call_target_1000_B9F6_01B9F6, false);
    DefineFunction(cs1, 0xBA15, spice86_generated_label_call_target_1000_BA15_01BA15, false);
    DefineFunction(cs1, 0xBA75, spice86_generated_label_call_target_1000_BA75_01BA75, false);
    DefineFunction(cs1, 0xBA9E, spice86_generated_label_call_target_1000_BA9E_01BA9E, false);
    DefineFunction(cs1, 0xBAF2, spice86_generated_label_call_target_1000_BAF2_01BAF2, false);
    DefineFunction(cs1, 0xBC0C, spice86_generated_label_call_target_1000_BC0C_01BC0C, false);
    DefineFunction(cs1, 0xBC1F, spice86_generated_label_call_target_1000_BC1F_01BC1F, false);
    DefineFunction(cs1, 0xBC4E, spice86_generated_label_call_target_1000_BC4E_01BC4E, false);
    DefineFunction(cs1, 0xBC99, spice86_generated_label_call_target_1000_BC99_01BC99, false);
    DefineFunction(cs1, 0xBD00, spice86_generated_label_call_target_1000_BD00_01BD00, false);
    DefineFunction(cs1, 0xBDFA, spice86_generated_label_call_target_1000_BDFA_01BDFA, false);
    DefineFunction(cs1, 0xBE1D, spice86_generated_label_call_target_1000_BE1D_01BE1D, false);
    DefineFunction(cs1, 0xBE57, spice86_generated_label_ret_target_1000_BE57_01BE57, false);
    DefineFunction(cs1, 0xBED7, spice86_generated_label_call_target_1000_BED7_01BED7, false);
    DefineFunction(cs1, 0xBF26, spice86_generated_label_call_target_1000_BF26_01BF26, false);
    DefineFunction(cs1, 0xBF61, spice86_generated_label_call_target_1000_BF61_01BF61, false);
    DefineFunction(cs1, 0xBF73, spice86_generated_label_call_target_1000_BF73_01BF73, false);
    DefineFunction(cs1, 0xBFA7, spice86_generated_label_call_target_1000_BFA7_01BFA7, false);
    DefineFunction(cs1, 0xBFE3, spice86_generated_label_call_target_1000_BFE3_01BFE3, false);
    DefineFunction(cs1, 0xC02E, spice86_generated_label_call_target_1000_C02E_01C02E, false);
    DefineFunction(cs1, 0xC07C, spice86_generated_label_call_target_1000_C07C_01C07C, false);
    DefineFunction(cs1, 0xC085, spice86_generated_label_call_target_1000_C085_01C085, false);
    DefineFunction(cs1, 0xC08E, spice86_generated_label_call_target_1000_C08E_01C08E, false);
    DefineFunction(cs1, 0xC097, spice86_generated_label_call_target_1000_C097_01C097, false);
    DefineFunction(cs1, 0xC0AD, spice86_generated_label_call_target_1000_C0AD_01C0AD, false);
    DefineFunction(cs1, 0xC0D5, spice86_generated_label_call_target_1000_C0D5_01C0D5, false);
    DefineFunction(cs1, 0xC0E8, split_1000_C0E8_01C0E8, false);
    DefineFunction(cs1, 0xC0F4, spice86_generated_label_call_target_1000_C0F4_01C0F4, false);
    DefineFunction(cs1, 0xC108, spice86_generated_label_call_target_1000_C108_01C108, false);
    DefineFunction(cs1, 0xC137, spice86_generated_label_call_target_1000_C137_01C137, false);
    DefineFunction(cs1, 0xC13B, spice86_generated_label_call_target_1000_C13B_01C13B, false);
    DefineFunction(cs1, 0xC13E, spice86_generated_label_call_target_1000_C13E_01C13E, false);
    DefineFunction(cs1, 0xC1AA, spice86_generated_label_call_target_1000_C1AA_01C1AA, false);
    DefineFunction(cs1, 0xC1BA, spice86_generated_label_call_target_1000_C1BA_01C1BA, false);
    DefineFunction(cs1, 0xC1F4, spice86_generated_label_call_target_1000_C1F4_01C1F4, false);
    DefineFunction(cs1, 0xC21B, spice86_generated_label_call_target_1000_C21B_01C21B, false);
    DefineFunction(cs1, 0xC22F, spice86_generated_label_call_target_1000_C22F_01C22F, false);
    DefineFunction(cs1, 0xC26A, split_1000_C26A_01C26A, false);
    DefineFunction(cs1, 0xC26B, split_1000_C26B_01C26B, false);
    DefineFunction(cs1, 0xC2A1, spice86_generated_label_call_target_1000_C2A1_01C2A1, false);
    DefineFunction(cs1, 0xC2F2, split_1000_C2F2_01C2F2, false);
    DefineFunction(cs1, 0xC2FD, spice86_generated_label_call_target_1000_C2FD_01C2FD, false);
    DefineFunction(cs1, 0xC305, spice86_generated_label_call_target_1000_C305_01C305, false);
    DefineFunction(cs1, 0xC30D, spice86_generated_label_call_target_1000_C30D_01C30D, false);
    DefineFunction(cs1, 0xC343, spice86_generated_label_call_target_1000_C343_01C343, false);
    DefineFunction(cs1, 0xC412, spice86_generated_label_call_target_1000_C412_01C412, false);
    DefineFunction(cs1, 0xC432, spice86_generated_label_call_target_1000_C432_01C432, false);
    DefineFunction(cs1, 0xC43E, spice86_generated_label_call_target_1000_C43E_01C43E, false);
    DefineFunction(cs1, 0xC443, spice86_generated_label_call_target_1000_C443_01C443, false);
    DefineFunction(cs1, 0xC446, spice86_generated_label_call_target_1000_C446_01C446, false);
    DefineFunction(cs1, 0xC46F, spice86_generated_label_call_target_1000_C46F_01C46F, false);
    DefineFunction(cs1, 0xC474, spice86_generated_label_call_target_1000_C474_01C474, false);
    DefineFunction(cs1, 0xC477, spice86_generated_label_call_target_1000_C477_01C477, false);
    DefineFunction(cs1, 0xC49A, gfx_copy_framebuffer_to_screen_ida_1000_C49A_1C49A, false);
    DefineFunction(cs1, 0xC4AA, spice86_generated_label_call_target_1000_C4AA_01C4AA, false);
    DefineFunction(cs1, 0xC4CD, spice86_generated_label_call_target_1000_C4CD_01C4CD, false);
    DefineFunction(cs1, 0xC4DD, spice86_generated_label_call_target_1000_C4DD_01C4DD, false);
    DefineFunction(cs1, 0xC4ED, spice86_generated_label_call_target_1000_C4ED_01C4ED, false);
    DefineFunction(cs1, 0xC4F0, spice86_generated_label_call_target_1000_C4F0_01C4F0, false);
    DefineFunction(cs1, 0xC4FB, spice86_generated_label_call_target_1000_C4FB_01C4FB, false);
    DefineFunction(cs1, 0xC51E, spice86_generated_label_call_target_1000_C51E_01C51E, false);
    DefineFunction(cs1, 0xC53E, spice86_generated_label_call_target_1000_C53E_01C53E, false);
    DefineFunction(cs1, 0xC551, spice86_generated_label_call_target_1000_C551_01C551, false);
    DefineFunction(cs1, 0xC560, spice86_generated_label_call_target_1000_C560_01C560, false);
    DefineFunction(cs1, 0xC6AD, spice86_generated_label_call_target_1000_C6AD_01C6AD, false);
    DefineFunction(cs1, 0xC85B, spice86_generated_label_call_target_1000_C85B_01C85B, false);
    DefineFunction(cs1, 0xC921, spice86_generated_label_call_target_1000_C921_01C921, false);
    DefineFunction(cs1, 0xC92B, spice86_generated_label_call_target_1000_C92B_01C92B, false);
    DefineFunction(cs1, 0xC93C, spice86_generated_label_ret_target_1000_C93C_01C93C, false);
    DefineFunction(cs1, 0xC9E8, hnm_do_frame_skippable_ida_1000_C9E8_1C9E8, false);
    DefineFunction(cs1, 0xC9F4, spice86_generated_label_call_target_1000_C9F4_01C9F4, false);
    DefineFunction(cs1, 0xCA01, spice86_generated_label_call_target_1000_CA01_01CA01, false);
    DefineFunction(cs1, 0xCA1B, spice86_generated_label_call_target_1000_CA1B_01CA1B, false);
    DefineFunction(cs1, 0xCA59, spice86_generated_label_call_target_1000_CA59_01CA59, false);
    DefineFunction(cs1, 0xCA60, spice86_generated_label_call_target_1000_CA60_01CA60, false);
    DefineFunction(cs1, 0xCA8F, spice86_generated_label_ret_target_1000_CA8F_01CA8F, false);
    DefineFunction(cs1, 0xCA9A, split_1000_CA9A_01CA9A, false);
    DefineFunction(cs1, 0xCAA0, spice86_generated_label_call_target_1000_CAA0_01CAA0, false);
    DefineFunction(cs1, 0xCAD4, spice86_generated_label_call_target_1000_CAD4_01CAD4, false);
    DefineFunction(cs1, 0xCB1A, spice86_generated_label_ret_target_1000_CB1A_01CB1A, false);
    DefineFunction(cs1, 0xCC0C, spice86_generated_label_call_target_1000_CC0C_01CC0C, false);
    DefineFunction(cs1, 0xCC2B, spice86_generated_label_call_target_1000_CC2B_01CC2B, false);
    DefineFunction(cs1, 0xCC4E, spice86_generated_label_call_target_1000_CC4E_01CC4E, false);
    DefineFunction(cs1, 0xCC85, spice86_generated_label_call_target_1000_CC85_01CC85, false);
    DefineFunction(cs1, 0xCC96, spice86_generated_label_call_target_1000_CC96_01CC96, false);
    DefineFunction(cs1, 0xCCF4, spice86_generated_label_call_target_1000_CCF4_01CCF4, false);
    DefineFunction(cs1, 0xCD8F, spice86_generated_label_call_target_1000_CD8F_01CD8F, false);
    DefineFunction(cs1, 0xCDA0, spice86_generated_label_call_target_1000_CDA0_01CDA0, false);
    DefineFunction(cs1, 0xCDBF, spice86_generated_label_call_target_1000_CDBF_01CDBF, false);
    DefineFunction(cs1, 0xCE01, spice86_generated_label_call_target_1000_CE01_01CE01, false);
    DefineFunction(cs1, 0xCE1A, spice86_generated_label_call_target_1000_CE1A_01CE1A, false);
    DefineFunction(cs1, 0xCE3B, hnm_handle_pal_chunk_ida_1000_CE3B_1CE3B, false);
    DefineFunction(cs1, 0xCE53, spice86_generated_label_call_target_1000_CE53_01CE53, false);
    DefineFunction(cs1, 0xCE6C, spice86_generated_label_call_target_1000_CE6C_01CE6C, false);
    DefineFunction(cs1, 0xCEB0, spice86_generated_label_call_target_1000_CEB0_01CEB0, false);
    DefineFunction(cs1, 0xCEC9, spice86_generated_label_call_target_1000_CEC9_01CEC9, false);
    DefineFunction(cs1, 0xCEFC, load_IRULn_HSQ_ida_1000_CEFC_1CEFC, false);
    DefineFunction(cs1, 0xCF1B, play_IRULx_HSQ_ida_1000_CF1B_1CF1B, false);
    DefineFunction(cs1, 0xCF4B, IRULx_draw_or_clear_subtitle_ida_1000_CF4B_1CF4B, false);
    DefineFunction(cs1, 0xCF70, spice86_generated_label_call_target_1000_CF70_01CF70, false);
    DefineFunction(cs1, 0xCFA0, spice86_generated_label_call_target_1000_CFA0_01CFA0, false);
    DefineFunction(cs1, 0xCFB9, spice86_generated_label_call_target_1000_CFB9_01CFB9, false);
    DefineFunction(cs1, 0xD00F, spice86_generated_label_call_target_1000_D00F_01D00F, false);
    DefineFunction(cs1, 0xD03C, spice86_generated_label_call_target_1000_D03C_01D03C, false);
    DefineFunction(cs1, 0xD04E, spice86_generated_label_call_target_1000_D04E_01D04E, false);
    DefineFunction(cs1, 0xD05F, spice86_generated_label_call_target_1000_D05F_01D05F, false);
    DefineFunction(cs1, 0xD068, spice86_generated_label_call_target_1000_D068_01D068, false);
    DefineFunction(cs1, 0xD075, spice86_generated_label_call_target_1000_D075_01D075, false);
    DefineFunction(cs1, 0xD082, SetFontToBook_1000_D082_1D082, false);
    DefineFunction(cs1, 0xD096, spice86_generated_label_call_target_1000_D096_01D096, false);
    DefineFunction(cs1, 0xD12F, spice86_generated_label_call_target_1000_D12F_01D12F, false);
    DefineFunction(cs1, 0xD194, spice86_generated_label_call_target_1000_D194_01D194, false);
    DefineFunction(cs1, 0xD19B, spice86_generated_label_ret_target_1000_D19B_01D19B, false);
    DefineFunction(cs1, 0xD1A6, spice86_generated_label_call_target_1000_D1A6_01D1A6, false);
    DefineFunction(cs1, 0xD1BB, spice86_generated_label_call_target_1000_D1BB_01D1BB, false);
    DefineFunction(cs1, 0xD1EF, spice86_generated_label_call_target_1000_D1EF_01D1EF, false);
    DefineFunction(cs1, 0xD1F2, spice86_generated_label_call_target_1000_D1F2_01D1F2, false);
    DefineFunction(cs1, 0xD200, spice86_generated_label_call_target_1000_D200_01D200, false);
    DefineFunction(cs1, 0xD239, spice86_generated_label_call_target_1000_D239_01D239, false);
    DefineFunction(cs1, 0xD23D, spice86_generated_label_call_target_1000_D23D_01D23D, false);
    DefineFunction(cs1, 0xD280, spice86_generated_label_call_target_1000_D280_01D280, false);
    DefineFunction(cs1, 0xD2BD, spice86_generated_label_call_target_1000_D2BD_01D2BD, false);
    DefineFunction(cs1, 0xD2E2, split_1000_D2E2_01D2E2, false);
    DefineFunction(cs1, 0xD2EA, spice86_generated_label_call_target_1000_D2EA_01D2EA, false);
    DefineFunction(cs1, 0xD316, spice86_generated_label_call_target_1000_D316_01D316, false);
    DefineFunction(cs1, 0xD323, spice86_generated_label_call_target_1000_D323_01D323, false);
    DefineFunction(cs1, 0xD32F, split_1000_D32F_01D32F, false);
    DefineFunction(cs1, 0xD338, spice86_generated_label_call_target_1000_D338_01D338, false);
    DefineFunction(cs1, 0xD33A, spice86_generated_label_call_target_1000_D33A_01D33A, false);
    DefineFunction(cs1, 0xD36D, spice86_generated_label_call_target_1000_D36D_01D36D, false);
    DefineFunction(cs1, 0xD410, split_1000_D410_01D410, false);
    DefineFunction(cs1, 0xD41B, spice86_generated_label_call_target_1000_D41B_01D41B, false);
    DefineFunction(cs1, 0xD42F, spice86_generated_label_call_target_1000_D42F_01D42F, false);
    DefineFunction(cs1, 0xD434, spice86_generated_label_call_target_1000_D434_01D434, false);
    DefineFunction(cs1, 0xD439, spice86_generated_label_call_target_1000_D439_01D439, false);
    DefineFunction(cs1, 0xD43E, spice86_generated_label_call_target_1000_D43E_01D43E, false);
    DefineFunction(cs1, 0xD443, spice86_generated_label_call_target_1000_D443_01D443, false);
    DefineFunction(cs1, 0xD445, split_1000_D445_01D445, false);
    DefineFunction(cs1, 0xD454, spice86_generated_label_call_target_1000_D454_01D454, false);
    DefineFunction(cs1, 0xD48A, spice86_generated_label_call_target_1000_D48A_01D48A, false);
    DefineFunction(cs1, 0xD50F, spice86_generated_label_call_target_1000_D50F_01D50F, false);
    DefineFunction(cs1, 0xD61D, spice86_generated_label_call_target_1000_D61D_01D61D, false);
    DefineFunction(cs1, 0xD65A, spice86_generated_label_call_target_1000_D65A_01D65A, false);
    DefineFunction(cs1, 0xD694, spice86_generated_label_call_target_1000_D694_01D694, false);
    DefineFunction(cs1, 0xD6B7, spice86_generated_label_call_target_1000_D6B7_01D6B7, false);
    DefineFunction(cs1, 0xD6FE, spice86_generated_label_call_target_1000_D6FE_01D6FE, false);
    DefineFunction(cs1, 0xD712, split_1000_D712_01D712, false);
    DefineFunction(cs1, 0xD717, spice86_generated_label_call_target_1000_D717_01D717, false);
    DefineFunction(cs1, 0xD72B, spice86_generated_label_call_target_1000_D72B_01D72B, false);
    DefineFunction(cs1, 0xD741, spice86_generated_label_call_target_1000_D741_01D741, false);
    DefineFunction(cs1, 0xD75A, spice86_generated_label_call_target_1000_D75A_01D75A, false);
    DefineFunction(cs1, 0xD763, spice86_generated_label_ret_target_1000_D763_01D763, false);
    DefineFunction(cs1, 0xD792, spice86_generated_label_call_target_1000_D792_01D792, false);
    DefineFunction(cs1, 0xD795, spice86_generated_label_call_target_1000_D795_01D795, false);
    DefineFunction(cs1, 0xD7B2, spice86_generated_label_call_target_1000_D7B2_01D7B2, false);
    DefineFunction(cs1, 0xD7B7, spice86_generated_label_call_target_1000_D7B7_01D7B7, false);
    DefineFunction(cs1, 0xD815, spice86_generated_label_call_target_1000_D815_01D815, false);
    DefineFunction(cs1, 0xD917, spice86_generated_label_call_target_1000_D917_01D917, false);
    DefineFunction(cs1, 0xD918, split_1000_D918_01D918, false);
    DefineFunction(cs1, 0xD95B, spice86_generated_label_call_target_1000_D95B_01D95B, false);
    DefineFunction(cs1, 0xD95E, spice86_generated_label_call_target_1000_D95E_01D95E, false);
    DefineFunction(cs1, 0xD9D2, spice86_generated_label_call_target_1000_D9D2_01D9D2, false);
    DefineFunction(cs1, 0xDA25, spice86_generated_label_call_target_1000_DA25_01DA25, false);
    DefineFunction(cs1, 0xDA53, spice86_generated_label_call_target_1000_DA53_01DA53, false);
    DefineFunction(cs1, 0xDA5F, spice86_generated_label_call_target_1000_DA5F_01DA5F, false);
    DefineFunction(cs1, 0xDAA3, spice86_generated_label_call_target_1000_DAA3_01DAA3, false);
    DefineFunction(cs1, 0xDAAA, spice86_generated_label_call_target_1000_DAAA_01DAAA, false);
    DefineFunction(cs1, 0xDAAF, split_1000_DAAF_01DAAF, false);
    DefineFunction(cs1, 0xDAE3, spice86_generated_label_call_target_1000_DAE3_01DAE3, false);
    DefineFunction(cs1, 0xDB03, spice86_generated_label_call_target_1000_DB03_01DB03, false);
    DefineFunction(cs1, 0xDB14, spice86_generated_label_call_target_1000_DB14_01DB14, false);
    DefineFunction(cs1, 0xDB44, spice86_generated_label_call_target_1000_DB44_01DB44, false);
    DefineFunction(cs1, 0xDB4C, spice86_generated_label_call_target_1000_DB4C_01DB4C, false);
    DefineFunction(cs1, 0xDB67, spice86_generated_label_call_target_1000_DB67_01DB67, false);
    DefineFunction(cs1, 0xDB74, spice86_generated_label_call_target_1000_DB74_01DB74, false);
    DefineFunction(cs1, 0xDBB2, spice86_generated_label_call_target_1000_DBB2_01DBB2, false);
    DefineFunction(cs1, 0xDBCA, split_1000_DBCA_01DBCA, false);
    DefineFunction(cs1, 0xDBE3, split_1000_DBE3_01DBE3, false);
    DefineFunction(cs1, 0xDBEC, spice86_generated_label_ret_target_1000_DBEC_01DBEC, false);
    DefineFunction(cs1, 0xDC20, spice86_generated_label_call_target_1000_DC20_01DC20, false);
    DefineFunction(cs1, 0xDC6A, spice86_generated_label_call_target_1000_DC6A_01DC6A, false);
    DefineFunction(cs1, 0xDCE0, read_game_port_ida_1000_DCE0_1DCE0, false);
    DefineFunction(cs1, 0xDD5A, get_key_hit_ida_1000_DD5A_1DD5A, false);
    DefineFunction(cs1, 0xDD63, spice86_generated_label_call_target_1000_DD63_01DD63, false);
    DefineFunction(cs1, 0xDDE7, split_1000_DDE7_01DDE7, false);
    DefineFunction(cs1, 0xDE07, split_1000_DE07_01DE07, false);
    DefineFunction(cs1, 0xDE4E, spice86_generated_label_call_target_1000_DE4E_01DE4E, false);
    DefineFunction(cs1, 0xDE54, spice86_generated_label_call_target_1000_DE54_01DE54, false);
    DefineFunction(cs1, 0xDE7B, spice86_generated_label_call_target_1000_DE7B_01DE7B, false);
    DefineFunction(cs1, 0xDF1E, spice86_generated_label_call_target_1000_DF1E_01DF1E, false);
    DefineFunction(cs1, 0xDFB7, split_1000_DFB7_01DFB7, false);
    DefineFunction(cs1, 0xE1D1, split_1000_E1D1_01E1D1, false);
    DefineFunction(cs1, 0xE26F, spice86_generated_label_call_target_1000_E26F_01E26F, false);
    DefineFunction(cs1, 0xE270, spice86_generated_label_call_target_1000_E270_01E270, false);
    DefineFunction(cs1, 0xE283, spice86_generated_label_call_target_1000_E283_01E283, false);
    DefineFunction(cs1, 0xE290, spice86_generated_label_call_target_1000_E290_01E290, false);
    DefineFunction(cs1, 0xE297, split_1000_E297_01E297, false);
    DefineFunction(cs1, 0xE2DB, spice86_generated_label_call_target_1000_E2DB_01E2DB, false);
    DefineFunction(cs1, 0xE2E3, spice86_generated_label_call_target_1000_E2E3_01E2E3, false);
    DefineFunction(cs1, 0xE31C, spice86_generated_label_call_target_1000_E31C_01E31C, false);
    DefineFunction(cs1, 0xE353, spice86_generated_label_call_target_1000_E353_01E353, false);
    DefineFunction(cs1, 0xE387, spice86_generated_label_call_target_1000_E387_01E387, false);
    DefineFunction(cs1, 0xE3A0, spice86_generated_label_call_target_1000_E3A0_01E3A0, false);
    DefineFunction(cs1, 0xE3B7, spice86_generated_label_call_target_1000_E3B7_01E3B7, false);
    DefineFunction(cs1, 0xE3CC, spice86_generated_label_call_target_1000_E3CC_01E3CC, false);
    DefineFunction(cs1, 0xE3DF, spice86_generated_label_call_target_1000_E3DF_01E3DF, false);
    DefineFunction(cs1, 0xE4AD, spice86_generated_label_call_target_1000_E4AD_01E4AD, false);
    DefineFunction(cs1, 0xE56B, spice86_generated_label_call_target_1000_E56B_01E56B, false);
    DefineFunction(cs1, 0xE57B, spice86_generated_label_call_target_1000_E57B_01E57B, false);
    DefineFunction(cs1, 0xE594, spice86_generated_label_call_target_1000_E594_01E594, false);
    DefineFunction(cs1, 0xE675, spice86_generated_label_call_target_1000_E675_01E675, false);
    DefineFunction(cs1, 0xE741, spice86_generated_label_call_target_1000_E741_01E741, false);
    DefineFunction(cs1, 0xE75B, spice86_generated_label_call_target_1000_E75B_01E75B, false);
    DefineFunction(cs1, 0xE76A, spice86_generated_label_call_target_1000_E76A_01E76A, false);
    DefineFunction(cs1, 0xE826, spice86_generated_label_call_target_1000_E826_01E826, false);
    DefineFunction(cs1, 0xE851, spice86_generated_label_call_target_1000_E851_01E851, false);
    DefineFunction(cs1, 0xE85C, spice86_generated_label_call_target_1000_E85C_01E85C, false);
    DefineFunction(cs1, 0xE8A8, spice86_generated_label_call_target_1000_E8A8_01E8A8, false);
    DefineFunction(cs1, 0xE8B8, get_pit_timer_value_ida_1000_E8B8_1E8B8, false);
    DefineFunction(cs1, 0xE8D5, spice86_generated_label_call_target_1000_E8D5_01E8D5, false);
    DefineFunction(cs1, 0xE913, spice86_generated_label_call_target_1000_E913_01E913, false);
    DefineFunction(cs1, 0xE97A, spice86_generated_label_call_target_1000_E97A_01E97A, false);
    DefineFunction(cs1, 0xE9F4, mouse_func_uncalled_ida_1000_E9F4_1E9F4, false);
    DefineFunction(cs1, 0xEA32, initialize_joystick_ida_1000_EA32_1EA32, false);
    DefineFunction(cs1, 0xEA7B, spice86_generated_label_call_target_1000_EA7B_01EA7B, false);
    DefineFunction(cs1, 0xEAB7, memory_func_qq_ida_1000_EAB7_1EAB7, false);
    DefineFunction(cs1, 0xEC46, call_memory_func_2_ida_1000_EC46_1EC46, false);
    DefineFunction(cs1, 0xEC59, call_memory_func_1_ida_1000_EC59_1EC59, false);
    DefineFunction(cs1, 0xEC9C, xms_memory_func_1_ida_1000_EC9C_1EC9C, false);
    DefineFunction(cs1, 0xECEC, xms_memory_func_1_ida_1000_ECEC_1ECEC, false);
    DefineFunction(cs1, 0xED40, get_ems_emm_handle_ida_1000_ED40_1ED40, false);
    DefineFunction(cs1, 0xED45, call_ems_func_ida_1000_ED45_1ED45, false);
    DefineFunction(cs1, 0xEDB9, map_ems_for_midi_audio_ida_1000_EDB9_1EDB9, false);
    DefineFunction(cs1, 0xEE02, ems_memory_func_2_ida_1000_EE02_1EE02, false);
    DefineFunction(cs1, 0xEE46, ems_memory_func_1_ida_1000_EE46_1EE46, false);
    DefineFunction(cs1, 0xEEA0, initialize_himem_sys_ida_1000_EEA0_1EEA0, false);
    DefineFunction(cs1, 0xEF22, call_xms_driver_func_ida_1000_EF22_1EF22, false);
    DefineFunction(cs1, 0xEF2B, call_xms_func_on_block_ida_1000_EF2B_1EF2B, false);
    DefineFunction(cs1, 0xEF32, xms_move_memory_ida_1000_EF32_1EF32, false);
    DefineFunction(cs1, 0xEF6A, spice86_generated_label_jump_target_1000_EF6A_01EF6A, false);
    DefineFunction(cs1, 0xEFBA, spice86_generated_label_call_target_1000_EFBA_01EFBA, false);
    DefineFunction(cs1, 0xEFD5, split_1000_EFD5_01EFD5, false);
    DefineFunction(cs1, 0xEFE1, split_1000_EFE1_01EFE1, false);
    DefineFunction(cs1, 0xEFE7, interrupt_handler_0x9_1000_EFE7_1EFE7, false);
    DefineFunction(cs1, 0xF05C, reset_keyboard_ida_1000_F05C_1F05C, false);
    DefineFunction(cs1, 0xF08E, clear_keyboard_array_ida_1000_F08E_1F08E, false);
    DefineFunction(cs1, 0xF0A0, spice86_generated_label_call_target_1000_F0A0_01F0A0, false);
    DefineFunction(cs1, 0xF0B9, spice86_generated_label_call_target_1000_F0B9_01F0B9, false);
    DefineFunction(cs1, 0xF0D6, spice86_generated_label_call_target_1000_F0D6_01F0D6, false);
    DefineFunction(cs1, 0xF0F6, spice86_generated_label_call_target_1000_F0F6_01F0F6, false);
    DefineFunction(cs1, 0xF0FF, spice86_generated_label_call_target_1000_F0FF_01F0FF, false);
    DefineFunction(cs1, 0xF11C, spice86_generated_label_call_target_1000_F11C_01F11C, false);
    DefineFunction(cs1, 0xF130, split_1000_F130_01F130, false);
    DefineFunction(cs1, 0xF131, split_1000_F131_01F131, false);
    DefineFunction(cs1, 0xF13F, spice86_generated_label_call_target_1000_F13F_01F13F, false);
    DefineFunction(cs1, 0xF1FB, spice86_generated_label_call_target_1000_F1FB_01F1FB, false);
    DefineFunction(cs1, 0xF229, spice86_generated_label_call_target_1000_F229_01F229, false);
    DefineFunction(cs1, 0xF244, spice86_generated_label_call_target_1000_F244_01F244, false);
    DefineFunction(cs1, 0xF255, open_nonres_file_ida_1000_F255_1F255, false);
    DefineFunction(cs1, 0xF260, read_ffff_to_esdi_and_close_ida_1000_F260_1F260, false);
    DefineFunction(cs1, 0xF27C, split_1000_F27C_01F27C, false);
    DefineFunction(cs1, 0xF2A7, spice86_generated_label_call_target_1000_F2A7_01F2A7, false);
    DefineFunction(cs1, 0xF2D6, spice86_generated_label_call_target_1000_F2D6_01F2D6, false);
    DefineFunction(cs1, 0xF2EA, spice86_generated_label_call_target_1000_F2EA_01F2EA, false);
    DefineFunction(cs1, 0xF2FC, spice86_generated_label_call_target_1000_F2FC_01F2FC, false);
    DefineFunction(cs1, 0xF314, spice86_generated_label_call_target_1000_F314_01F314, false);
    DefineFunction(cs1, 0xF3A7, spice86_generated_label_call_target_1000_F3A7_01F3A7, false);
    DefineFunction(cs1, 0xF3D3, split_1000_F3D3_01F3D3, false);
    DefineFunction(cs1, 0xF403, spice86_generated_label_call_target_1000_F403_01F403, false);
    DefineFunction(cs1, 0xF40D, split_1000_F40D_01F40D, false);
    DefineFunction(cs1, 0xF435, split_1000_F435_01F435, false);
    // 0x334B
    DefineFunction(cs2, 0x100, spice86_generated_label_call_target_334B_0100_0335B0, false);
    DefineFunction(cs2, 0x103, spice86_generated_label_call_target_334B_0103_0335B3, false);
    DefineFunction(cs2, 0x106, spice86_generated_label_call_target_334B_0106_0335B6, false);
    DefineFunction(cs2, 0x109, spice86_generated_label_call_target_334B_0109_0335B9, false);
    DefineFunction(cs2, 0x10C, spice86_generated_label_call_target_334B_010C_0335BC, false);
    DefineFunction(cs2, 0x115, spice86_generated_label_call_target_334B_0115_0335C5, false);
    DefineFunction(cs2, 0x118, spice86_generated_label_call_target_334B_0118_0335C8, false);
    DefineFunction(cs2, 0x11B, spice86_generated_label_call_target_334B_011B_0335CB, false);
    DefineFunction(cs2, 0x11E, spice86_generated_label_call_target_334B_011E_0335CE, false);
    DefineFunction(cs2, 0x121, spice86_generated_label_call_target_334B_0121_0335D1, false);
    DefineFunction(cs2, 0x124, spice86_generated_label_call_target_334B_0124_0335D4, false);
    DefineFunction(cs2, 0x12A, spice86_generated_label_call_target_334B_012A_0335DA, false);
    DefineFunction(cs2, 0x12D, spice86_generated_label_call_target_334B_012D_0335DD, false);
    DefineFunction(cs2, 0x130, spice86_generated_label_call_target_334B_0130_0335E0, false);
    DefineFunction(cs2, 0x133, VgaFunc17CopyframebufferExplodeAndCenter_334B_0133_335E3, false);
    DefineFunction(cs2, 0x136, spice86_generated_label_call_target_334B_0136_0335E6, false);
    DefineFunction(cs2, 0x139, spice86_generated_label_call_target_334B_0139_0335E9, false);
    DefineFunction(cs2, 0x13C, spice86_generated_label_call_target_334B_013C_0335EC, false);
    DefineFunction(cs2, 0x13F, VgaFunc21SetPixel_334B_013F_335EF, false);
    DefineFunction(cs2, 0x142, spice86_generated_label_call_target_334B_0142_0335F2, false);
    DefineFunction(cs2, 0x145, spice86_generated_label_call_target_334B_0145_0335F5, false);
    DefineFunction(cs2, 0x14B, spice86_generated_label_call_target_334B_014B_0335FB, false);
    DefineFunction(cs2, 0x14E, spice86_generated_label_call_target_334B_014E_0335FE, false);
    DefineFunction(cs2, 0x151, spice86_generated_label_call_target_334B_0151_033601, false);
    DefineFunction(cs2, 0x154, spice86_generated_label_call_target_334B_0154_033604, false);
    DefineFunction(cs2, 0x157, spice86_generated_label_call_target_334B_0157_033607, false);
    DefineFunction(cs2, 0x15A, spice86_generated_label_call_target_334B_015A_03360A, false);
    DefineFunction(cs2, 0x160, spice86_generated_label_call_target_334B_0160_033610, false);
    DefineFunction(cs2, 0x163, spice86_generated_label_call_target_334B_0163_033613, false);
    DefineFunction(cs2, 0x169, spice86_generated_label_call_target_334B_0169_033619, false);
    DefineFunction(cs2, 0x16C, spice86_generated_label_call_target_334B_016C_03361C, false);
    DefineFunction(cs2, 0x16F, spice86_generated_label_call_target_334B_016F_03361F, false);
    DefineFunction(cs2, 0x172, spice86_generated_label_call_target_334B_0172_033622, false);
    DefineFunction(cs2, 0x17B, spice86_generated_label_call_target_334B_017B_03362B, false);
    DefineFunction(cs2, 0x967, spice86_generated_label_jump_target_334B_0967_033E17, false);
    DefineFunction(cs2, 0x975, spice86_generated_label_jump_target_334B_0975_033E25, false);
    DefineFunction(cs2, 0x9B8, spice86_generated_label_call_target_334B_09B8_033E68, false);
    DefineFunction(cs2, 0x9D9, not_observed_334B_09D9_033E89, false);
    DefineFunction(cs2, 0x9E2, spice86_generated_label_jump_target_334B_09E2_033E92, false);
    DefineFunction(cs2, 0xA21, spice86_generated_label_call_target_334B_0A21_033ED1, false);
    DefineFunction(cs2, 0xA40, spice86_generated_label_jump_target_334B_0A40_033EF0, false);
    DefineFunction(cs2, 0xA58, spice86_generated_label_call_target_334B_0A58_033F08, false);
    DefineFunction(cs2, 0xA68, spice86_generated_label_jump_target_334B_0A68_033F18, false);
    DefineFunction(cs2, 0xAD7, spice86_generated_label_jump_target_334B_0AD7_033F87, false);
    DefineFunction(cs2, 0xB0C, spice86_generated_label_call_target_334B_0B0C_033FBC, false);
    DefineFunction(cs2, 0xB5F, split_334B_0B5F_03400F, false);
    DefineFunction(cs2, 0xB68, spice86_generated_label_call_target_334B_0B68_034018, false);
    DefineFunction(cs2, 0xC06, not_observed_334B_0C06_0340B6, false);
    DefineFunction(cs2, 0xC10, spice86_generated_label_call_target_334B_0C10_0340C0, false);
    DefineFunction(cs2, 0xC2D, not_observed_334B_0C2D_0340DD, false);
    DefineFunction(cs2, 0xC3B, split_334B_0C3B_0340EB, false);
    DefineFunction(cs2, 0xD2F, split_334B_0D2F_0341DF, false);
    DefineFunction(cs2, 0xD3E, split_334B_0D3E_0341EE, false);
    DefineFunction(cs2, 0xD85, split_334B_0D85_034235, false);
    DefineFunction(cs2, 0x100A, split_334B_100A_0344BA, false);
    DefineFunction(cs2, 0x10E2, split_334B_10E2_034592, false);
    DefineFunction(cs2, 0x1151, split_334B_1151_034601, false);
    DefineFunction(cs2, 0x11FF, split_334B_11FF_0346AF, false);
    DefineFunction(cs2, 0x1272, split_334B_1272_034722, false);
    DefineFunction(cs2, 0x12B7, split_334B_12B7_034767, false);
    DefineFunction(cs2, 0x14FD, split_334B_14FD_0349AD, false);
    DefineFunction(cs2, 0x158A, split_334B_158A_034A3A, false);
    DefineFunction(cs2, 0x16A7, split_334B_16A7_034B57, false);
    DefineFunction(cs2, 0x17E8, split_334B_17E8_034C98, false);
    DefineFunction(cs2, 0x1825, split_334B_1825_034CD5, false);
    DefineFunction(cs2, 0x1888, spice86_generated_label_jump_target_334B_1888_034D38, false);
    DefineFunction(cs2, 0x1940, not_observed_334B_1940_034DF0, false);
    DefineFunction(cs2, 0x1979, spice86_generated_label_jump_target_334B_1979_034E29, false);
    DefineFunction(cs2, 0x197B, spice86_generated_label_jump_target_334B_197B_034E2B, false);
    DefineFunction(cs2, 0x19F7, not_observed_334B_19F7_034EA7, false);
    DefineFunction(cs2, 0x1A07, spice86_generated_label_jump_target_334B_1A07_034EB7, false);
    DefineFunction(cs2, 0x1ADC, spice86_generated_label_call_target_334B_1ADC_034F8C, false);
    DefineFunction(cs2, 0x1B7C, spice86_generated_label_call_target_334B_1B7C_03502C, false);
    DefineFunction(cs2, 0x1B8C, not_observed_334B_1B8C_03503C, false);
    DefineFunction(cs2, 0x1B8E, spice86_generated_label_call_target_334B_1B8E_03503E, false);
    DefineFunction(cs2, 0x1BCA, not_observed_334B_1BCA_03507A, false);
    DefineFunction(cs2, 0x1BE7, spice86_generated_label_jump_target_334B_1BE7_035097, false);
    DefineFunction(cs2, 0x1BF5, spice86_generated_label_jump_target_334B_1BF5_0350A5, false);
    DefineFunction(cs2, 0x1C46, spice86_generated_label_jump_target_334B_1C46_0350F6, false);
    DefineFunction(cs2, 0x1C76, spice86_generated_label_jump_target_334B_1C76_035126, false);
    DefineFunction(cs2, 0x1CB6, spice86_generated_label_jump_target_334B_1CB6_035166, false);
    DefineFunction(cs2, 0x1D07, spice86_generated_label_call_target_334B_1D07_0351B7, false);
    DefineFunction(cs2, 0x1D5A, spice86_generated_label_call_target_334B_1D5A_03520A, false);
    DefineFunction(cs2, 0x1D85, split_334B_1D85_035235, false);
    DefineFunction(cs2, 0x1DC2, split_334B_1DC2_035272, false);
    DefineFunction(cs2, 0x1F4C, spice86_generated_label_jump_target_334B_1F4C_0353FC, false);
    DefineFunction(cs2, 0x2025, spice86_generated_label_call_target_334B_2025_0354D5, false);
    DefineFunction(cs2, 0x2079, split_334B_2079_035529, false);
    DefineFunction(cs2, 0x209E, split_334B_209E_03554E, false);
    DefineFunction(cs2, 0x2123, spice86_generated_label_call_target_334B_2123_0355D3, false);
    DefineFunction(cs2, 0x2153, spice86_generated_label_call_target_334B_2153_035603, false);
    DefineFunction(cs2, 0x2183, split_334B_2183_035633, false);
    DefineFunction(cs2, 0x2343, spice86_generated_label_call_target_334B_2343_0357F3, false);
    DefineFunction(cs2, 0x2396, spice86_generated_label_call_target_334B_2396_035846, false);
    DefineFunction(cs2, 0x23D7, spice86_generated_label_call_target_334B_23D7_035887, false);
    DefineFunction(cs2, 0x23EB, spice86_generated_label_jump_target_334B_23EB_03589B, false);
    DefineFunction(cs2, 0x2413, spice86_generated_label_call_target_334B_2413_0358C3, false);
    DefineFunction(cs2, 0x253D, spice86_generated_label_call_target_334B_253D_0359ED, false);
    DefineFunction(cs2, 0x2572, spice86_generated_label_call_target_334B_2572_035A22, false);
    DefineFunction(cs2, 0x2596, spice86_generated_label_call_target_334B_2596_035A46, false);
    DefineFunction(cs2, 0x25E7, spice86_generated_label_jump_target_334B_25E7_035A97, false);
    DefineFunction(cs2, 0x261D, spice86_generated_label_call_target_334B_261D_035ACD, false);
    DefineFunction(cs2, 0x26E3, spice86_generated_label_call_target_334B_26E3_035B93, false);
    DefineFunction(cs2, 0x2AB0, spice86_generated_label_call_target_334B_2AB0_035F60, false);
    DefineFunction(cs2, 0x3200, spice86_generated_label_jump_target_334B_3200_0366B0, false);
    DefineFunction(cs2, 0x32C1, spice86_generated_label_call_target_334B_32C1_036771, false);
    DefineFunction(cs2, 0x35C8, spice86_generated_label_call_target_334B_35C8_036A78, false);
    DefineFunction(cs2, 0x39E9, not_observed_334B_39E9_036E99, false);
    DefineFunction(cs2, 0x3A14, spice86_generated_label_jump_target_334B_3A14_036EC4, false);
    // 0x5635
    DefineFunction(cs3, 0x100, spice86_generated_label_call_target_5635_0100_056450, false);
    DefineFunction(cs3, 0x103, spice86_generated_label_call_target_5635_0103_056453, false);
    DefineFunction(cs3, 0x109, spice86_generated_label_call_target_5635_0109_056459, false);
    DefineFunction(cs3, 0x10C, ClearAL_5635_010C_5645C, false);
    DefineFunction(cs3, 0x115, spice86_generated_label_call_target_5635_0115_056465, false);
    DefineFunction(cs3, 0x17B, not_observed_5635_017B_0564CB, false);
    DefineFunction(cs3, 0x182, PcSpeakerActivationWithALCleanup_5635_0182_564D2, false);
    DefineFunction(cs3, 0x185, not_observed_5635_0185_0564D5, false);
    DefineFunction(cs3, 0x188, PcSpeakerActivation_5635_0188_564D8, false);
    // 0x563E
    DefineFunction(cs4, 0x100, spice86_generated_label_call_target_563E_0100_0564E0, false);
    DefineFunction(cs4, 0x103, spice86_generated_label_call_target_563E_0103_0564E3, false);
    DefineFunction(cs4, 0x106, spice86_generated_label_call_target_563E_0106_0564E6, false);
    DefineFunction(cs4, 0x109, spice86_generated_label_call_target_563E_0109_0564E9, false);
    DefineFunction(cs4, 0x10C, spice86_generated_label_call_target_563E_010C_0564EC, false);
    DefineFunction(cs4, 0x10F, spice86_generated_label_call_target_563E_010F_0564EF, false);
    DefineFunction(cs4, 0x112, spice86_generated_label_call_target_563E_0112_0564F2, false);
    DefineFunction(cs4, 0x182, PcSpeakerActivationWithALCleanup_563E_0182_56562, false);
    DefineFunction(cs4, 0x188, PcSpeakerActivation_563E_0188_56568, false);
    DefineFunction(cs4, 0x1A8, not_observed_563E_01A8_056588, false);
    DefineFunction(cs4, 0x1CB, not_observed_563E_01CB_0565AB, false);
    DefineFunction(cs4, 0x1E1, spice86_generated_label_call_target_563E_01E1_0565C1, false);
    DefineFunction(cs4, 0x1EE, spice86_generated_label_jump_target_563E_01EE_0565CE, false);
    DefineFunction(cs4, 0x22B, not_observed_563E_022B_05660B, false);
    DefineFunction(cs4, 0x23B, spice86_generated_label_jump_target_563E_023B_05661B, false);
    DefineFunction(cs4, 0x250, spice86_generated_label_jump_target_563E_0250_056630, false);
    DefineFunction(cs4, 0x2AE, spice86_generated_label_call_target_563E_02AE_05668E, false);
    DefineFunction(cs4, 0x2E0, not_observed_563E_02E0_0566C0, false);
    DefineFunction(cs4, 0x30F, spice86_generated_label_jump_target_563E_030F_0566EF, false);
    DefineFunction(cs4, 0x349, spice86_generated_label_call_target_563E_0349_056729, false);
    DefineFunction(cs4, 0x36F, spice86_generated_label_call_target_563E_036F_05674F, false);
    DefineFunction(cs4, 0x3C7, spice86_generated_label_call_target_563E_03C7_0567A7, false);
    DefineFunction(cs4, 0x41C, spice86_generated_label_call_target_563E_041C_0567FC, false);
    DefineFunction(cs4, 0x422, spice86_generated_label_call_target_563E_0422_056802, false);
    DefineFunction(cs4, 0x428, spice86_generated_label_call_target_563E_0428_056808, false);
    DefineFunction(cs4, 0x432, spice86_generated_label_call_target_563E_0432_056812, false);
    DefineFunction(cs4, 0x453, spice86_generated_label_call_target_563E_0453_056833, false);
    DefineFunction(cs4, 0x45D, spice86_generated_label_call_target_563E_045D_05683D, false);
    DefineFunction(cs4, 0x49B, spice86_generated_label_call_target_563E_049B_05687B, false);
    DefineFunction(cs4, 0x4D7, spice86_generated_label_call_target_563E_04D7_0568B7, false);
    DefineFunction(cs4, 0x52F, spice86_generated_label_call_target_563E_052F_05690F, false);
    DefineFunction(cs4, 0x559, not_observed_563E_0559_056939, false);
    DefineFunction(cs4, 0x564, spice86_generated_label_call_target_563E_0564_056944, false);
    DefineFunction(cs4, 0x592, split_563E_0592_056972, false);
    DefineFunction(cs4, 0x5A6, spice86_generated_label_call_target_563E_05A6_056986, false);
    DefineFunction(cs4, 0x5BF, spice86_generated_label_call_target_563E_05BF_05699F, false);
    // 0xF000
    DefineFunction(cs5, 0x0, spice86_generated_label_jump_target_F000_0000_0F0000, false);
    DefineFunction(cs5, 0x4, provided_interrupt_handler_0x9_F000_0004_F0004, false);
    DefineFunction(cs5, 0x8, provided_interrupt_handler_0x10_F000_0008_F0008, false);
    DefineFunction(cs5, 0xC, provided_interrupt_handler_0x11_F000_000C_F000C, false);
    DefineFunction(cs5, 0x10, provided_interrupt_handler_0x15_F000_0010_F0010, false);
    DefineFunction(cs5, 0x14, provided_interrupt_handler_0x16_F000_0014_F0014, false);
    DefineFunction(cs5, 0x18, provided_interrupt_handler_0x1A_F000_0018_F0018, false);
    DefineFunction(cs5, 0x1C, provided_interrupt_handler_0x20_F000_001C_F001C, false);
    DefineFunction(cs5, 0x20, provided_interrupt_handler_0x21_F000_0020_F0020, false);
    DefineFunction(cs5, 0x24, provided_interrupt_handler_0x33_F000_0024_F0024, false);
  }
  
  
  public void DetectCodeRewrites() {
    DefineExecutableArea(0x10000, 0x100A7);
    DefineExecutableArea(0x100B0, 0x1015E);
    DefineExecutableArea(0x10169, 0x1020B);
    DefineExecutableArea(0x1021C, 0x102C0);
    DefineExecutableArea(0x10309, 0x10336);
    DefineExecutableArea(0x10579, 0x10685);
    DefineExecutableArea(0x1069E, 0x106CD);
    DefineExecutableArea(0x108F0, 0x10949);
    DefineExecutableArea(0x109EF, 0x109F4);
    DefineExecutableArea(0x10A3E, 0x10A43);
    DefineExecutableArea(0x10B21, 0x10B44);
    DefineExecutableArea(0x10F66, 0x10F66);
    DefineExecutableArea(0x10FA7, 0x10FB1);
    DefineExecutableArea(0x10FD9, 0x1100A);
    DefineExecutableArea(0x1121F, 0x11242);
    DefineExecutableArea(0x1127C, 0x1128E);
    DefineExecutableArea(0x116FC, 0x1176A);
    DefineExecutableArea(0x11797, 0x118ED);
    DefineExecutableArea(0x11A0F, 0x11D34);
    DefineExecutableArea(0x11D66, 0x11DB2);
    DefineExecutableArea(0x11DD3, 0x11DD3);
    DefineExecutableArea(0x11DDA, 0x11EA0);
    DefineExecutableArea(0x11EA8, 0x11EA8);
    DefineExecutableArea(0x11F64, 0x12016);
    DefineExecutableArea(0x12098, 0x12164);
    DefineExecutableArea(0x12170, 0x121F9);
    DefineExecutableArea(0x126DA, 0x1272E);
    DefineExecutableArea(0x12A34, 0x12A50);
    DefineExecutableArea(0x12AAF, 0x12AD7);
    DefineExecutableArea(0x12B2A, 0x12C91);
    DefineExecutableArea(0x12D74, 0x131F5);
    DefineExecutableArea(0x1331E, 0x13489);
    DefineExecutableArea(0x134A5, 0x1366E);
    DefineExecutableArea(0x136D3, 0x137AC);
    DefineExecutableArea(0x137B2, 0x13909);
    DefineExecutableArea(0x13916, 0x13F19);
    DefineExecutableArea(0x13F1F, 0x13F23);
    DefineExecutableArea(0x13F27, 0x140E5);
    DefineExecutableArea(0x14181, 0x14284);
    DefineExecutableArea(0x142E9, 0x14376);
    DefineExecutableArea(0x1439F, 0x14889);
    DefineExecutableArea(0x14944, 0x14979);
    DefineExecutableArea(0x14988, 0x149D3);
    DefineExecutableArea(0x149EA, 0x14AAC);
    DefineExecutableArea(0x14AB8, 0x14ACF);
    DefineExecutableArea(0x14AEB, 0x14B5E);
    DefineExecutableArea(0x14D00, 0x14D56);
    DefineExecutableArea(0x14E12, 0x14E8C);
    DefineExecutableArea(0x14E8E, 0x14F08);
    DefineExecutableArea(0x14F0C, 0x14FFA);
    DefineExecutableArea(0x1503C, 0x15081);
    DefineExecutableArea(0x150BE, 0x150C3);
    DefineExecutableArea(0x15119, 0x15343);
    DefineExecutableArea(0x15575, 0x1557A);
    DefineExecutableArea(0x155DD, 0x15604);
    DefineExecutableArea(0x15982, 0x159C0);
    DefineExecutableArea(0x15A02, 0x15A02);
    DefineExecutableArea(0x15A1A, 0x15A3C);
    DefineExecutableArea(0x15A56, 0x15B04);
    DefineExecutableArea(0x15B10, 0x15B1D);
    DefineExecutableArea(0x15B5D, 0x15BEA);
    DefineExecutableArea(0x15C03, 0x15C75);
    DefineExecutableArea(0x15D1D, 0x15D43);
    DefineExecutableArea(0x15D50, 0x15E6A);
    DefineExecutableArea(0x15E6D, 0x15ECF);
    DefineExecutableArea(0x15F79, 0x15FAF);
    DefineExecutableArea(0x16231, 0x16251);
    DefineExecutableArea(0x1629D, 0x162F1);
    DefineExecutableArea(0x16314, 0x163C6);
    DefineExecutableArea(0x163F0, 0x16446);
    DefineExecutableArea(0x165B6, 0x1661C);
    DefineExecutableArea(0x16639, 0x1666F);
    DefineExecutableArea(0x16715, 0x1676D);
    DefineExecutableArea(0x16770, 0x168D1);
    DefineExecutableArea(0x16906, 0x16916);
    DefineExecutableArea(0x16B34, 0x16B89);
    DefineExecutableArea(0x16C46, 0x16CFB);
    DefineExecutableArea(0x16D19, 0x16D5E);
    DefineExecutableArea(0x16EFD, 0x16F47);
    DefineExecutableArea(0x171B2, 0x171BB);
    DefineExecutableArea(0x1739E, 0x17418);
    DefineExecutableArea(0x17429, 0x174B5);
    DefineExecutableArea(0x1751D, 0x17551);
    DefineExecutableArea(0x1780A, 0x17846);
    DefineExecutableArea(0x179DB, 0x179ED);
    DefineExecutableArea(0x17B1B, 0x17B57);
    DefineExecutableArea(0x17C8F, 0x17CBA);
    DefineExecutableArea(0x17F27, 0x17F5E);
    DefineExecutableArea(0x180DF, 0x1813D);
    DefineExecutableArea(0x18770, 0x1881E);
    DefineExecutableArea(0x18888, 0x18A22);
    DefineExecutableArea(0x18B10, 0x18C0D);
    DefineExecutableArea(0x18C0F, 0x192F1);
    DefineExecutableArea(0x19381, 0x1941C);
    DefineExecutableArea(0x1945B, 0x19532);
    DefineExecutableArea(0x1961A, 0x1961A);
    DefineExecutableArea(0x19673, 0x196D7);
    DefineExecutableArea(0x196F1, 0x19718);
    DefineExecutableArea(0x1978E, 0x1983F);
    DefineExecutableArea(0x19849, 0x198AE);
    DefineExecutableArea(0x198B2, 0x1998D);
    DefineExecutableArea(0x199BE, 0x19A5F);
    DefineExecutableArea(0x19B49, 0x19BCA);
    DefineExecutableArea(0x19BCC, 0x19D69);
    DefineExecutableArea(0x19ED5, 0x19F1B);
    DefineExecutableArea(0x19F40, 0x1A024);
    DefineExecutableArea(0x1A026, 0x1A106);
    DefineExecutableArea(0x1A1C4, 0x1A1C9);
    DefineExecutableArea(0x1A1E2, 0x1A1EC);
    DefineExecutableArea(0x1A30B, 0x1A33B);
    DefineExecutableArea(0x1A396, 0x1A3E7);
    DefineExecutableArea(0x1A3F9, 0x1A813);
    DefineExecutableArea(0x1A83F, 0x1A9F3);
    DefineExecutableArea(0x1AA0E, 0x1AB91);
    DefineExecutableArea(0x1ABA3, 0x1ABDA);
    DefineExecutableArea(0x1ABE9, 0x1AC34);
    DefineExecutableArea(0x1AC3A, 0x1AC6D);
    DefineExecutableArea(0x1ACE6, 0x1AD4F);
    DefineExecutableArea(0x1AD57, 0x1ADDF);
    DefineExecutableArea(0x1ADED, 0x1AEAE);
    DefineExecutableArea(0x1AEB7, 0x1AED5);
    DefineExecutableArea(0x1B17A, 0x1B18A);
    DefineExecutableArea(0x1B2B3, 0x1B359);
    DefineExecutableArea(0x1B389, 0x1B3AF);
    DefineExecutableArea(0x1B427, 0x1B472);
    DefineExecutableArea(0x1B4EA, 0x1B5CE);
    DefineExecutableArea(0x1B647, 0x1B699);
    DefineExecutableArea(0x1B6C3, 0x1B914);
    DefineExecutableArea(0x1B930, 0x1B960);
    DefineExecutableArea(0x1B977, 0x1B9AC);
    DefineExecutableArea(0x1B9AE, 0x1B9B8);
    DefineExecutableArea(0x1B9E0, 0x1BC63);
    DefineExecutableArea(0x1BC99, 0x1BD24);
    DefineExecutableArea(0x1BDFA, 0x1BF54);
    DefineExecutableArea(0x1BF61, 0x1C0B5);
    DefineExecutableArea(0x1C0D5, 0x1C101);
    DefineExecutableArea(0x1C108, 0x1C201);
    DefineExecutableArea(0x1C21B, 0x1C32E);
    DefineExecutableArea(0x1C343, 0x1C36F);
    DefineExecutableArea(0x1C412, 0x1C421);
    DefineExecutableArea(0x1C432, 0x1C589);
    DefineExecutableArea(0x1C6AC, 0x1C7D3);
    DefineExecutableArea(0x1C85B, 0x1C867);
    DefineExecutableArea(0x1C921, 0x1CC91);
    DefineExecutableArea(0x1CC96, 0x1CE4A);
    DefineExecutableArea(0x1CE53, 0x1D08E);
    DefineExecutableArea(0x1D096, 0x1D0D0);
    DefineExecutableArea(0x1D12F, 0x1D169);
    DefineExecutableArea(0x1D194, 0x1D2DE);
    DefineExecutableArea(0x1D2E2, 0x1D422);
    DefineExecutableArea(0x1D42F, 0x1D616);
    DefineExecutableArea(0x1D61D, 0x1D64D);
    DefineExecutableArea(0x1D65A, 0x1D676);
    DefineExecutableArea(0x1D694, 0x1D7AC);
    DefineExecutableArea(0x1D7B2, 0x1D961);
    DefineExecutableArea(0x1D9D2, 0x1DD0F);
    DefineExecutableArea(0x1DD5A, 0x1DDAF);
    DefineExecutableArea(0x1DDE7, 0x1DDEF);
    DefineExecutableArea(0x1DE07, 0x1DE67);
    DefineExecutableArea(0x1DE7A, 0x1DF06);
    DefineExecutableArea(0x1DF1E, 0x1DFA6);
    DefineExecutableArea(0x1DFB7, 0x1E067);
    DefineExecutableArea(0x1E1D1, 0x1E242);
    DefineExecutableArea(0x1E26F, 0x1E294);
    DefineExecutableArea(0x1E297, 0x1E2C9);
    DefineExecutableArea(0x1E2DB, 0x1E40A);
    DefineExecutableArea(0x1E4AD, 0x1E8D1);
    DefineExecutableArea(0x1E8D5, 0x1E949);
    DefineExecutableArea(0x1E97A, 0x1EA2F);
    DefineExecutableArea(0x1EA32, 0x1EA74);
    DefineExecutableArea(0x1EA7B, 0x1EB73);
    DefineExecutableArea(0x1EC46, 0x1EC6B);
    DefineExecutableArea(0x1EC9C, 0x1ED39);
    DefineExecutableArea(0x1ED40, 0x1ED4B);
    DefineExecutableArea(0x1EDB9, 0x1EE89);
    DefineExecutableArea(0x1EEA0, 0x1EEE8);
    DefineExecutableArea(0x1EF22, 0x1EFE5);
    DefineExecutableArea(0x1EFE7, 0x1F29A);
    DefineExecutableArea(0x1F2A7, 0x1F2E6);
    DefineExecutableArea(0x1F2EA, 0x1F4A8);
    DefineExecutableArea(0x335B0, 0x335BE);
    DefineExecutableArea(0x335C5, 0x335D6);
    DefineExecutableArea(0x335DA, 0x335EC);
    DefineExecutableArea(0x335EF, 0x335F7);
    DefineExecutableArea(0x335FB, 0x3360C);
    DefineExecutableArea(0x33610, 0x33615);
    DefineExecutableArea(0x33619, 0x33624);
    DefineExecutableArea(0x3362B, 0x3362D);
    DefineExecutableArea(0x33E17, 0x33F25);
    DefineExecutableArea(0x33F87, 0x3408B);
    DefineExecutableArea(0x340B6, 0x340E3);
    DefineExecutableArea(0x340EB, 0x341DD);
    DefineExecutableArea(0x341DF, 0x341EC);
    DefineExecutableArea(0x341EE, 0x34230);
    DefineExecutableArea(0x34235, 0x344B4);
    DefineExecutableArea(0x344BA, 0x3458B);
    DefineExecutableArea(0x34592, 0x345FF);
    DefineExecutableArea(0x34601, 0x346AD);
    DefineExecutableArea(0x346AF, 0x34720);
    DefineExecutableArea(0x34722, 0x34765);
    DefineExecutableArea(0x34767, 0x349A4);
    DefineExecutableArea(0x349AD, 0x34A31);
    DefineExecutableArea(0x34A3A, 0x34AAA);
    DefineExecutableArea(0x34B57, 0x34BD7);
    DefineExecutableArea(0x34C98, 0x34CD3);
    DefineExecutableArea(0x34CD5, 0x34E78);
    DefineExecutableArea(0x34EA7, 0x3514F);
    DefineExecutableArea(0x35166, 0x35232);
    DefineExecutableArea(0x35235, 0x35270);
    DefineExecutableArea(0x35272, 0x35378);
    DefineExecutableArea(0x353FC, 0x35527);
    DefineExecutableArea(0x35529, 0x3554C);
    DefineExecutableArea(0x3554E, 0x35833);
    DefineExecutableArea(0x35846, 0x358F0);
    DefineExecutableArea(0x359ED, 0x35A37);
    DefineExecutableArea(0x35A46, 0x35A58);
    DefineExecutableArea(0x35A97, 0x35ACA);
    DefineExecutableArea(0x35ACD, 0x35AD7);
    DefineExecutableArea(0x35B93, 0x35BDD);
    DefineExecutableArea(0x35F60, 0x35F7F);
    DefineExecutableArea(0x366B0, 0x366D2);
    DefineExecutableArea(0x36730, 0x36831);
    DefineExecutableArea(0x36A78, 0x36A99);
    DefineExecutableArea(0x36E99, 0x36EB5);
    DefineExecutableArea(0x36EC4, 0x36ED4);
    DefineExecutableArea(0x56450, 0x56451);
    DefineExecutableArea(0x56453, 0x56455);
    DefineExecutableArea(0x56459, 0x5645A);
    DefineExecutableArea(0x5645C, 0x5645D);
    DefineExecutableArea(0x56465, 0x56466);
    DefineExecutableArea(0x564CB, 0x564DE);
    DefineExecutableArea(0x564E0, 0x564F4);
    DefineExecutableArea(0x56562, 0x56625);
    DefineExecutableArea(0x56630, 0x569BA);
    DefineExecutableArea(0xF0000, 0xF0027);
  }
  
  
  public Action entry_1000_0000_10000(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0000_10000:
    // MOV AX,0xdd1d (1000_0000 / 0x10000)
    AX = 0xDD1D;
    CheckExternalEvents(cs1, 0x6);
    // CALL 0x1000:e4ad (1000_0003 / 0x10003)
    NearCall(cs1, 0x6, spice86_generated_label_call_target_1000_E4AD_01E4AD);
    label_1000_0006_10006:
    // CALL 0x1000:e594 (1000_0006 / 0x10006)
    NearCall(cs1, 0x9, spice86_generated_label_call_target_1000_E594_01E594);
    label_1000_0009_10009:
    // CALL 0x1000:00b0 (1000_0009 / 0x10009)
    NearCall(cs1, 0xC, spice86_generated_label_call_target_1000_00B0_0100B0);
    label_1000_000C_1000C:
    // STI  (1000_000C / 0x1000C)
    InterruptFlag = true;
    // CALL 0x1000:0580 (1000_000D / 0x1000D)
    NearCall(cs1, 0x10, spice86_generated_label_call_target_1000_0580_010580);
    label_1000_0010_10010:
    // CALL 0x1000:0309 (1000_0010 / 0x10010)
    NearCall(cs1, 0x13, spice86_generated_label_call_target_1000_0309_010309);
    label_1000_0013_10013:
    // CALL 0x1000:021c (1000_0013 / 0x10013)
    NearCall(cs1, 0x16, spice86_generated_label_call_target_1000_021C_01021C);
    label_1000_0016_10016:
    // CALL 0x1000:aeb7 (1000_0016 / 0x10016)
    NearCall(cs1, 0x19, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_0019_10019:
    // MOV byte ptr [0x3810],0x0 (1000_0019 / 0x10019)
    UInt8[DS, 0x3810] = 0x0;
    // MOV word ptr [0x2],0x2 (1000_001E / 0x1001E)
    UInt16[DS, 0x2] = 0x2;
    // CALL 0x1000:0083 (1000_0024 / 0x10024)
    NearCall(cs1, 0x27, spice86_generated_label_call_target_1000_0083_010083);
    label_1000_0027_10027:
    // MOV CL,0xff (1000_0027 / 0x10027)
    CL = 0xFF;
    // CALL 0x1000:b389 (1000_0029 / 0x10029)
    NearCall(cs1, 0x2C, spice86_generated_label_call_target_1000_B389_01B389);
    label_1000_002C_1002C:
    // CALL 0x1000:1860 (1000_002C / 0x1002C)
    NearCall(cs1, 0x2F, spice86_generated_label_call_target_1000_1860_011860);
    label_1000_002F_1002F:
    // MOV byte ptr [0xce80],0xff (1000_002F / 0x1002F)
    UInt8[DS, 0xCE80] = 0xFF;
    // CALL 0x1000:b2be (1000_0034 / 0x10034)
    NearCall(cs1, 0x37, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    label_1000_0037_10037:
    // CALL 0x1000:d815 (1000_0037 / 0x10037)
    NearCall(cs1, 0x3A, spice86_generated_label_call_target_1000_D815_01D815);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_jump_target_1000_003A_01003A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_jump_target_1000_003A_01003A(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_003A_1003A:
    // CLD  (1000_003A / 0x1003A)
    DirectionFlag = false;
    // XOR AX,AX (1000_003B / 0x1003B)
    AX = 0;
    // INT 0x33 (1000_003D / 0x1003D)
    Interrupt(0x33);
    // MOV AX,0x1f4b (1000_003F / 0x1003F)
    AX = 0x1F4B;
    // MOV DS,AX (1000_0042 / 0x10042)
    DS = AX;
    // CALL 0x1000:e8d5 (1000_0044 / 0x10044)
    NearCall(cs1, 0x47, spice86_generated_label_call_target_1000_E8D5_01E8D5);
    label_1000_0047_10047:
    // CMP word ptr [0x3977],0x0 (1000_0047 / 0x10047)
    Alu.Sub16(UInt16[DS, 0x3977], 0x0);
    // JZ 0x1000:0056 (1000_004C / 0x1004C)
    if(ZeroFlag) {
      goto label_1000_0056_10056;
    }
    // CALLF [0x3975] (1000_004E / 0x1004E)
    // Indirect call to [0x3975], generating possible targets from emulator records
    uint targetAddress_1000_004E = (uint)(UInt16[DS, 0x3977] * 0x10 + UInt16[DS, 0x3975] - cs1 * 0x10);
    switch(targetAddress_1000_004E) {
      case 0x464E6 : FarCall(cs1, 0x52, spice86_generated_label_call_target_563E_0106_0564E6); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_004E));
        break;
    }
    label_1000_0052_10052:
    // CALLF [0x398d] (1000_0052 / 0x10052)
    // Indirect call to [0x398d], generating possible targets from emulator records
    uint targetAddress_1000_0052 = (uint)(UInt16[DS, 0x398F] * 0x10 + UInt16[DS, 0x398D] - cs1 * 0x10);
    switch(targetAddress_1000_0052) {
      case 0x46453 : FarCall(cs1, 0x56, spice86_generated_label_call_target_5635_0103_056453); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0052));
        break;
    }
    label_1000_0056_10056:
    // MOV AX,0x3 (1000_0056 / 0x10056)
    AX = 0x3;
    // INT 0x10 (1000_0059 / 0x10059)
    Interrupt(0x10);
    // MOV SI,word ptr [0x3cbc] (1000_005B / 0x1005B)
    SI = UInt16[DS, 0x3CBC];
    // OR SI,SI (1000_005F / 0x1005F)
    // SI |= SI;
    SI = Alu.Or16(SI, SI);
    // JZ 0x1000:006e (1000_0061 / 0x10061)
    if(ZeroFlag) {
      goto label_1000_006E_1006E;
    }
    label_1000_0063_10063:
    // LODSB SI (1000_0063 / 0x10063)
    AL = UInt8[DS, SI];
    SI = (ushort)(SI + Direction8);
    // OR AL,AL (1000_0064 / 0x10064)
    // AL |= AL;
    AL = Alu.Or8(AL, AL);
    // JZ 0x1000:006e (1000_0066 / 0x10066)
    if(ZeroFlag) {
      goto label_1000_006E_1006E;
    }
    // MOV AH,0xe (1000_0068 / 0x10068)
    AH = 0xE;
    // INT 0x10 (1000_006A / 0x1006A)
    Interrupt(0x10);
    // JMP 0x1000:0063 (1000_006C / 0x1006C)
    goto label_1000_0063_10063;
    label_1000_006E_1006E:
    // MOV AX,0xe0d (1000_006E / 0x1006E)
    AX = 0xE0D;
    // INT 0x10 (1000_0071 / 0x10071)
    Interrupt(0x10);
    // MOV AX,0xe0a (1000_0073 / 0x10073)
    AX = 0xE0A;
    // INT 0x10 (1000_0076 / 0x10076)
    Interrupt(0x10);
    // MOV DL,0xff (1000_0078 / 0x10078)
    DL = 0xFF;
    // MOV AX,0xc06 (1000_007A / 0x1007A)
    AX = 0xC06;
    // INT 0x21 (1000_007D / 0x1007D)
    Interrupt(0x21);
    // MOV AH,0x4c (1000_007F / 0x1007F)
    AH = 0x4C;
    // INT 0x21 (1000_0081 / 0x10081)
    Interrupt(0x21);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0083_010083, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0083_010083(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0083_10083:
    // CALL 0x1000:cfa0 (1000_0083 / 0x10083)
    NearCall(cs1, 0x86, spice86_generated_label_call_target_1000_CFA0_01CFA0);
    label_1000_0086_10086:
    // CALL 0x1000:c07c (1000_0086 / 0x10086)
    NearCall(cs1, 0x89, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_0089_10089:
    // CALL 0x1000:c0ad (1000_0089 / 0x10089)
    NearCall(cs1, 0x8C, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    label_1000_008C_1008C:
    // MOV SI,0x1ae4 (1000_008C / 0x1008C)
    SI = 0x1AE4;
    // MOV BP,0xd1ef (1000_008F / 0x1008F)
    BP = 0xD1EF;
    // CALL 0x1000:c097 (1000_0092 / 0x10092)
    NearCall(cs1, 0x95, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_0095_10095:
    // JMP 0x1000:1797 (1000_0095 / 0x10095)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_1797_011797, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0098_010098(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0098_10098:
    // MOV CX,word ptr ES:[DI] (1000_0098 / 0x10098)
    CX = UInt16[ES, DI];
    // SHR CX,0x1 (1000_009B / 0x1009B)
    // CX >>= 0x1;
    CX = Alu.Shr16(CX, 0x1);
    // MOV BX,DI (1000_009D / 0x1009D)
    BX = DI;
    label_1000_009F_1009F:
    // MOV AX,word ptr ES:[DI] (1000_009F / 0x1009F)
    AX = UInt16[ES, DI];
    // ADD AX,BX (1000_00A2 / 0x100A2)
    // AX += BX;
    AX = Alu.Add16(AX, BX);
    // STOSW ES:DI (1000_00A4 / 0x100A4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x1000:009f (1000_00A5 / 0x100A5)
    if(--CX != 0) {
      goto label_1000_009F_1009F;
    }
    // RET  (1000_00A7 / 0x100A7)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_00B0_0100B0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_00B0_100B0:
    // CALL 0x1000:00d1 (1000_00B0 / 0x100B0)
    NearCall(cs1, 0xB3, spice86_generated_label_call_target_1000_00D1_0100D1);
    label_1000_00B3_100B3:
    // CALL 0x1000:0169 (1000_00B3 / 0x100B3)
    NearCall(cs1, 0xB6, spice86_generated_label_call_target_1000_0169_010169);
    label_1000_00B6_100B6:
    // CALL 0x1000:da53 (1000_00B6 / 0x100B6)
    NearCall(cs1, 0xB9, spice86_generated_label_call_target_1000_DA53_01DA53);
    label_1000_00B9_100B9:
    // CALL 0x1000:b17a (1000_00B9 / 0x100B9)
    NearCall(cs1, 0xBC, spice86_generated_label_call_target_1000_B17A_01B17A);
    label_1000_00BC_100BC:
    // CALL 0x1000:b17a (1000_00BC / 0x100BC)
    NearCall(cs1, 0xBF, spice86_generated_label_call_target_1000_B17A_01B17A);
    label_1000_00BF_100BF:
    // XOR AX,AX (1000_00BF / 0x100BF)
    AX = 0;
    // MOV ES,AX (1000_00C1 / 0x100C1)
    ES = AX;
    // MOV AX,ES:[0x46c] (1000_00C3 / 0x100C3)
    AX = UInt16[ES, 0x46C];
    // MOV [0xd824],AX (1000_00C7 / 0x100C7)
    UInt16[DS, 0xD824] = AX;
    // MOV [0xd826],AX (1000_00CA / 0x100CA)
    UInt16[DS, 0xD826] = AX;
    // MOV [0xd828],AX (1000_00CD / 0x100CD)
    UInt16[DS, 0xD828] = AX;
    // RET  (1000_00D0 / 0x100D0)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_00D1_0100D1(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_00D1_100D1:
    // PUSH DS (1000_00D1 / 0x100D1)
    Stack.Push(DS);
    // POP ES (1000_00D2 / 0x100D2)
    ES = Stack.Pop();
    // MOV DI,0x4948 (1000_00D3 / 0x100D3)
    DI = 0x4948;
    // MOV SI,0xba (1000_00D6 / 0x100D6)
    SI = 0xBA;
    // CALL 0x1000:f0b9 (1000_00D9 / 0x100D9)
    NearCall(cs1, 0xDC, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_00DC_100DC:
    // MOV CX,0x18c (1000_00DC / 0x100DC)
    CX = 0x18C;
    // MOV SI,DI (1000_00DF / 0x100DF)
    SI = DI;
    label_1000_00E1_100E1:
    // LODSW SI (1000_00E1 / 0x100E1)
    AX = UInt16[DS, SI];
    SI = (ushort)(SI + Direction16);
    // XCHG AL,AH (1000_00E2 / 0x100E2)
    byte tmp_1000_00E2 = AL;
    AL = AH;
    AH = tmp_1000_00E2;
    // STOSW ES:DI (1000_00E4 / 0x100E4)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // LOOP 0x1000:00e1 (1000_00E5 / 0x100E5)
    if(--CX != 0) {
      goto label_1000_00E1_100E1;
    }
    // MOV DI,0x4880 (1000_00E7 / 0x100E7)
    DI = 0x4880;
    // MOV CX,0x63 (1000_00EA / 0x100EA)
    CX = 0x63;
    // MOV SI,0x494a (1000_00ED / 0x100ED)
    SI = 0x494A;
    label_1000_00F0_100F0:
    // XOR AX,AX (1000_00F0 / 0x100F0)
    AX = 0;
    // MOV DX,0x1 (1000_00F2 / 0x100F2)
    DX = 0x1;
    // MOV BX,word ptr [SI] (1000_00F5 / 0x100F5)
    BX = UInt16[DS, SI];
    // SHL BX,0x1 (1000_00F7 / 0x100F7)
    BX <<= 0x1;
    
    // DIV BX (1000_00F9 / 0x100F9)
    Cpu.Div16(BX);
    // CMP word ptr [SI],DX (1000_00FB / 0x100FB)
    Alu.Sub16(UInt16[DS, SI], DX);
    // ADC AX,0x0 (1000_00FD / 0x100FD)
    AX = Alu.Adc16(AX, 0x0);
    // STOSW ES:DI (1000_0100 / 0x10100)
    UInt16[ES, DI] = AX;
    DI = (ushort)(DI + Direction16);
    // ADD SI,0x8 (1000_0101 / 0x10101)
    // SI += 0x8;
    SI = Alu.Add16(SI, 0x8);
    // LOOP 0x1000:00f0 (1000_0104 / 0x10104)
    if(--CX != 0) {
      goto label_1000_00F0_100F0;
    }
    // MOV SI,0xbf (1000_0106 / 0x10106)
    SI = 0xBF;
    // CALL 0x1000:f0b9 (1000_0109 / 0x10109)
    NearCall(cs1, 0x10C, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_010C_1010C:
    // MOV AX,DI (1000_010C / 0x1010C)
    AX = DI;
    // ADD AX,0x62fc (1000_010E / 0x1010E)
    // AX += 0x62FC;
    AX = Alu.Add16(AX, 0x62FC);
    // MOV [0xdcfe],AX (1000_0111 / 0x10111)
    UInt16[DS, 0xDCFE] = AX;
    // MOV word ptr [0xdd00],ES (1000_0114 / 0x10114)
    UInt16[DS, 0xDD00] = ES;
    // PUSH DS (1000_0118 / 0x10118)
    Stack.Push(DS);
    // POP ES (1000_0119 / 0x10119)
    ES = Stack.Pop();
    // MOV DI,0xaa76 (1000_011A / 0x1011A)
    DI = 0xAA76;
    // MOV SI,0xbd (1000_011D / 0x1011D)
    SI = 0xBD;
    // CALL 0x1000:f0a0 (1000_0120 / 0x10120)
    NearCall(cs1, 0x123, spice86_generated_label_call_target_1000_F0A0_01F0A0);
    label_1000_0123_10123:
    // CALL 0x1000:0098 (1000_0123 / 0x10123)
    NearCall(cs1, 0x126, spice86_generated_label_call_target_1000_0098_010098);
    label_1000_0126_10126:
    // MOV SI,0xbc (1000_0126 / 0x10126)
    SI = 0xBC;
    // CALL 0x1000:f0b9 (1000_0129 / 0x10129)
    NearCall(cs1, 0x12C, spice86_generated_label_call_target_1000_F0B9_01F0B9);
    label_1000_012C_1012C:
    // MOV word ptr [0xaa72],DI (1000_012C / 0x1012C)
    UInt16[DS, 0xAA72] = DI;
    // MOV word ptr [0xaa74],ES (1000_0130 / 0x10130)
    UInt16[DS, 0xAA74] = ES;
    // CALL 0x1000:0098 (1000_0134 / 0x10134)
    NearCall(cs1, 0x137, spice86_generated_label_call_target_1000_0098_010098);
    label_1000_0137_10137:
    // LES AX,[0x39b7] (1000_0137 / 0x10137)
    ES = UInt16[DS, 0x39B9];
    AX = UInt16[DS, 0x39B7];
    // MOV [0x47ac],AX (1000_013B / 0x1013B)
    UInt16[DS, 0x47AC] = AX;
    // MOV word ptr [0x47ae],ES (1000_013E / 0x1013E)
    UInt16[DS, 0x47AE] = ES;
    // MOV CX,0x1d4c (1000_0142 / 0x10142)
    CX = 0x1D4C;
    // CALL 0x1000:f0ff (1000_0145 / 0x10145)
    NearCall(cs1, 0x148, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    label_1000_0148_10148:
    // LES AX,[0x39b7] (1000_0148 / 0x10148)
    ES = UInt16[DS, 0x39B9];
    AX = UInt16[DS, 0x39B7];
    // MOV [0x47b0],AX (1000_014C / 0x1014C)
    UInt16[DS, 0x47B0] = AX;
    // MOV word ptr [0x47b2],ES (1000_014F / 0x1014F)
    UInt16[DS, 0x47B2] = ES;
    // MOV CX,0xadd4 (1000_0153 / 0x10153)
    CX = 0xADD4;
    // CALL 0x1000:f0ff (1000_0156 / 0x10156)
    NearCall(cs1, 0x159, spice86_generated_label_call_target_1000_F0FF_01F0FF);
    label_1000_0159_10159:
    // CALL 0x1000:cfb9 (1000_0159 / 0x10159)
    NearCall(cs1, 0x15C, spice86_generated_label_call_target_1000_CFB9_01CFB9);
    label_1000_015C_1015C:
    // JMP 0x1000:c137 (1000_015C / 0x1015C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C137_01C137, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0169_010169(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0169_10169:
    // MOV AX,0x3a (1000_0169 / 0x10169)
    AX = 0x3A;
    // CALL 0x1000:c13e (1000_016C / 0x1016C)
    NearCall(cs1, 0x16F, spice86_generated_label_call_target_1000_C13E_01C13E);
    label_1000_016F_1016F:
    // PUSH DS (1000_016F / 0x1016F)
    Stack.Push(DS);
    // POP ES (1000_0170 / 0x10170)
    ES = Stack.Pop();
    // MOV DI,0x4c60 (1000_0171 / 0x10171)
    DI = 0x4C60;
    // PUSH DI (1000_0174 / 0x10174)
    Stack.Push(DI);
    // MOV AX,0x7 (1000_0175 / 0x10175)
    AX = 0x7;
    // MOV CX,0x100 (1000_0178 / 0x10178)
    CX = 0x100;
    // REP
    while (CX != 0) {
      CX--;
      // STOSW ES:DI (1000_017B / 0x1017B)
      UInt16[ES, DI] = AX;
      DI = (ushort)(DI + Direction16);
    }
    // POP DI (1000_017D / 0x1017D)
    DI = Stack.Pop();
    // LES SI,[0xdbb0] (1000_017E / 0x1017E)
    ES = UInt16[DS, 0xDBB2];
    SI = UInt16[DS, 0xDBB0];
    // MOV CX,0xc5f9 (1000_0182 / 0x10182)
    CX = 0xC5F9;
    label_1000_0185_10185:
    // LODSB ES:SI (1000_0185 / 0x10185)
    AL = UInt8[ES, SI];
    SI = (ushort)(SI + Direction8);
    // MOV BX,AX (1000_0187 / 0x10187)
    BX = AX;
    // SHL BX,0x1 (1000_0189 / 0x10189)
    BX <<= 0x1;
    
    // INC word ptr [BX + DI] (1000_018B / 0x1018B)
    UInt16[DS, (ushort)(BX + DI)] = Alu.Inc16(UInt16[DS, (ushort)(BX + DI)]);
    // LOOP 0x1000:0185 (1000_018D / 0x1018D)
    if(--CX != 0) {
      goto label_1000_0185_10185;
    }
    // MOV SI,0x100 (1000_018F / 0x1018F)
    SI = 0x100;
    label_1000_0192_10192:
    // MOV DX,word ptr [SI + 0x2] (1000_0192 / 0x10192)
    DX = UInt16[DS, (ushort)(SI + 0x2)];
    // MOV BX,word ptr [SI + 0x4] (1000_0195 / 0x10195)
    BX = UInt16[DS, (ushort)(SI + 0x4)];
    // CALL 0x1000:b5c5 (1000_0198 / 0x10198)
    NearCall(cs1, 0x19B, spice86_generated_label_call_target_1000_B5C5_01B5C5);
    label_1000_019B_1019B:
    // MOV word ptr [SI + 0x2],DX (1000_019B / 0x1019B)
    UInt16[DS, (ushort)(SI + 0x2)] = DX;
    // MOV word ptr [SI + 0x6],DI (1000_019E / 0x1019E)
    UInt16[DS, (ushort)(SI + 0x6)] = DI;
    // OR byte ptr ES:[DI],0x40 (1000_01A1 / 0x101A1)
    // UInt8[ES, DI] |= 0x40;
    UInt8[ES, DI] = Alu.Or8(UInt8[ES, DI], 0x40);
    // MOV ES,word ptr [0xdbb2] (1000_01A5 / 0x101A5)
    ES = UInt16[DS, 0xDBB2];
    // MOV AL,byte ptr ES:[DI] (1000_01A9 / 0x101A9)
    AL = UInt8[ES, DI];
    // MOV byte ptr [SI + 0x10],AL (1000_01AC / 0x101AC)
    UInt8[DS, (ushort)(SI + 0x10)] = AL;
    // XOR BX,BX (1000_01AF / 0x101AF)
    BX = 0;
    // MOV BL,AL (1000_01B1 / 0x101B1)
    BL = AL;
    // SHL BX,0x1 (1000_01B3 / 0x101B3)
    // BX <<= 0x1;
    BX = Alu.Shl16(BX, 0x1);
    // MOV AX,word ptr [BX + 0x4c60] (1000_01B5 / 0x101B5)
    AX = UInt16[DS, (ushort)(BX + 0x4C60)];
    // MOV CL,0x4 (1000_01B9 / 0x101B9)
    CL = 0x4;
    // SHR AX,CL (1000_01BB / 0x101BB)
    // AX >>= CL;
    AX = Alu.Shr16(AX, CL);
    // MOV byte ptr [SI + 0x11],AL (1000_01BD / 0x101BD)
    UInt8[DS, (ushort)(SI + 0x11)] = AL;
    // ADD SI,0x1c (1000_01C0 / 0x101C0)
    SI += 0x1C;
    
    // CMP byte ptr [SI],0xff (1000_01C3 / 0x101C3)
    Alu.Sub8(UInt8[DS, SI], 0xFF);
    // JNZ 0x1000:0192 (1000_01C6 / 0x101C6)
    if(!ZeroFlag) {
      goto label_1000_0192_10192;
    }
    // MOV DI,0x100 (1000_01C8 / 0x101C8)
    DI = 0x100;
    label_1000_01CB_101CB:
    // MOV BP,0x1e0 (1000_01CB / 0x101CB)
    BP = 0x1E0;
    // MOV DX,word ptr [DI + 0x2] (1000_01CE / 0x101CE)
    DX = UInt16[DS, (ushort)(DI + 0x2)];
    // MOV BX,word ptr [DI + 0x4] (1000_01D1 / 0x101D1)
    BX = UInt16[DS, (ushort)(DI + 0x4)];
    // CALL 0x1000:6603 (1000_01D4 / 0x101D4)
    NearCall(cs1, 0x1D7, spice86_generated_label_call_target_1000_6603_016603);
    label_1000_01D7_101D7:
    // ADD DI,0x1c (1000_01D7 / 0x101D7)
    DI += 0x1C;
    
    // CMP byte ptr [DI],0xff (1000_01DA / 0x101DA)
    Alu.Sub8(UInt8[DS, DI], 0xFF);
    // JNZ 0x1000:01cb (1000_01DD / 0x101DD)
    if(!ZeroFlag) {
      goto label_1000_01CB_101CB;
    }
    // RET  (1000_01DF / 0x101DF)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_01E0_0101E0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_01E0_101E0:
    // MOV word ptr [SI + 0x4],DI (1000_01E0 / 0x101E0)
    UInt16[DS, (ushort)(SI + 0x4)] = DI;
    // MOV word ptr [SI + 0x6],DX (1000_01E3 / 0x101E3)
    UInt16[DS, (ushort)(SI + 0x6)] = DX;
    // MOV word ptr [SI + 0x8],BX (1000_01E6 / 0x101E6)
    UInt16[DS, (ushort)(SI + 0x8)] = BX;
    // MOV AL,byte ptr [DI] (1000_01E9 / 0x101E9)
    AL = UInt8[DS, DI];
    // MOV AH,byte ptr [SI + 0x12] (1000_01EB / 0x101EB)
    AH = UInt8[DS, (ushort)(SI + 0x12)];
    // AND AX,0x700f (1000_01EE / 0x101EE)
    AX &= 0x700F;
    
    // CMP AL,0x3 (1000_01F1 / 0x101F1)
    Alu.Sub8(AL, 0x3);
    // JBE 0x1000:0206 (1000_01F3 / 0x101F3)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_01F5 / 0x101F5)
    AH ^= 0x80;
    
    // CMP AL,0x5 (1000_01F8 / 0x101F8)
    Alu.Sub8(AL, 0x5);
    // JBE 0x1000:0206 (1000_01FA / 0x101FA)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_01FC / 0x101FC)
    AH ^= 0x80;
    
    // CMP AL,0x9 (1000_01FF / 0x101FF)
    Alu.Sub8(AL, 0x9);
    // JBE 0x1000:0206 (1000_0201 / 0x10201)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0206_10206;
    }
    // XOR AH,0x80 (1000_0203 / 0x10203)
    // AH ^= 0x80;
    AH = Alu.Xor8(AH, 0x80);
    label_1000_0206_10206:
    // OR AL,AH (1000_0206 / 0x10206)
    // AL |= AH;
    AL = Alu.Or8(AL, AH);
    // MOV byte ptr [SI + 0x12],AL (1000_0208 / 0x10208)
    UInt8[DS, (ushort)(SI + 0x12)] = AL;
    // RET  (1000_020B / 0x1020B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_021C_01021C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_021C_1021C:
    // MOV byte ptr [0x289e],0x8c (1000_021C / 0x1021C)
    UInt8[DS, 0x289E] = 0x8C;
    // MOV byte ptr [0x28e7],0x1 (1000_0221 / 0x10221)
    UInt8[DS, 0x28E7] = 0x1;
    // JZ 0x1000:0292 (1000_0226 / 0x10226)
    if(ZeroFlag) {
      goto label_1000_0292_10292;
    }
    // CALL 0x1000:ad50 (1000_0228 / 0x10228)
    throw FailAsUntested("Could not find a valid function at address 1000_AD50 / 0x1AD50");
    // MOV AX,0x3e8 (1000_022B / 0x1022B)
    AX = 0x3E8;
    // MOV SI,0x1 (1000_022E / 0x1022E)
    SI = 0x1;
    label_1000_0231_10231:
    // PUSH SI (1000_0231 / 0x10231)
    Stack.Push(SI);
    // MOV BP,0x2c1 (1000_0232 / 0x10232)
    BP = 0x2C1;
    // CALL 0x1000:c102 (1000_0235 / 0x10235)
    throw FailAsUntested("Could not find a valid function at address 1000_C102 / 0x1C102");
    // CALL 0x1000:ade0 (1000_0238 / 0x10238)
    throw FailAsUntested("Could not find a valid function at address 1000_ADE0 / 0x1ADE0");
    // POP AX (1000_023B / 0x1023B)
    AX = Stack.Pop();
    // PUSH AX (1000_023C / 0x1023C)
    Stack.Push(AX);
    // CALL 0x1000:ab4f (1000_023D / 0x1023D)
    NearCall(cs1, 0x240, spice86_generated_label_call_target_1000_AB4F_01AB4F);
    // POP SI (1000_0240 / 0x10240)
    SI = Stack.Pop();
    // CALL 0x1000:de54 (1000_0241 / 0x10241)
    NearCall(cs1, 0x244, spice86_generated_label_call_target_1000_DE54_01DE54);
    // JZ 0x1000:0292 (1000_0244 / 0x10244)
    if(ZeroFlag) {
      goto label_1000_0292_10292;
    }
    // PUSH SI (1000_0246 / 0x10246)
    Stack.Push(SI);
    // MOV AX,0x320 (1000_0247 / 0x10247)
    AX = 0x320;
    // MOV AX,0xfa0 (1000_024A / 0x1024A)
    AX = 0xFA0;
    // CALL 0x1000:ddb0 (1000_024D / 0x1024D)
    throw FailAsUntested("Could not find a valid function at address 1000_DDB0 / 0x1DDB0");
    // PUSHF  (1000_0250 / 0x10250)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0911 (1000_0251 / 0x10251)
    NearCall(cs1, 0x254, spice86_generated_label_call_target_1000_0911_010911);
    // CALL 0x1000:ac14 (1000_0254 / 0x10254)
    NearCall(cs1, 0x257, spice86_generated_label_call_target_1000_AC14_01AC14);
    // CALL 0x1000:aded (1000_0257 / 0x10257)
    NearCall(cs1, 0x25A, split_1000_ADED_01ADED);
    // POPF  (1000_025A / 0x1025A)
    FlagRegister = Stack.Pop();
    // POP SI (1000_025B / 0x1025B)
    SI = Stack.Pop();
    // JZ 0x1000:0292 (1000_025C / 0x1025C)
    if(ZeroFlag) {
      goto label_1000_0292_10292;
    }
    // INC SI (1000_025E / 0x1025E)
    SI = Alu.Inc16(SI);
    // CMP SI,0x8 (1000_025F / 0x1025F)
    Alu.Sub16(SI, 0x8);
    // JBE 0x1000:0231 (1000_0262 / 0x10262)
    if(CarryFlag || ZeroFlag) {
      goto label_1000_0231_10231;
    }
    // MOV BP,0x301 (1000_0264 / 0x10264)
    BP = 0x301;
    // MOV AL,0x10 (1000_0267 / 0x10267)
    AL = 0x10;
    // CALL 0x1000:c108 (1000_0269 / 0x10269)
    NearCall(cs1, 0x26C, spice86_generated_label_call_target_1000_C108_01C108);
    // MOV AX,0xc8 (1000_026C / 0x1026C)
    AX = 0xC8;
    // CALL 0x1000:ddb0 (1000_026F / 0x1026F)
    throw FailAsUntested("Could not find a valid function at address 1000_DDB0 / 0x1DDB0");
    // MOV BL,0xc (1000_0272 / 0x10272)
    BL = 0xC;
    // CALL 0x1000:38f1 (1000_0274 / 0x10274)
    throw FailAsUntested("Could not find a valid function at address 1000_38F1 / 0x138F1");
    // MOV byte ptr [0x46df],0x1 (1000_0277 / 0x10277)
    UInt8[DS, 0x46DF] = 0x1;
    // MOV AX,0x4b0 (1000_027C / 0x1027C)
    AX = 0x4B0;
    // CALL 0x1000:ddb0 (1000_027F / 0x1027F)
    throw FailAsUntested("Could not find a valid function at address 1000_DDB0 / 0x1DDB0");
    // CALL 0x1000:3950 (1000_0282 / 0x10282)
    throw FailAsUntested("Could not find a valid function at address 1000_3950 / 0x13950");
    // MOV byte ptr [0x46df],0x0 (1000_0285 / 0x10285)
    UInt8[DS, 0x46DF] = 0x0;
    // MOV BP,0xc0ad (1000_028A / 0x1028A)
    BP = 0xC0AD;
    // MOV AL,0x10 (1000_028D / 0x1028D)
    AL = 0x10;
    // CALL 0x1000:c108 (1000_028F / 0x1028F)
    NearCall(cs1, 0x292, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_0292_10292:
    // MOV ES,word ptr [0xdbd8] (1000_0292 / 0x10292)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x38d5] (1000_0296 / 0x10296)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_0296 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_0296) {
      case 0x235C8 : FarCall(cs1, 0x29A, spice86_generated_label_call_target_334B_0118_0335C8); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0296));
        break;
    }
    label_1000_029A_1029A:
    // CALL 0x1000:ac14 (1000_029A / 0x1029A)
    NearCall(cs1, 0x29D, spice86_generated_label_call_target_1000_AC14_01AC14);
    label_1000_029D_1029D:
    // MOV byte ptr [0x227d],0x0 (1000_029D / 0x1029D)
    UInt8[DS, 0x227D] = 0x0;
    // MOV byte ptr [0xc5],0x0 (1000_02A2 / 0x102A2)
    UInt8[DS, 0xC5] = 0x0;
    // CALL 0x1000:0911 (1000_02A7 / 0x102A7)
    NearCall(cs1, 0x2AA, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_02AA_102AA:
    // MOV byte ptr [0x28e7],0x0 (1000_02AA / 0x102AA)
    UInt8[DS, 0x28E7] = 0x0;
    // MOV byte ptr [0xdbe6],0x6 (1000_02AF / 0x102AF)
    UInt8[DS, 0xDBE6] = 0x6;
    // INC byte ptr [0x115] (1000_02B4 / 0x102B4)
    UInt8[DS, 0x115] = Alu.Inc8(UInt8[DS, 0x115]);
    // MOV DX,0x200a (1000_02B8 / 0x102B8)
    DX = 0x200A;
    // MOV BX,0x180 (1000_02BB / 0x102BB)
    BX = 0x180;
    // JMP 0x1000:08f0 (1000_02BE / 0x102BE)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_08F0_0108F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0309_010309(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0309_10309:
    // JZ 0x1000:0331 (1000_0309 / 0x10309)
    if(ZeroFlag) {
      goto label_1000_0331_10331;
    }
    // CALL 0x1000:de4e (1000_030B / 0x1030B)
    NearCall(cs1, 0x30E, spice86_generated_label_call_target_1000_DE4E_01DE4E);
    // CALL 0x1000:c07c (1000_030E / 0x1030E)
    NearCall(cs1, 0x311, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:c0ad (1000_0311 / 0x10311)
    NearCall(cs1, 0x314, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // MOV AX,0x18 (1000_0314 / 0x10314)
    AX = 0x18;
    // CALLF [0x3939] (1000_0317 / 0x10317)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_0317 = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_0317) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0317));
        break;
    }
    // MOV BP,0x9ef (1000_031B / 0x1031B)
    BP = 0x9EF;
    // CALL 0x1000:c102 (1000_031E / 0x1031E)
    throw FailAsUntested("Could not find a valid function at address 1000_C102 / 0x1C102");
    // CALL 0x1000:ad50 (1000_0321 / 0x10321)
    throw FailAsUntested("Could not find a valid function at address 1000_AD50 / 0x1AD50");
    label_1000_0324_10324:
    // CALL 0x1000:0a16 (1000_0324 / 0x10324)
    throw FailAsUntested("Could not find a valid function at address 1000_0A16 / 0x10A16");
    // CALL 0x1000:cc85 (1000_0327 / 0x10327)
    NearCall(cs1, 0x32A, spice86_generated_label_call_target_1000_CC85_01CC85);
    // JNZ 0x1000:0331 (1000_032A / 0x1032A)
    if(!ZeroFlag) {
      goto label_1000_0331_10331;
    }
    // CALL 0x1000:dd63 (1000_032C / 0x1032C)
    NearCall(cs1, 0x32F, spice86_generated_label_call_target_1000_DD63_01DD63);
    // JNC 0x1000:0324 (1000_032F / 0x1032F)
    if(!CarryFlag) {
      goto label_1000_0324_10324;
    }
    label_1000_0331_10331:
    // PUSHF  (1000_0331 / 0x10331)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0579 (1000_0332 / 0x10332)
    NearCall(cs1, 0x335, spice86_generated_label_call_target_1000_0579_010579);
    label_1000_0335_10335:
    // POPF  (1000_0335 / 0x10335)
    FlagRegister = Stack.Pop();
    // RET  (1000_0336 / 0x10336)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_0579_010579(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0579_10579:
    // XOR AX,AX (1000_0579 / 0x10579)
    AX = 0;
    // CALLF [0x3939] (1000_057B / 0x1057B)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_057B = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_057B) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_057B));
        break;
    }
    // RET  (1000_057F / 0x1057F)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_0580_010580(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0580_10580:
    // CALL 0x1000:de54 (1000_0580 / 0x10580)
    NearCall(cs1, 0x583, spice86_generated_label_call_target_1000_DE54_01DE54);
    label_1000_0583_10583:
    // JZ 0x1000:05fd (1000_0583 / 0x10583)
    if(ZeroFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALLF [0x3959] (1000_0585 / 0x10585)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_0585 = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_0585) {
      case 0x2362B : FarCall(cs1, 0x589, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0585));
        break;
    }
    label_1000_0589_10589:
    // CALL 0x1000:aeb7 (1000_0589 / 0x10589)
    NearCall(cs1, 0x58C, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_058C_1058C:
    // MOV SI,0x337 (1000_058C / 0x1058C)
    SI = 0x337;
    // CALL 0x1000:0945 (1000_058F / 0x1058F)
    NearCall(cs1, 0x592, spice86_generated_label_call_target_1000_0945_010945);
    label_1000_0592_10592:
    // MOV AX,0x18 (1000_0592 / 0x10592)
    AX = 0x18;
    // CALLF [0x3939] (1000_0595 / 0x10595)
    // Indirect call to [0x3939], generating possible targets from emulator records
    uint targetAddress_1000_0595 = (uint)(UInt16[DS, 0x393B] * 0x10 + UInt16[DS, 0x3939] - cs1 * 0x10);
    switch(targetAddress_1000_0595) {
      case 0x23613 : FarCall(cs1, 0x599, spice86_generated_label_call_target_334B_0163_033613); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0595));
        break;
    }
    label_1000_0599_10599:
    // CALL 0x1000:093f (1000_0599 / 0x10599)
    NearCall(cs1, 0x59C, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_059C_1059C:
    // MOV BX,AX (1000_059C / 0x1059C)
    BX = AX;
    // INC AX (1000_059E / 0x1059E)
    AX = Alu.Inc16(AX);
    // JNZ 0x1000:05a3 (1000_059F / 0x1059F)
    if(!ZeroFlag) {
      goto label_1000_05A3_105A3;
    }
    // JMP 0x1000:0580 (1000_05A1 / 0x105A1)
    goto label_1000_0580_10580;
    label_1000_05A3_105A3:
    // CALL 0x1000:de0c (1000_05A3 / 0x105A3)
    throw FailAsUntested("Could not find a valid function at address 1000_DE0C / 0x1DE0C");
    label_1000_05A6_105A6:
    // JC 0x1000:05fd (1000_05A6 / 0x105A6)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:0911 (1000_05A8 / 0x105A8)
    NearCall(cs1, 0x5AB, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_05AB_105AB:
    // CALLF [0x3959] (1000_05AB / 0x105AB)
    // Indirect call to [0x3959], generating possible targets from emulator records
    uint targetAddress_1000_05AB = (uint)(UInt16[DS, 0x395B] * 0x10 + UInt16[DS, 0x3959] - cs1 * 0x10);
    switch(targetAddress_1000_05AB) {
      case 0x2362B : FarCall(cs1, 0x5AF, spice86_generated_label_call_target_334B_017B_03362B); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_05AB));
        break;
    }
    label_1000_05AF_105AF:
    // CALL 0x1000:093f (1000_05AF / 0x105AF)
    NearCall(cs1, 0x5B2, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05B2_105B2:
    // MOV BP,AX (1000_05B2 / 0x105B2)
    BP = AX;
    // CALL 0x1000:c097 (1000_05B4 / 0x105B4)
    NearCall(cs1, 0x5B7, spice86_generated_label_call_target_1000_C097_01C097);
    label_1000_05B7_105B7:
    // AND byte ptr [0x47d1],0x7f (1000_05B7 / 0x105B7)
    // UInt8[DS, 0x47D1] &= 0x7F;
    UInt8[DS, 0x47D1] = Alu.And8(UInt8[DS, 0x47D1], 0x7F);
    // CALL 0x1000:39e6 (1000_05BC / 0x105BC)
    NearCall(cs1, 0x5BF, spice86_generated_label_call_target_1000_39E6_0139E6);
    label_1000_05BF_105BF:
    // CALL 0x1000:093f (1000_05BF / 0x105BF)
    NearCall(cs1, 0x5C2, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05C2_105C2:
    // MOV BX,AX (1000_05C2 / 0x105C2)
    BX = AX;
    // CALL 0x1000:de0c (1000_05C4 / 0x105C4)
    throw FailAsUntested("Could not find a valid function at address 1000_DE0C / 0x1DE0C");
    label_1000_05C7_105C7:
    // JC 0x1000:05fd (1000_05C7 / 0x105C7)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05C9 / 0x105C9)
    NearCall(cs1, 0x5CC, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05CC_105CC:
    // OR AX,AX (1000_05CC / 0x105CC)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JS 0x1000:05dc (1000_05CE / 0x105CE)
    if(SignFlag) {
      goto label_1000_05DC_105DC;
    }
    // MOV BP,0xf66 (1000_05D0 / 0x105D0)
    BP = 0xF66;
    // CALL 0x1000:c108 (1000_05D3 / 0x105D3)
    NearCall(cs1, 0x5D6, spice86_generated_label_call_target_1000_C108_01C108);
    label_1000_05D6_105D6:
    // CALL 0x1000:c0f4 (1000_05D6 / 0x105D6)
    NearCall(cs1, 0x5D9, spice86_generated_label_call_target_1000_C0F4_01C0F4);
    label_1000_05D9_105D9:
    // CALL 0x1000:3a7c (1000_05D9 / 0x105D9)
    NearCall(cs1, 0x5DC, spice86_generated_label_call_target_1000_3A7C_013A7C);
    label_1000_05DC_105DC:
    // CALL 0x1000:c07c (1000_05DC / 0x105DC)
    NearCall(cs1, 0x5DF, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_05DF_105DF:
    // OR byte ptr [0x47d1],0x80 (1000_05DF / 0x105DF)
    // UInt8[DS, 0x47D1] |= 0x80;
    UInt8[DS, 0x47D1] = Alu.Or8(UInt8[DS, 0x47D1], 0x80);
    // CALL 0x1000:dd63 (1000_05E4 / 0x105E4)
    NearCall(cs1, 0x5E7, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_05E7_105E7:
    // JC 0x1000:05fd (1000_05E7 / 0x105E7)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05E9 / 0x105E9)
    NearCall(cs1, 0x5EC, spice86_generated_label_call_target_1000_093F_01093F);
    label_1000_05EC_105EC:
    // CLC  (1000_05EC / 0x105EC)
    CarryFlag = false;
    // CALL AX (1000_05ED / 0x105ED)
    // Indirect call to AX, generating possible targets from emulator records
    uint targetAddress_1000_05ED = (uint)(AX);
    switch(targetAddress_1000_05ED) {
      case 0x625 : NearCall(cs1, 0x5EF, spice86_generated_label_call_target_1000_0625_010625); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_05ED));
        break;
    }
    label_1000_05EF_105EF:
    // JC 0x1000:05fd (1000_05EF / 0x105EF)
    if(CarryFlag) {
      goto label_1000_05FD_105FD;
    }
    // CALL 0x1000:093f (1000_05F1 / 0x105F1)
    NearCall(cs1, 0x5F4, spice86_generated_label_call_target_1000_093F_01093F);
    // OR AX,AX (1000_05F4 / 0x105F4)
    // AX |= AX;
    AX = Alu.Or16(AX, AX);
    // JZ 0x1000:0592 (1000_05F6 / 0x105F6)
    if(ZeroFlag) {
      goto label_1000_0592_10592;
    }
    // CALL 0x1000:ddf0 (1000_05F8 / 0x105F8)
    throw FailAsUntested("Could not find a valid function at address 1000_DDF0 / 0x1DDF0");
    // JNC 0x1000:0592 (1000_05FB / 0x105FB)
    if(!CarryFlag) {
      goto label_1000_0592_10592;
    }
    label_1000_05FD_105FD:
    // PUSHF  (1000_05FD / 0x105FD)
    Stack.Push(FlagRegister);
    // CALL 0x1000:9985 (1000_05FE / 0x105FE)
    NearCall(cs1, 0x601, spice86_generated_label_call_target_1000_9985_019985);
    label_1000_0601_10601:
    // MOV ES,word ptr [0xdbd8] (1000_0601 / 0x10601)
    ES = UInt16[DS, 0xDBD8];
    // CALLF [0x38d5] (1000_0605 / 0x10605)
    // Indirect call to [0x38d5], generating possible targets from emulator records
    uint targetAddress_1000_0605 = (uint)(UInt16[DS, 0x38D7] * 0x10 + UInt16[DS, 0x38D5] - cs1 * 0x10);
    switch(targetAddress_1000_0605) {
      case 0x235C8 : FarCall(cs1, 0x609, spice86_generated_label_call_target_334B_0118_0335C8); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_0605));
        break;
    }
    label_1000_0609_10609:
    // POPF  (1000_0609 / 0x10609)
    FlagRegister = Stack.Pop();
    // PUSHF  (1000_060A / 0x1060A)
    Stack.Push(FlagRegister);
    // CALL 0x1000:0579 (1000_060B / 0x1060B)
    NearCall(cs1, 0x60E, spice86_generated_label_call_target_1000_0579_010579);
    label_1000_060E_1060E:
    // CALL 0x1000:ca01 (1000_060E / 0x1060E)
    NearCall(cs1, 0x611, spice86_generated_label_call_target_1000_CA01_01CA01);
    label_1000_0611_10611:
    // MOV word ptr [0x2],0x2 (1000_0611 / 0x10611)
    UInt16[DS, 0x2] = 0x2;
    // CALL 0x1000:0911 (1000_0617 / 0x10617)
    NearCall(cs1, 0x61A, spice86_generated_label_call_target_1000_0911_010911);
    label_1000_061A_1061A:
    // POPF  (1000_061A / 0x1061A)
    FlagRegister = Stack.Pop();
    // RET  (1000_061B / 0x1061B)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_061C_01061C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_061C_1061C:
    // CALL 0x1000:ad57 (1000_061C / 0x1061C)
    NearCall(cs1, 0x61F, spice86_generated_label_call_target_1000_AD57_01AD57);
    label_1000_061F_1061F:
    // MOV AX,0x15 (1000_061F / 0x1061F)
    AX = 0x15;
    // JMP 0x1000:ca1b (1000_0622 / 0x10622)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0625_010625(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0625_10625:
    // CALL 0x1000:c07c (1000_0625 / 0x10625)
    NearCall(cs1, 0x628, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_0628_10628:
    // CALL 0x1000:dd63 (1000_0628 / 0x10628)
    NearCall(cs1, 0x62B, spice86_generated_label_call_target_1000_DD63_01DD63);
    label_1000_062B_1062B:
    // JC 0x1000:064c (1000_062B / 0x1062B)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_064C / 0x1064C)
      return NearRet();
    }
    // CALL 0x1000:c9f4 (1000_062D / 0x1062D)
    NearCall(cs1, 0x630, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    label_1000_0630_10630:
    // JZ 0x1000:0628 (1000_0630 / 0x10630)
    if(ZeroFlag) {
      goto label_1000_0628_10628;
    }
    // CALL 0x1000:c4cd (1000_0632 / 0x10632)
    NearCall(cs1, 0x635, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    label_1000_0635_10635:
    // CMP word ptr [0xdbce],0x8 (1000_0635 / 0x10635)
    Alu.Sub16(UInt16[DS, 0xDBCE], 0x8);
    // JC 0x1000:0646 (1000_063A / 0x1063A)
    if(CarryFlag) {
      goto label_1000_0646_10646;
    }
    // CMP byte ptr [0xdbcb],0x0 (1000_063C / 0x1063C)
    Alu.Sub8(UInt8[DS, 0xDBCB], 0x0);
    // JZ 0x1000:0646 (1000_0641 / 0x10641)
    if(ZeroFlag) {
      goto label_1000_0646_10646;
    }
    // CALL 0x1000:aeb7 (1000_0643 / 0x10643)
    NearCall(cs1, 0x646, spice86_generated_label_call_target_1000_AEB7_01AEB7);
    label_1000_0646_10646:
    // CALL 0x1000:cc85 (1000_0646 / 0x10646)
    NearCall(cs1, 0x649, spice86_generated_label_call_target_1000_CC85_01CC85);
    label_1000_0649_10649:
    // JZ 0x1000:0628 (1000_0649 / 0x10649)
    if(ZeroFlag) {
      goto label_1000_0628_10628;
    }
    // CLC  (1000_064B / 0x1064B)
    CarryFlag = false;
    label_1000_064C_1064C:
    // RET  (1000_064C / 0x1064C)
    return NearRet();
  }
  
  public Action load_CRYO_HNM_ida_1000_064D_1064D(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_064D_1064D:
    // MOV AL,0xa (1000_064D / 0x1064D)
    AL = 0xA;
    // CALL 0x1000:ad95 (1000_064F / 0x1064F)
    NearCall(cs1, 0x652, split_1000_AD95_01AD95);
    // MOV AX,0x16 (1000_0652 / 0x10652)
    AX = 0x16;
    // JMP 0x1000:ca1b (1000_0655 / 0x10655)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action load_CRYO2_HNM_ida_1000_0658_10658(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0658_10658:
    // CALL 0x1000:c0ad (1000_0658 / 0x10658)
    NearCall(cs1, 0x65B, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // MOV AX,0x17 (1000_065B / 0x1065B)
    AX = 0x17;
    // JMP 0x1000:ca1b (1000_065E / 0x1065E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action play_CRYO_OR_CRYO2_HNM_ida_1000_0661_10661(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0661_10661:
    // CALL 0x1000:c07c (1000_0661 / 0x10661)
    NearCall(cs1, 0x664, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_0664_10664:
    // CALL 0x1000:dd63 (1000_0664 / 0x10664)
    NearCall(cs1, 0x667, spice86_generated_label_call_target_1000_DD63_01DD63);
    // JC 0x1000:064c (1000_0667 / 0x10667)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_064C / 0x1064C)
      return NearRet();
    }
    // CALL 0x1000:c9f4 (1000_0669 / 0x10669)
    NearCall(cs1, 0x66C, spice86_generated_label_call_target_1000_C9F4_01C9F4);
    // JZ 0x1000:0664 (1000_066C / 0x1066C)
    if(ZeroFlag) {
      goto label_1000_0664_10664;
    }
    // CALL 0x1000:c4cd (1000_066E / 0x1066E)
    NearCall(cs1, 0x671, spice86_generated_label_call_target_1000_C4CD_01C4CD);
    // CALL 0x1000:cc85 (1000_0671 / 0x10671)
    NearCall(cs1, 0x674, spice86_generated_label_call_target_1000_CC85_01CC85);
    // JZ 0x1000:0664 (1000_0674 / 0x10674)
    if(ZeroFlag) {
      goto label_1000_0664_10664;
    }
    // CLC  (1000_0676 / 0x10676)
    CarryFlag = false;
    // RET  (1000_0677 / 0x10677)
    return NearRet();
  }
  
  public Action load_PRESENT_HNM_ida_1000_0678_10678(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0678_10678:
    // CALL 0x1000:0579 (1000_0678 / 0x10678)
    NearCall(cs1, 0x67B, spice86_generated_label_call_target_1000_0579_010579);
    // CALL 0x1000:c0ad (1000_067B / 0x1067B)
    NearCall(cs1, 0x67E, spice86_generated_label_call_target_1000_C0AD_01C0AD);
    // MOV AX,0x18 (1000_067E / 0x1067E)
    AX = 0x18;
    // JMP 0x1000:ca1b (1000_0681 / 0x10681)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action play_PRESENT_HNM_ida_1000_0684_10684(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0684_10684:
    // JMP 0x1000:06bd (1000_0684 / 0x10684)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(play_hnm_skippable_ida_1000_06BD_106BD, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action load_INTRO_HNM_ida_1000_069E_1069E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_069E_1069E:
    // CALL 0x1000:c07c (1000_069E / 0x1069E)
    NearCall(cs1, 0x6A1, spice86_generated_label_call_target_1000_C07C_01C07C);
    // CALL 0x1000:0579 (1000_06A1 / 0x106A1)
    NearCall(cs1, 0x6A4, spice86_generated_label_call_target_1000_0579_010579);
    // MOV AX,0xf (1000_06A4 / 0x106A4)
    AX = 0xF;
    // JMP 0x1000:ca1b (1000_06A7 / 0x106A7)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action play_hnm_86_frames_ida_1000_06AA_106AA(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_06AA_106AA:
    // CALL 0x1000:0579 (1000_06AA / 0x106AA)
    NearCall(cs1, 0x6AD, spice86_generated_label_call_target_1000_0579_010579);
    // CALL 0x1000:c08e (1000_06AD / 0x106AD)
    NearCall(cs1, 0x6B0, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_06B0_106B0:
    // CALL 0x1000:c9e8 (1000_06B0 / 0x106B0)
    NearCall(cs1, 0x6B3, hnm_do_frame_skippable_ida_1000_C9E8_1C9E8);
    // JC 0x1000:06bc (1000_06B3 / 0x106B3)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_06BC / 0x106BC)
      return NearRet();
    }
    // CMP word ptr [0xdbe8],0x56 (1000_06B5 / 0x106B5)
    Alu.Sub16(UInt16[DS, 0xDBE8], 0x56);
    // JNZ 0x1000:06b0 (1000_06BA / 0x106BA)
    if(!ZeroFlag) {
      goto label_1000_06B0_106B0;
    }
    // Function call generated as ASM continues to next function body without return
    if(JumpDispatcher.Jump(play_hnm_skippable_ida_1000_06BD_106BD, 0x106BC - cs1 * 0x10)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action play_hnm_skippable_ida_1000_06BD_106BD(int loadOffset) {
    entrydispatcher:
    switch(loadOffset) {
      case 0x6BC: break; // Instructions before entry targeted by 
      case 0: goto entry; break; // 0 is the entry point ghidra detected, but in this case function start is not entry point
    }
    label_1000_06BC_106BC:
    // RET  (1000_06BC / 0x106BC)
    return NearRet();
    entry:
    label_1000_06BD_106BD:
    // CALL 0x1000:0579 (1000_06BD / 0x106BD)
    NearCall(cs1, 0x6C0, spice86_generated_label_call_target_1000_0579_010579);
    // CALL 0x1000:c08e (1000_06C0 / 0x106C0)
    NearCall(cs1, 0x6C3, spice86_generated_label_call_target_1000_C08E_01C08E);
    label_1000_06C3_106C3:
    // CALL 0x1000:c9e8 (1000_06C3 / 0x106C3)
    NearCall(cs1, 0x6C6, hnm_do_frame_skippable_ida_1000_C9E8_1C9E8);
    // JC 0x1000:06bc (1000_06C6 / 0x106C6)
    if(CarryFlag) {
      // JC target is RET, inlining.
      // RET  (1000_06BC / 0x106BC)
      return NearRet();
    }
    // CALL 0x1000:cc85 (1000_06C8 / 0x106C8)
    NearCall(cs1, 0x6CB, spice86_generated_label_call_target_1000_CC85_01CC85);
    // JZ 0x1000:06c3 (1000_06CB / 0x106CB)
    if(ZeroFlag) {
      goto label_1000_06C3_106C3;
    }
    // RET  (1000_06CD / 0x106CD)
    return NearRet();
  }
  
  public Action split_1000_08F0_0108F0(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_08F0_108F0:
    // XOR AL,AL (1000_08F0 / 0x108F0)
    AL = 0;
    // MOV [0x47a4],AL (1000_08F2 / 0x108F2)
    UInt8[DS, 0x47A4] = AL;
    // MOV [0x46df],AL (1000_08F5 / 0x108F5)
    UInt8[DS, 0x46DF] = AL;
    // MOV word ptr [0x4],DX (1000_08F8 / 0x108F8)
    UInt16[DS, 0x4] = DX;
    // MOV word ptr [0x6],BX (1000_08FC / 0x108FC)
    UInt16[DS, 0x6] = BX;
    // MOV byte ptr [0x8],DH (1000_0900 / 0x10900)
    UInt8[DS, 0x8] = DH;
    // MOV AL,0x1c (1000_0904 / 0x10904)
    AL = 0x1C;
    // MUL BH (1000_0906 / 0x10906)
    Cpu.Mul8(BH);
    // ADD AX,0xe4 (1000_0908 / 0x10908)
    // AX += 0xE4;
    AX = Alu.Add16(AX, 0xE4);
    // MOV [0x114e],AX (1000_090B / 0x1090B)
    UInt16[DS, 0x114E] = AX;
    // JMP 0x1000:2d74 (1000_090E / 0x1090E)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_2D74_012D74, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0911_010911(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0911_10911:
    // CALL 0x1000:39e6 (1000_0911 / 0x10911)
    NearCall(cs1, 0x914, spice86_generated_label_call_target_1000_39E6_0139E6);
    label_1000_0914_10914:
    // CALL 0x1000:b930 (1000_0914 / 0x10914)
    NearCall(cs1, 0x917, spice86_generated_label_call_target_1000_B930_01B930);
    label_1000_0917_10917:
    // CALL 0x1000:0b21 (1000_0917 / 0x10917)
    NearCall(cs1, 0x91A, spice86_generated_label_call_target_1000_0B21_010B21);
    label_1000_091A_1091A:
    // CALL 0x1000:9985 (1000_091A / 0x1091A)
    NearCall(cs1, 0x91D, spice86_generated_label_call_target_1000_9985_019985);
    label_1000_091D_1091D:
    // CALL 0x1000:98e6 (1000_091D / 0x1091D)
    NearCall(cs1, 0x920, spice86_generated_label_call_target_1000_98E6_0198E6);
    label_1000_0920_10920:
    // MOV byte ptr [0x22e3],0x1 (1000_0920 / 0x10920)
    UInt8[DS, 0x22E3] = 0x1;
    // MOV byte ptr [0x46d7],0x0 (1000_0925 / 0x10925)
    UInt8[DS, 0x46D7] = 0x0;
    // MOV SI,0x70c (1000_092A / 0x1092A)
    SI = 0x70C;
    // CALL 0x1000:da5f (1000_092D / 0x1092D)
    NearCall(cs1, 0x930, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_0930_10930:
    // MOV SI,0x3916 (1000_0930 / 0x10930)
    SI = 0x3916;
    // CALL 0x1000:da5f (1000_0933 / 0x10933)
    NearCall(cs1, 0x936, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_0936_10936:
    // CALL 0x1000:0a3e (1000_0936 / 0x10936)
    NearCall(cs1, 0x939, spice86_generated_label_call_target_1000_0A3E_010A3E);
    label_1000_0939_10939:
    // MOV SI,0x826 (1000_0939 / 0x10939)
    SI = 0x826;
    // JMP 0x1000:da5f (1000_093C / 0x1093C)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_093F_01093F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_093F_1093F:
    // MOV SI,word ptr [0x4854] (1000_093F / 0x1093F)
    SI = UInt16[DS, 0x4854];
    // LODSW CS:SI (1000_0943 / 0x10943)
    AX = UInt16[cs1, SI];
    SI = (ushort)(SI + Direction16);
    // Function call generated as ASM continues to next function entry point without return
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_0945_010945, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0945_010945(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0945_10945:
    // MOV word ptr [0x4854],SI (1000_0945 / 0x10945)
    UInt16[DS, 0x4854] = SI;
    // RET  (1000_0949 / 0x10949)
    return NearRet();
  }
  
  public Action play_CREDITS_HNM_ida_1000_09EF_109EF(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_09EF_109EF:
    // MOV AX,0x14 (1000_09EF / 0x109EF)
    AX = 0x14;
    // JMP 0x1000:ca1b (1000_09F2 / 0x109F2)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_CA1B_01CA1B, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0A3E_010A3E(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0A3E_10A3E:
    // MOV SI,0xa16 (1000_0A3E / 0x10A3E)
    SI = 0xA16;
    // JMP 0x1000:da5f (1000_0A41 / 0x10A41)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_DA5F_01DA5F, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0B21_010B21(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0B21_10B21:
    // CALL 0x1000:ac30 (1000_0B21 / 0x10B21)
    NearCall(cs1, 0xB24, spice86_generated_label_call_target_1000_AC30_01AC30);
    label_1000_0B24_10B24:
    // MOV byte ptr CS:[0xc13c],0x25 (1000_0B24 / 0x10B24)
    UInt8[cs1, 0xC13C] = 0x25;
    // MOV SI,0xb45 (1000_0B2A / 0x10B2A)
    SI = 0xB45;
    // CALL 0x1000:da5f (1000_0B2D / 0x10B2D)
    NearCall(cs1, 0xB30, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    label_1000_0B30_10B30:
    // CMP byte ptr [0x227d],0x0 (1000_0B30 / 0x10B30)
    Alu.Sub8(UInt8[DS, 0x227D], 0x0);
    // JNZ 0x1000:0b3e (1000_0B35 / 0x10B35)
    if(!ZeroFlag) {
      goto label_1000_0B3E_10B3E;
    }
    // CMP byte ptr [0xfb],0x0 (1000_0B37 / 0x10B37)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:0b44 (1000_0B3C / 0x10B3C)
    if(SignFlag) {
      // JS target is RET, inlining.
      // RET  (1000_0B44 / 0x10B44)
      return NearRet();
    }
    label_1000_0B3E_10B3E:
    // MOV word ptr [0x3cbe],0x0 (1000_0B3E / 0x10B3E)
    UInt16[DS, 0x3CBE] = 0x0;
    label_1000_0B44_10B44:
    // RET  (1000_0B44 / 0x10B44)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_0F66_010F66(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0F66_10F66:
    // RET  (1000_0F66 / 0x10F66)
    return NearRet();
  }
  
  public Action split_1000_0FA7_010FA7(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0FA7_10FA7:
    // CALL 0x1000:dbb2 (1000_0FA7 / 0x10FA7)
    NearCall(cs1, 0xFAA, spice86_generated_label_call_target_1000_DBB2_01DBB2);
    // MOV AL,0x2a (1000_0FAA / 0x10FAA)
    AL = 0x2A;
    // CALL 0x1000:189a (1000_0FAC / 0x10FAC)
    throw FailAsUntested("Could not find a valid function at address 1000_189A / 0x1189A");
    // JMP 0x1000:d763 (1000_0FAF / 0x10FAF)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_ret_target_1000_D763_01D763, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_0FD9_010FD9(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_0FD9_10FD9:
    // MOV byte ptr [0x46da],0x1 (1000_0FD9 / 0x10FD9)
    UInt8[DS, 0x46DA] = 0x1;
    // CALL 0x1000:b2be (1000_0FDE / 0x10FDE)
    NearCall(cs1, 0xFE1, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    label_1000_0FE1_10FE1:
    // OR CX,CX (1000_0FE1 / 0x10FE1)
    // CX |= CX;
    CX = Alu.Or16(CX, CX);
    // JLE 0x1000:1005 (1000_0FE3 / 0x10FE3)
    if(ZeroFlag || SignFlag != OverflowFlag) {
      goto label_1000_1005_11005;
    }
    // PUSH CX (1000_0FE5 / 0x10FE5)
    Stack.Push(CX);
    // MOV AX,[0x146e] (1000_0FE6 / 0x10FE6)
    AX = UInt16[DS, 0x146E];
    // MOV [0x46db],AX (1000_0FE9 / 0x10FE9)
    UInt16[DS, 0x46DB] = AX;
    // CMP byte ptr [0x46dd],0x0 (1000_0FEC / 0x10FEC)
    Alu.Sub8(UInt8[DS, 0x46DD], 0x0);
    // JZ 0x1000:0ff6 (1000_0FF1 / 0x10FF1)
    if(ZeroFlag) {
      goto label_1000_0FF6_10FF6;
    }
    // CALL 0x1000:1b23 (1000_0FF3 / 0x10FF3)
    NearCall(cs1, 0xFF6, spice86_generated_label_ret_target_1000_1B23_011B23);
    label_1000_0FF6_10FF6:
    // INC word ptr [0x2] (1000_0FF6 / 0x10FF6)
    UInt16[DS, 0x2] = Alu.Inc16(UInt16[DS, 0x2]);
    // MOV byte ptr [0x46dd],0x1 (1000_0FFA / 0x10FFA)
    UInt8[DS, 0x46DD] = 0x1;
    // CALL 0x1000:1b23 (1000_0FFF / 0x10FFF)
    NearCall(cs1, 0x1002, spice86_generated_label_ret_target_1000_1B23_011B23);
    label_1000_1002_11002:
    // POP CX (1000_1002 / 0x11002)
    CX = Stack.Pop();
    // LOOP 0x1000:0fd9 (1000_1003 / 0x11003)
    if(--CX != 0) {
      goto label_1000_0FD9_10FD9;
    }
    label_1000_1005_11005:
    // MOV byte ptr [0x46da],0x0 (1000_1005 / 0x11005)
    UInt8[DS, 0x46DA] = 0x0;
    // RET  (1000_100A / 0x1100A)
    return NearRet();
  }
  
  public Action split_1000_121F_01121F(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_121F_1121F:
    // CMP AL,byte ptr [0x2a] (1000_121F / 0x1121F)
    Alu.Sub8(AL, UInt8[DS, 0x2A]);
    // JBE 0x1000:1242 (1000_1223 / 0x11223)
    if(CarryFlag || ZeroFlag) {
      // JBE target is RET, inlining.
      // RET  (1000_1242 / 0x11242)
      return NearRet();
    }
    // MOV [0x2a],AL (1000_1225 / 0x11225)
    UInt8[DS, 0x2A] = AL;
    // MOV byte ptr [0xff],0x0 (1000_1228 / 0x11228)
    UInt8[DS, 0xFF] = 0x0;
    // CALL 0x1000:b17a (1000_122D / 0x1122D)
    NearCall(cs1, 0x1230, spice86_generated_label_call_target_1000_B17A_01B17A);
    // MOV BL,byte ptr [0x2a] (1000_1230 / 0x11230)
    BL = UInt8[DS, 0x2A];
    // CMP BL,0x6c (1000_1234 / 0x11234)
    Alu.Sub8(BL, 0x6C);
    // JA 0x1000:1242 (1000_1237 / 0x11237)
    if(!CarryFlag && !ZeroFlag) {
      // JA target is RET, inlining.
      // RET  (1000_1242 / 0x11242)
      return NearRet();
    }
    // XOR BH,BH (1000_1239 / 0x11239)
    BH = 0;
    // SHR BX,0x1 (1000_123B / 0x1123B)
    // BX >>= 0x1;
    BX = Alu.Shr16(BX, 0x1);
    // CALL word ptr CS:[BX + 0x11e7] (1000_123D / 0x1123D)
    // Indirect call to word ptr CS:[BX + 0x11e7], generating possible targets from emulator records
    uint targetAddress_1000_123D = (uint)(UInt16[cs1, (ushort)(BX + 0x11E7)]);
    switch(targetAddress_1000_123D) {
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_123D));
        break;
    }
    label_1000_1242_11242:
    // RET  (1000_1242 / 0x11242)
    return NearRet();
  }
  
  public Action spice86_generated_label_call_target_1000_127C_01127C(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_127C_1127C:
    // CMP AL,0x4 (1000_127C / 0x1127C)
    Alu.Sub8(AL, 0x4);
    // JNZ 0x1000:128d (1000_127E / 0x1127E)
    if(!ZeroFlag) {
      goto label_1000_128D_1128D;
    }
    // CMP byte ptr [0x2a],0x15 (1000_1280 / 0x11280)
    Alu.Sub8(UInt8[DS, 0x2A], 0x15);
    // JC 0x1000:128d (1000_1285 / 0x11285)
    if(CarryFlag) {
      goto label_1000_128D_1128D;
    }
    // CMP byte ptr [0x2a],0x20 (1000_1287 / 0x11287)
    Alu.Sub8(UInt8[DS, 0x2A], 0x20);
    // RET  (1000_128C / 0x1128C)
    return NearRet();
    label_1000_128D_1128D:
    // CLC  (1000_128D / 0x1128D)
    CarryFlag = false;
    // RET  (1000_128E / 0x1128E)
    return NearRet();
  }
  
  public Action split_1000_16FC_0116FC(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_16FC_116FC:
    // MOV byte ptr [0x2a],0xc8 (1000_16FC / 0x116FC)
    UInt8[DS, 0x2A] = 0xC8;
    // MOV AX,0x128f (1000_1701 / 0x11701)
    AX = 0x128F;
    // CALL 0x1000:1771 (1000_1704 / 0x11704)
    throw FailAsUntested("Could not find a valid function at address 1000_1771 / 0x11771");
    label_1000_1707_11707:
    // CMP word ptr [0x2220],0x1fae (1000_1707 / 0x11707)
    Alu.Sub16(UInt16[DS, 0x2220], 0x1FAE);
    // JNZ 0x1000:171a (1000_170D / 0x1170D)
    if(!ZeroFlag) {
      goto label_1000_171A_1171A;
    }
    // MOV DI,0x1b56 (1000_170F / 0x1170F)
    DI = 0x1B56;
    // CALL 0x1000:d6fe (1000_1712 / 0x11712)
    NearCall(cs1, 0x1715, spice86_generated_label_call_target_1000_D6FE_01D6FE);
    // JNC 0x1000:171a (1000_1715 / 0x11715)
    if(!CarryFlag) {
      goto label_1000_171A_1171A;
    }
    // JMP 0x1000:9ed5 (1000_1717 / 0x11717)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_9ED5_019ED5, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_171A_1171A:
    // MOV byte ptr [0xce9d],0x0 (1000_171A / 0x1171A)
    UInt8[DS, 0xCE9D] = 0x0;
    // MOV SI,word ptr [0x477a] (1000_171F / 0x1171F)
    SI = UInt16[DS, 0x477A];
    // LODSB CS:SI (1000_1723 / 0x11723)
    AL = UInt8[cs1, SI];
    SI = (ushort)(SI + Direction8);
    // CMP AL,0xff (1000_1725 / 0x11725)
    Alu.Sub8(AL, 0xFF);
    // JZ 0x1000:1736 (1000_1727 / 0x11727)
    if(ZeroFlag) {
      goto label_1000_1736_11736;
    }
    // MOV word ptr [0x477a],SI (1000_1729 / 0x11729)
    UInt16[DS, 0x477A] = SI;
    // XOR AH,AH (1000_172D / 0x1172D)
    AH = 0;
    // MOV BX,AX (1000_172F / 0x1172F)
    BX = AX;
    // JMP word ptr CS:[BX + 0x1475] (1000_1731 / 0x11731)
    // Indirect jump to word ptr CS:[BX + 0x1475], generating possible targets from emulator records
    uint targetAddress_1000_1731 = (uint)(UInt16[cs1, (ushort)(BX + 0x1475)]);
    switch(targetAddress_1000_1731) {
      default: throw FailAsUntested("Error: Jump not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_1731));
        break;
    }
    label_1000_1736_11736:
    // MOV SI,0x176b (1000_1736 / 0x11736)
    SI = 0x176B;
    // CALL 0x1000:da5f (1000_1739 / 0x11739)
    NearCall(cs1, 0x173C, spice86_generated_label_call_target_1000_DA5F_01DA5F);
    // MOV AX,[0x4776] (1000_173C / 0x1173C)
    AX = UInt16[DS, 0x4776];
    // MOV [0x4],AL (1000_173F / 0x1173F)
    UInt8[DS, 0x4] = AL;
    // MOV byte ptr [0x46e0],AH (1000_1742 / 0x11742)
    UInt8[DS, 0x46E0] = AH;
    // XOR AL,AL (1000_1746 / 0x11746)
    AL = 0;
    // MOV [0x4774],AL (1000_1748 / 0x11748)
    UInt8[DS, 0x4774] = AL;
    // CMP byte ptr [0x2a],0x48 (1000_174B / 0x1174B)
    Alu.Sub8(UInt8[DS, 0x2A], 0x48);
    // JZ 0x1000:1755 (1000_1750 / 0x11750)
    if(ZeroFlag) {
      goto label_1000_1755_11755;
    }
    // CALL 0x1000:adbe (1000_1752 / 0x11752)
    NearCall(cs1, 0x1755, spice86_generated_label_call_target_1000_ADBE_01ADBE);
    label_1000_1755_11755:
    // CALL 0x1000:b2be (1000_1755 / 0x11755)
    NearCall(cs1, 0x1758, spice86_generated_label_call_target_1000_B2BE_01B2BE);
    // CMP byte ptr [0xfb],0x0 (1000_1758 / 0x11758)
    Alu.Sub8(UInt8[DS, 0xFB], 0x0);
    // JS 0x1000:1762 (1000_175D / 0x1175D)
    if(SignFlag) {
      goto label_1000_1762_11762;
    }
    // JMP 0x1000:0fa7 (1000_175F / 0x1175F)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_0FA7_010FA7, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
    label_1000_1762_11762:
    // CALL 0x1000:ad5e (1000_1762 / 0x11762)
    NearCall(cs1, 0x1765, spice86_generated_label_call_target_1000_AD5E_01AD5E);
    // CALL 0x1000:68eb (1000_1765 / 0x11765)
    throw FailAsUntested("Could not find a valid function at address 1000_68EB / 0x168EB");
    // JMP 0x1000:780a (1000_1768 / 0x11768)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(split_1000_780A_01780A, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_1797_011797(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_1797_11797:
    // PUSH word ptr [0x2784] (1000_1797 / 0x11797)
    Stack.Push(UInt16[DS, 0x2784]);
    // CALL 0x1000:c137 (1000_179B / 0x1179B)
    NearCall(cs1, 0x179E, spice86_generated_label_call_target_1000_C137_01C137);
    label_1000_179E_1179E:
    // MOV DX,0x7e (1000_179E / 0x1179E)
    DX = 0x7E;
    // MOV BX,0x94 (1000_17A1 / 0x117A1)
    BX = 0x94;
    // MOV AX,0xf (1000_17A4 / 0x117A4)
    AX = 0xF;
    // CALL 0x1000:c22f (1000_17A7 / 0x117A7)
    NearCall(cs1, 0x17AA, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_17AA_117AA:
    // MOV AX,0x10 (1000_17AA / 0x117AA)
    AX = 0x10;
    // ADD AL,byte ptr [0xe8] (1000_17AD / 0x117AD)
    // AL += UInt8[DS, 0xE8];
    AL = Alu.Add8(AL, UInt8[DS, 0xE8]);
    // MOV DX,0x96 (1000_17B1 / 0x117B1)
    DX = 0x96;
    // MOV BX,0x89 (1000_17B4 / 0x117B4)
    BX = 0x89;
    // CALL 0x1000:c22f (1000_17B7 / 0x117B7)
    NearCall(cs1, 0x17BA, spice86_generated_label_call_target_1000_C22F_01C22F);
    label_1000_17BA_117BA:
    // POP AX (1000_17BA / 0x117BA)
    AX = Stack.Pop();
    // JMP 0x1000:c13e (1000_17BB / 0x117BB)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C13E_01C13E, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_17BE_0117BE(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_17BE_117BE:
    // CALL 0x1000:c07c (1000_17BE / 0x117BE)
    NearCall(cs1, 0x17C1, spice86_generated_label_call_target_1000_C07C_01C07C);
    label_1000_17C1_117C1:
    // MOV SI,0x1e6e (1000_17C1 / 0x117C1)
    SI = 0x1E6E;
    // PUSH SI (1000_17C4 / 0x117C4)
    Stack.Push(SI);
    // CMP byte ptr [0xce66],0x0 (1000_17C5 / 0x117C5)
    Alu.Sub8(UInt8[DS, 0xCE66], 0x0);
    // JNZ 0x1000:17d1 (1000_17CA / 0x117CA)
    if(!ZeroFlag) {
      goto label_1000_17D1_117D1;
    }
    // CALL 0x1000:c446 (1000_17CC / 0x117CC)
    NearCall(cs1, 0x17CF, spice86_generated_label_call_target_1000_C446_01C446);
    label_1000_17CF_117CF:
    // JMP 0x1000:17df (1000_17CF / 0x117CF)
    goto label_1000_17DF_117DF;
    label_1000_17D1_117D1:
    // MOV BP,0x1e76 (1000_17D1 / 0x117D1)
    BP = 0x1E76;
    // MOV SI,0xcd9e (1000_17D4 / 0x117D4)
    SI = 0xCD9E;
    // MOV ES,word ptr [0xdbd6] (1000_17D7 / 0x117D7)
    ES = UInt16[DS, 0xDBD6];
    // CALLF [0x391d] (1000_17DB / 0x117DB)
    // Indirect call to [0x391d], generating possible targets from emulator records
    uint targetAddress_1000_17DB = (uint)(UInt16[DS, 0x391F] * 0x10 + UInt16[DS, 0x391D] - cs1 * 0x10);
    switch(targetAddress_1000_17DB) {
      case 0x235FE : FarCall(cs1, 0x17DF, spice86_generated_label_call_target_334B_014E_0335FE); break;
      default: throw FailAsUntested("Error: Function not registered at address " + ConvertUtils.ToHex32WithoutX(targetAddress_1000_17DB));
        break;
    }
    label_1000_17DF_117DF:
    // CALL 0x1000:1797 (1000_17DF / 0x117DF)
    NearCall(cs1, 0x17E2, spice86_generated_label_call_target_1000_1797_011797);
    label_1000_17E2_117E2:
    // POP SI (1000_17E2 / 0x117E2)
    SI = Stack.Pop();
    // JMP 0x1000:c4f0 (1000_17E3 / 0x117E3)
    // Jump converted to entry function call
    if(JumpDispatcher.Jump(spice86_generated_label_call_target_1000_C4F0_01C4F0, 0)) {
      loadOffset = JumpDispatcher.NextEntryAddress;
      goto entrydispatcher;
    }
    return JumpDispatcher.JumpAsmReturn!;
  }
  
  public Action spice86_generated_label_call_target_1000_17E6_0117E6(int loadOffset) {
    entrydispatcher:
    if(loadOffset!=0){
      throw FailAsUntested("External goto not supported for this function.");
    }
    
    label_1000_17E6_117E6:
    // CMP byte ptr [0x11c9],0x0 (1000_17E6 / 0x117E6)
    Alu.Sub8(UInt8[DS, 0x11C9], 0x0);
    // JNZ 0x1000:181d (1000_17EB / 0x117EB)
    if(!ZeroFlag) {
      // JNZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // CMP byte ptr [0xe8],0xa (1000_17ED / 0x117ED)
    Alu.Sub8(UInt8[DS, 0xE8], 0xA);
    // JZ 0x1000:181d (1000_17F2 / 0x117F2)
    if(ZeroFlag) {
      // JZ target is RET, inlining.
      // RET  (1000_181D / 0x1181D)
      return NearRet();
    }
    // INC byte ptr [0xe8] (1000_17F4 / 0x117F4)
    UInt8[DS, 0xE8] = Alu.Inc8(UInt8[DS, 0xE8]);
    // CALL 0x1000:17be (1000_17F8 / 0x117F8)
    NearCall(cs1, 0x17FB, spice86_generated_label_call_target_1000_17BE_0117BE);
    label_1000_17FB_117FB:
    // MOV AX,0x8 (1000_17FB / 0x117FB)
    AX = 0x8;
    // CALL 0x1000:e387 (1000_17FE / 0x117FE)
    NearCall(cs1, 0x1801, spice86_generated_label_call_target_1000_E387_01E387);
    label_1000_1801_11801:
    // JMP 0x1000:17e6 (1000_1801 / 0x11801)
    goto label_1000_17E6_117E6;
  }
  
}
