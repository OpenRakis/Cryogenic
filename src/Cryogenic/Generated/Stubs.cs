namespace Cryogenic.Generated;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spice86.Emulator.Function;
using Spice86.Emulator.Memory;
using Spice86.Emulator.ReverseEngineer;
using Spice86.Emulator.VM;

using Serilog;

// Stubs for overrides
class Stubs : CSharpOverrideHelper
{
    public Stubs(Dictionary<SegmentedAddress, FunctionInformation> functionInformations, string prefix, Machine machine): base(functionInformations, prefix, machine)
    {
    }

    // Not providing stub for entry. Reason: Function has no return
    // defineFunction(0x1ED, 0x83, "unknown", this::unknown0x1ED_0x83_0x1F53);
    public  Action Unknown0x1ED_0x83_0x1F53()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // ida.check_amr_or_eng_language_ida_0x1ED_0xCFA0_0xEE70();
        return NearRet();
    }

    // Not providing stub for datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida. Reason:
    // Function already has an override
    // defineFunction(0x1ED, 0xB0, "initialize_2_ida", this::initialize_2_ida0x1ED_0xB0_0x1F80);
    public  Action Initialize_2_ida0x1ED_0xB0_0x1F80()
    {

        // ida.intialize_resources_ida_0x1ED_0xD1_0x1FA1();
        // ida.map2_resource_func_ida_0x1ED_0x169_0x2039();
        // unknown_0x1ED_0xB17A_0xD04A();
        // initRelated.vgaInitRelated_0x1ED_0xDA53_0xF923 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD1, "intialize_resources_ida", this::intialize_resources_ida0x1ED_0xD1_0x1FA1);
    public  Action Intialize_resources_ida0x1ED_0xD1_0x1FA1()
    {

        // datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida_0x1ED_0x98_0x1F68 overriden();
        // unknown_0x1ED_0xCFB9_0xEE89();
        // ida.open_resource_force_hsq_ida_0x1ED_0xF0A0_0x10F70();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // ida.bump_allocate_bump_cx_bytes_ida_0x1ED_0xF0FF_0x10FCF();
        // vgaDriver.noOp_0x2538_0x13C_0x254BC overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x169, "map2_resource_func_ida", this::map2_resource_func_ida0x1ED_0x169_0x2039);
    public  Action Map2_resource_func_ida0x1ED_0x169_0x2039()
    {

        // unknown_0x1ED_0x6603_0x84D3();
        // unknown_0x1ED_0xB5C5_0xD495();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1E0, "unknown", this::unknown0x1ED_0x1E0_0x20B0);
    public  Action Unknown0x1ED_0x1E0_0x20B0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x21C, "play_intro2_ida", this::play_intro2_ida0x1ED_0x21C_0x20EC);
    public  Action Play_intro2_ida0x1ED_0x21C_0x20EC()
    {

        // datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida_0x1ED_0x98_0x1F68 overriden();
        // unknown_0x1ED_0x911_0x27E1();
        // unknown_0x1ED_0x38F1_0x57C1();
        // unknown_0x1ED_0x3950_0x5820();
        // ida.calc_SAL_index_ida_0x1ED_0x5E4F_0x7D1F();
        // unknown_0x1ED_0xAB4F_0xCA1F();
        // ida.pcm_stop_voc_q_ida_0x1ED_0xAC14_0xCAE4();
        // unknown_0x1ED_0xAD50_0xCC20();
        // unknown_0x1ED_0xADE0_0xCCB0();
        // unknown_0x1ED_0xADED_0xCCBD();
        // unknown_0x1ED_0xC102_0xDFD2();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xDDB0_0xFC80();
        // unknown_0x1ED_0xDE54_0xFD24();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // vgaDriver.fillWithZeroFor64000AtES_0x2538_0x118_0x25498 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2C1, "unknown", this::unknown0x1ED_0x2C1_0x2191);
    public  Action Unknown0x1ED_0x2C1_0x2191()
    {

        // unknown_0x1ED_0x2DE_0x21AE();
        // unknown_0x1ED_0x2E3_0x21B3();
        // unknown_0x1ED_0x2F8_0x21C8();
        // unknown_0x1ED_0x2FB_0x21CB();
        // unknown_0x1ED_0x2FE_0x21CE();
        // unknown_0x1ED_0x94A_0x281A();
        // unknown_0x1ED_0x88AF_0xA77F();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2DE, "unknown", this::unknown0x1ED_0x2DE_0x21AE);
    public  Action Unknown0x1ED_0x2DE_0x21AE()
    {

        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC305_0xE1D5();
        // unknown_0x1ED_0xC30D_0xE1DD();
        // unknown_0x1ED_0xC343_0xE213();
        // unknown_0x1ED_0xC432_0xE302();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2E0, "unknown", this::unknown0x1ED_0x2E0_0x21B0);
    public  Action Unknown0x1ED_0x2E0_0x21B0()
    {

        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC305_0xE1D5();
        // unknown_0x1ED_0xC30D_0xE1DD();
        // unknown_0x1ED_0xC343_0xE213();
        // unknown_0x1ED_0xC432_0xE302();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2E3, "unknown", this::unknown0x1ED_0x2E3_0x21B3);
    public  Action Unknown0x1ED_0x2E3_0x21B3()
    {

        // unknown_0x1ED_0x2E0_0x21B0();
        // unknown_0x1ED_0xB85A_0xD72A();
        // unknown_0x1ED_0xB8A7_0xD777();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2F8, "unknown", this::unknown0x1ED_0x2F8_0x21C8);
    public  Action Unknown0x1ED_0x2F8_0x21C8()
    {

        // unknown_0x1ED_0x9C7_0x2897();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // unknown_0x1ED_0xC412_0xE2E2();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2FB, "unknown", this::unknown0x1ED_0x2FB_0x21CB);
    public  Action Unknown0x1ED_0x2FB_0x21CB()
    {

        // unknown_0x1ED_0x9C7_0x2897();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // unknown_0x1ED_0xC412_0xE2E2();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2FE, "unknown", this::unknown0x1ED_0x2FE_0x21CE);
    public  Action Unknown0x1ED_0x2FE_0x21CE()
    {

        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x301, "unknown", this::unknown0x1ED_0x301_0x21D1);
    public  Action Unknown0x1ED_0x301_0x21D1()
    {

        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x309, "play_CREDITS_HNM_ida", this::play_CREDITS_HNM_ida0x1ED_0x309_0x21D9);
    public  Action Play_CREDITS_HNM_ida0x1ED_0x309_0x21D9()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // unknown_0x1ED_0xA16_0x28E6();
        // unknown_0x1ED_0xAD50_0xCC20();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // unknown_0x1ED_0xC102_0xDFD2();
        // video.isLastFrame/check_if_hnm_complete_ida_0x1ED_0xCC85_0xEB55 overriden();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        // mainCode.setCEE8To0_0x1ED_0xDE4E_0xFD1E overriden();
        // vgaDriver.updateVgaOffset01A3FromLineNumberAsAx_0x2538_0x163_0x254E3 overriden();
        return NearRet();
    }

    // Not providing stub for display.clearVgaOffset01A3F/clear_global_y_offset_ida. Reason: Function already has an
    // override
    // defineFunction(0x1ED, 0x580, "play_intro_ida", this::play_intro_ida0x1ED_0x580_0x2450);
    public  Action Play_intro_ida0x1ED_0x580_0x2450()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // ida.play_VIRGIN_HNM_ida_0x1ED_0x625_0x24F5();
        // ida.play_CRYO_OR_CRYO2_HNM_ida_0x1ED_0x661_0x2531();
        // ida.play_PRESENT_HNM_ida_0x1ED_0x684_0x2554();
        // ida.play_hnm_86_frames_ida_0x1ED_0x6AA_0x257A();
        // unknown_0x1ED_0x911_0x27E1();
        // scriptedScene.loadAXFromCSUnknownOffset4854AndAdvanceSIAndOffset/intro_script_load_word_ida_0x1ED_0x93F_0x280F
        // overriden();
        // scriptedScene.setUnknownOffset4854ToSi/intro_script_set_offset_ida_0x1ED_0x945_0x2815 overriden();
        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x39E6_0x58B6();
        // unknown_0x1ED_0x3A7C_0x594C();
        // unknown_0x1ED_0x9985_0xB855();
        // sound.checkSoundPresent/midi_func_2_0_ida_0x1ED_0xAEB7_0xCD87 overriden();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // ida.hnm_close_resource_ida_0x1ED_0xCA01_0xE8D1();
        // ida.play_IRULx_HSQ_ida_0x1ED_0xCF1B_0xEDEB();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        // unknown_0x1ED_0xDDF0_0xFCC0();
        // ida.check_midi_ida_0x1ED_0xDE0C_0xFCDC();
        // unknown_0x1ED_0xDE54_0xFD24();
        // vgaDriver.fillWithZeroFor64000AtES_0x2538_0x118_0x25498 overriden();
        // vgaDriver.updateVgaOffset01A3FromLineNumberAsAx_0x2538_0x163_0x254E3 overriden();
        // vgaDriver.copy_pal2_to_pal1_0x2538_0x17B_0x254FB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x61C, "load_VIRGIN_HNM_ida", this::load_VIRGIN_HNM_ida0x1ED_0x61C_0x24EC);
    public  Action Load_VIRGIN_HNM_ida0x1ED_0x61C_0x24EC()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // ida.play_music_MORNING_HSQ_ida_0x1ED_0xAD57_0xCC27();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x625, "play_VIRGIN_HNM_ida", this::play_VIRGIN_HNM_ida0x1ED_0x625_0x24F5);
    public  Action Play_VIRGIN_HNM_ida0x1ED_0x625_0x24F5()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // ida.do_frame_and_check_if_frame_advanced_ida_0x1ED_0xC9F4_0xE8C4();
        // video.isLastFrame/check_if_hnm_complete_ida_0x1ED_0xCC85_0xEB55 overriden();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x64D, "load_CRYO_HNM_ida", this::load_CRYO_HNM_ida0x1ED_0x64D_0x251D);
    public  Action Load_CRYO_HNM_ida0x1ED_0x64D_0x251D()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // unknown_0x1ED_0xAD95_0xCC65();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x658, "load_CRYO2_HNM_ida", this::load_CRYO2_HNM_ida0x1ED_0x658_0x2528);
    public  Action Load_CRYO2_HNM_ida0x1ED_0x658_0x2528()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x661, "play_CRYO_OR_CRYO2_HNM_ida", this::play_CRYO_OR_CRYO2_HNM_ida0x1ED_0x661_0x2531);
    public  Action Play_CRYO_OR_CRYO2_HNM_ida0x1ED_0x661_0x2531()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // ida.do_frame_and_check_if_frame_advanced_ida_0x1ED_0xC9F4_0xE8C4();
        // video.isLastFrame/check_if_hnm_complete_ida_0x1ED_0xCC85_0xEB55 overriden();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x678, "load_PRESENT_HNM_ida", this::load_PRESENT_HNM_ida0x1ED_0x678_0x2548);
    public  Action Load_PRESENT_HNM_ida0x1ED_0x678_0x2548()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x684, "play_PRESENT_HNM_ida", this::play_PRESENT_HNM_ida0x1ED_0x684_0x2554);
    public  Action Play_PRESENT_HNM_ida0x1ED_0x684_0x2554()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.hnm_do_frame_skippable_ida_0x1ED_0xC9E8_0xE8B8();
        // video.isLastFrame/check_if_hnm_complete_ida_0x1ED_0xCC85_0xEB55 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x69E, "load_INTRO_HNM_ida", this::load_INTRO_HNM_ida0x1ED_0x69E_0x256E);
    public  Action Load_INTRO_HNM_ida0x1ED_0x69E_0x256E()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6AA, "play_hnm_86_frames_ida", this::play_hnm_86_frames_ida0x1ED_0x6AA_0x257A);
    public  Action Play_hnm_86_frames_ida0x1ED_0x6AA_0x257A()
    {

        // display.clearVgaOffset01A3F/clear_global_y_offset_ida_0x1ED_0x579_0x2449 overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.hnm_do_frame_skippable_ida_0x1ED_0xC9E8_0xE8B8();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x911, "unknown", this::unknown0x1ED_0x911_0x27E1);
    public  Action Unknown0x1ED_0x911_0x27E1()
    {

        // unknown_0x1ED_0xA3E_0x290E();
        // unknown_0x1ED_0xB21_0x29F1();
        // unknown_0x1ED_0x39E6_0x58B6();
        // unknown_0x1ED_0x98E6_0xB7B6();
        // unknown_0x1ED_0x9985_0xB855();
        // unknown_0x1ED_0xB930_0xD800();
        // unknown_0x1ED_0xDA5F_0xF92F();
        return NearRet();
    }

    // Not providing stub for scriptedScene.loadAXFromCSUnknownOffset4854AndAdvanceSIAndOffset/intro_script_load_word_ida.
    // Reason: Function already has an override
    // Not providing stub for scriptedScene.setUnknownOffset4854ToSi/intro_script_set_offset_ida. Reason: Function already
    // has an override
    // defineFunction(0x1ED, 0x94A, "unknown", this::unknown0x1ED_0x94A_0x281A);
    public  Action Unknown0x1ED_0x94A_0x281A()
    {

        // unknown_0x1ED_0x38B4_0x5784();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9C7, "unknown", this::unknown0x1ED_0x9C7_0x2897);
    public  Action Unknown0x1ED_0x9C7_0x2897()
    {

        // unknown_0x1ED_0x91A0_0xB070();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9EF, "play_CREDITS_HNM_ida", this::play_CREDITS_HNM_ida0x1ED_0x9EF_0x28BF);
    public  Action Play_CREDITS_HNM_ida0x1ED_0x9EF_0x28BF()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA16, "unknown", this::unknown0x1ED_0xA16_0x28E6);
    public  Action Unknown0x1ED_0xA16_0x28E6()
    {

        // unknown_0x1ED_0xA23_0x28F3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA23, "unknown", this::unknown0x1ED_0xA23_0x28F3);
    public  Action Unknown0x1ED_0xA23_0x28F3()
    {

        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xCAA0_0xE970();
        // unknown_0x1ED_0xCAD4_0xE9A4();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // unknown_0x1ED_0xCC4E_0xEB1E();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA3E, "unknown", this::unknown0x1ED_0xA3E_0x290E);
    public  Action Unknown0x1ED_0xA3E_0x290E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB21, "unknown", this::unknown0x1ED_0xB21_0x29F1);
    public  Action Unknown0x1ED_0xB21_0x29F1()
    {

        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xDA5F_0xF92F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xED0, "unknown", this::unknown0x1ED_0xED0_0x2DA0);
    public  Action Unknown0x1ED_0xED0_0x2DA0()
    {

        // unknown_0x1ED_0xF08_0x2DD8();
        // unknown_0x1ED_0x1797_0x3667();
        // display.clearUnknownValuesAndAX_0x1ED_0x98F5_0xB7C5 overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x1ED_0xC2F2_0xE1C2();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD72B_0xF5FB();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF08, "unknown", this::unknown0x1ED_0xF08_0x2DD8);
    public  Action Unknown0x1ED_0xF08_0x2DD8()
    {

        // unknown_0x1ED_0x9C7_0x2897();
        // unknown_0x1ED_0x1797_0x3667();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC412_0xE2E2();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // Not providing stub for mainCode.noOp. Reason: Function already has an override
    // defineFunction(0x1ED, 0xFD9, "unknown", this::unknown0x1ED_0xFD9_0x2EA9);
    public  Action Unknown0x1ED_0xFD9_0x2EA9()
    {

        // unknown_0x1ED_0x1B23_0x39F3();
        // mainCode.setUnknown2788To0_0x1ED_0xB2BE_0xD18E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x100B, "unknown", this::unknown0x1ED_0x100B_0x2EDB);
    public  Action Unknown0x1ED_0x100B_0x2EDB()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1011, "unknown", this::unknown0x1ED_0x1011_0x2EE1);
    public  Action Unknown0x1ED_0x1011_0x2EE1()
    {

        // unknown_0x1ED_0x105B_0x2F2B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x105B, "unknown", this::unknown0x1ED_0x105B_0x2F2B);
    public  Action Unknown0x1ED_0x105B_0x2F2B()
    {

        // unknown_0x1ED_0x425B_0x612B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x127C, "unknown", this::unknown0x1ED_0x127C_0x314C);
    public  Action Unknown0x1ED_0x127C_0x314C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1399, "unknown", this::unknown0x1ED_0x1399_0x3269);
    public  Action Unknown0x1ED_0x1399_0x3269()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1707, "unknown", this::unknown0x1ED_0x1707_0x35D7);
    public  Action Unknown0x1ED_0x1707_0x35D7()
    {

        // unknown_0x1ED_0x1399_0x3269();
        // unknown_0x1ED_0x58FA_0x77CA();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x7847_0x9717();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x9761_0xB631();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xADBE_0xCC8E();
        // mainCode.setUnknown2788To0_0x1ED_0xB2BE_0xD18E overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // unknown_0x1ED_0xC551_0xE421();
        // unknown_0x1ED_0xD323_0xF1F3();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // unknown_0x1ED_0xDA5F_0xF92F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x176B, "unknown", this::unknown0x1ED_0x176B_0x363B);
    public  Action Unknown0x1ED_0x176B_0x363B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1797, "unknown", this::unknown0x1ED_0x1797_0x3667);
    public  Action Unknown0x1ED_0x1797_0x3667()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x17BE, "unknown", this::unknown0x1ED_0x17BE_0x368E);
    public  Action Unknown0x1ED_0x17BE_0x368E()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC446_0xE316();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        // unknown_0x2538_0x14E_0x254CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x17E6, "unknown", this::unknown0x1ED_0x17E6_0x36B6);
    public  Action Unknown0x1ED_0x17E6_0x36B6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1803, "unknown", this::unknown0x1ED_0x1803_0x36D3);
    public  Action Unknown0x1ED_0x1803_0x36D3()
    {

        // unknown_0x1ED_0x181E_0x36EE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x181E, "unknown", this::unknown0x1ED_0x181E_0x36EE);
    public  Action Unknown0x1ED_0x181E_0x36EE()
    {

        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1834, "unknown", this::unknown0x1ED_0x1834_0x3704);
    public  Action Unknown0x1ED_0x1834_0x3704()
    {

        // unknown_0x2538_0x14B_0x254CB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1843, "unknown", this::unknown0x1ED_0x1843_0x3713);
    public  Action Unknown0x1ED_0x1843_0x3713()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1860, "unknown", this::unknown0x1ED_0x1860_0x3730);
    public  Action Unknown0x1ED_0x1860_0x3730()
    {

        // unknown_0x1ED_0x1843_0x3713();
        // unknown_0x1ED_0x5ADF_0x79AF();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // unknown_0x1ED_0xB930_0xD800();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x186B, "unknown", this::unknown0x1ED_0x186B_0x373B);
    public  Action Unknown0x1ED_0x186B_0x373B()
    {

        // unknown_0x1ED_0x5ADF_0x79AF();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // unknown_0x1ED_0xB930_0xD800();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x189A, "unknown", this::unknown0x1ED_0x189A_0x376A);
    public  Action Unknown0x1ED_0x189A_0x376A()
    {

        // unknown_0x1ED_0xAE04_0xCCD4();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x18BA, "unknown", this::unknown0x1ED_0x18BA_0x378A);
    public  Action Unknown0x1ED_0x18BA_0x378A()
    {

        // unknown_0x1ED_0x39E6_0x58B6();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x4D00_0x6BD0();
        // unknown_0x1ED_0x98E6_0xB7B6();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xD2BD_0xF18D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x18EE, "unknown", this::unknown0x1ED_0x18EE_0x37BE);
    public  Action Unknown0x1ED_0x18EE_0x37BE()
    {

        // unknown_0x1ED_0x1948_0x3818();
        // unknown_0x1ED_0x5B6E_0x7A3E();
        // unknown_0x1ED_0xA7C2_0xC692();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD280_0xF150();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD338_0xF208();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1948, "unknown", this::unknown0x1ED_0x1948_0x3818);
    public  Action Unknown0x1ED_0x1948_0x3818()
    {

        // unknown_0x1ED_0x127C_0x314C();
        // unknown_0x1ED_0x19DF_0x38AF();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x19DF, "unknown", this::unknown0x1ED_0x19DF_0x38AF);
    public  Action Unknown0x1ED_0x19DF_0x38AF()
    {

        // unknown_0x1ED_0xC2FD_0xE1CD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x19FC, "unknown", this::unknown0x1ED_0x19FC_0x38CC);
    public  Action Unknown0x1ED_0x19FC_0x38CC()
    {

        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC446_0xE316();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1A0F, "unknown", this::unknown0x1ED_0x1A0F_0x38DF);
    public  Action Unknown0x1ED_0x1A0F_0x38DF()
    {

        // unknown_0x1ED_0x1A34_0x3904();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.gfx_copy_rect_to_screen_ida_0x1ED_0xC4AA_0xE37A();
        // unknown_0x1ED_0xD200_0xF0D0();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1A34, "unknown", this::unknown0x1ED_0x1A34_0x3904);
    public  Action Unknown0x1ED_0x1A34_0x3904()
    {

        // unknown_0x1ED_0x1A9B_0x396B();
        // time.getSunlightDay_0x1ED_0x1AD1_0x39A1 overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xE290_0x10160();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1A9B, "unknown", this::unknown0x1ED_0x1A9B_0x396B);
    public  Action Unknown0x1ED_0x1A9B_0x396B()
    {

        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1AC5, "unknown", this::unknown0x1ED_0x1AC5_0x3995);
    public  Action Unknown0x1ED_0x1AC5_0x3995()
    {
        return NearRet();
    }

    // Not providing stub for time.getSunlightDay. Reason: Function already has an override
    // Not providing stub for time.setHourOfTheDayToAX. Reason: Function already has an override
    // defineFunction(0x1ED, 0x1AE7, "unknown", this::unknown0x1ED_0x1AE7_0x39B7);
    public  Action Unknown0x1ED_0x1AE7_0x39B7()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1B0D, "unknown", this::unknown0x1ED_0x1B0D_0x39DD);
    public  Action Unknown0x1ED_0x1B0D_0x39DD()
    {

        // unknown_0x1ED_0x1A0F_0x38DF();
        // time.setHourOfTheDayToAX_0x1ED_0x1AE0_0x39B0 overriden();
        // unknown_0x1ED_0x1BEC_0x3ABC();
        // unknown_0x1ED_0x1C18_0x3AE8();
        // unknown_0x1ED_0x1C46_0x3B16();
        // unknown_0x1ED_0x1D9F_0x3C6F();
        // unknown_0x1ED_0x1DD3_0x3CA3();
        // unknown_0x1ED_0x1DD4_0x3CA4();
        // unknown_0x1ED_0x2B2A_0x49FA();
        // unknown_0x1ED_0x331E_0x51EE();
        // unknown_0x1ED_0x38E1_0x57B1();
        // ida.map_func_qq_ida_0x1ED_0x63F0_0x82C0();
        // unknown_0x1ED_0x6C6F_0x8B3F();
        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1B23, "unknown", this::unknown0x1ED_0x1B23_0x39F3);
    public  Action Unknown0x1ED_0x1B23_0x39F3()
    {

        // unknown_0x1ED_0x1A0F_0x38DF();
        // time.setHourOfTheDayToAX_0x1ED_0x1AE0_0x39B0 overriden();
        // unknown_0x1ED_0x1BEC_0x3ABC();
        // unknown_0x1ED_0x1C18_0x3AE8();
        // unknown_0x1ED_0x1D9F_0x3C6F();
        // unknown_0x1ED_0x1DD3_0x3CA3();
        // unknown_0x1ED_0x1DD7_0x3CA7();
        // unknown_0x1ED_0x1DDA_0x3CAA();
        // unknown_0x1ED_0x1DFE_0x3CCE();
        // unknown_0x1ED_0x331E_0x51EE();
        // unknown_0x1ED_0x38E1_0x57B1();
        // ida.map_func_qq_ida_0x1ED_0x63F0_0x82C0();
        // unknown_0x1ED_0x6C6F_0x8B3F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1BEC, "unknown", this::unknown0x1ED_0x1BEC_0x3ABC);
    public  Action Unknown0x1ED_0x1BEC_0x3ABC()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1C18, "unknown", this::unknown0x1ED_0x1C18_0x3AE8);
    public  Action Unknown0x1ED_0x1C18_0x3AE8()
    {

        // unknown_0x1ED_0xBDBB_0xDC8B();
        // unknown_0x1ED_0xC13B_0xE00B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1C46, "unknown", this::unknown0x1ED_0x1C46_0x3B16);
    public  Action Unknown0x1ED_0x1C46_0x3B16()
    {

        // unknown_0x1ED_0x1CDA_0x3BAA();
        // unknown_0x1ED_0x1D66_0x3C36();
        // unknown_0x1ED_0x1E43_0x3D13();
        // unknown_0x1ED_0xBF26_0xDDF6();
        // unknown_0x1ED_0xC02E_0xDEFE();
        // unknown_0x1ED_0xE3CC_0x1029C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1CDA, "unknown", this::unknown0x1ED_0x1CDA_0x3BAA);
    public  Action Unknown0x1ED_0x1CDA_0x3BAA()
    {

        // unknown_0x1ED_0x5D36_0x7C06();
        // unknown_0x1ED_0xE3DF_0x102AF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1D66, "unknown", this::unknown0x1ED_0x1D66_0x3C36);
    public  Action Unknown0x1ED_0x1D66_0x3C36()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1D9F, "unknown", this::unknown0x1ED_0x1D9F_0x3C6F);
    public  Action Unknown0x1ED_0x1D9F_0x3C6F()
    {

        // unknown_0x1ED_0x1E01_0x3CD1();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1DD3, "unknown", this::unknown0x1ED_0x1DD3_0x3CA3);
    public  Action Unknown0x1ED_0x1DD3_0x3CA3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1DD4, "unknown", this::unknown0x1ED_0x1DD4_0x3CA4);
    public  Action Unknown0x1ED_0x1DD4_0x3CA4()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1DD7, "unknown", this::unknown0x1ED_0x1DD7_0x3CA7);
    public  Action Unknown0x1ED_0x1DD7_0x3CA7()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1DDA, "unknown", this::unknown0x1ED_0x1DDA_0x3CAA);
    public  Action Unknown0x1ED_0x1DDA_0x3CAA()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1DFE, "unknown", this::unknown0x1ED_0x1DFE_0x3CCE);
    public  Action Unknown0x1ED_0x1DFE_0x3CCE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1E01, "unknown", this::unknown0x1ED_0x1E01_0x3CD1);
    public  Action Unknown0x1ED_0x1E01_0x3CD1()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1E43, "unknown", this::unknown0x1ED_0x1E43_0x3D13);
    public  Action Unknown0x1ED_0x1E43_0x3D13()
    {

        // unknown_0x1ED_0x1AC5_0x3995();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x1EBE, "unknown", this::unknown0x1ED_0x1EBE_0x3D8E);
    public  Action Unknown0x1ED_0x1EBE_0x3D8E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2170, "unknown", this::unknown0x1ED_0x2170_0x4040);
    public  Action Unknown0x1ED_0x2170_0x4040()
    {

        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2A51, "unknown", this::unknown0x1ED_0x2A51_0x4921);
    public  Action Unknown0x1ED_0x2A51_0x4921()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2AAF, "unknown", this::unknown0x1ED_0x2AAF_0x497F);
    public  Action Unknown0x1ED_0x2AAF_0x497F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2B2A, "unknown", this::unknown0x1ED_0x2B2A_0x49FA);
    public  Action Unknown0x1ED_0x2B2A_0x49FA()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2D74, "open_SAL_resource_ida", this::open_SAL_resource_ida0x1ED_0x2D74_0x4C44);
    public  Action Open_SAL_resource_ida0x1ED_0x2D74_0x4C44()
    {

        // datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida_0x1ED_0x98_0x1F68 overriden();
        // ida.calc_SAL_index_ida_0x1ED_0x5E4F_0x7D1F();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2DB1, "unknown", this::unknown0x1ED_0x2DB1_0x4C81);
    public  Action Unknown0x1ED_0x2DB1_0x4C81()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0x1834_0x3704();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x37B2_0x5682();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC412_0xE2E2();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // map.setMapClickHandlerAddressToInGame_0x1ED_0xD95B_0xF82B overriden();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2DBF, "unknown", this::unknown0x1ED_0x2DBF_0x4C8F);
    public  Action Unknown0x1ED_0x2DBF_0x4C8F()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x1834_0x3704();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x37B2_0x5682();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2E52, "unknown", this::unknown0x1ED_0x2E52_0x4D22);
    public  Action Unknown0x1ED_0x2E52_0x4D22()
    {

        // unknown_0x1ED_0x35AD_0x547D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2E98, "unknown", this::unknown0x1ED_0x2E98_0x4D68);
    public  Action Unknown0x1ED_0x2E98_0x4D68()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2EB2, "unknown", this::unknown0x1ED_0x2EB2_0x4D82);
    public  Action Unknown0x1ED_0x2EB2_0x4D82()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x2EFB_0x4DCB();
        // unknown_0x1ED_0x2FFB_0x4ECB();
        // unknown_0x1ED_0x3090_0x4F60();
        // unknown_0x1ED_0x9285_0xB155();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD763_0xF633();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2EFB, "unknown", this::unknown0x1ED_0x2EFB_0x4DCB);
    public  Action Unknown0x1ED_0x2EFB_0x4DCB()
    {

        // time.setHourOfTheDayToAX_0x1ED_0x1AE0_0x39B0 overriden();
        // unknown_0x1ED_0x7F27_0x9DF7();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x2FFB, "unknown", this::unknown0x1ED_0x2FFB_0x4ECB);
    public  Action Unknown0x1ED_0x2FFB_0x4ECB()
    {

        // unknown_0x1ED_0x3EFE_0x5DCE();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        // unknown_0x1ED_0xD741_0xF611();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3090, "unknown", this::unknown0x1ED_0x3090_0x4F60);
    public  Action Unknown0x1ED_0x3090_0x4F60()
    {

        // unknown_0x1ED_0x3127_0x4FF7();
        // unknown_0x1ED_0x36EE_0x55BE();
        // unknown_0x1ED_0x98E6_0xB7B6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3093, "unknown", this::unknown0x1ED_0x3093_0x4F63);
    public  Action Unknown0x1ED_0x3093_0x4F63()
    {

        // unknown_0x1ED_0x3127_0x4FF7();
        // unknown_0x1ED_0x36EE_0x55BE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x30B9, "unknown", this::unknown0x1ED_0x30B9_0x4F89);
    public  Action Unknown0x1ED_0x30B9_0x4F89()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3120, "unknown", this::unknown0x1ED_0x3120_0x4FF0);
    public  Action Unknown0x1ED_0x3120_0x4FF0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3127, "unknown", this::unknown0x1ED_0x3127_0x4FF7);
    public  Action Unknown0x1ED_0x3127_0x4FF7()
    {

        // unknown_0x1ED_0x331E_0x51EE();
        // unknown_0x1ED_0x6603_0x84D3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x316E, "unknown", this::unknown0x1ED_0x316E_0x503E);
    public  Action Unknown0x1ED_0x316E_0x503E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x31F6, "unknown", this::unknown0x1ED_0x31F6_0x50C6);
    public  Action Unknown0x1ED_0x31F6_0x50C6()
    {

        // unknown_0x1ED_0x1AC5_0x3995();
        // unknown_0x1ED_0x329D_0x516D();
        // unknown_0x1ED_0x32C7_0x5197();
        // unknown_0x1ED_0x3310_0x51E0();
        // unknown_0x1ED_0x331E_0x51EE();
        // unknown_0x1ED_0x693B_0x880B();
        // unknown_0x1ED_0x6EFD_0x8DCD();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x329D, "unknown", this::unknown0x1ED_0x329D_0x516D);
    public  Action Unknown0x1ED_0x329D_0x516D()
    {

        // unknown_0x1ED_0x6EFD_0x8DCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x32C7, "unknown", this::unknown0x1ED_0x32C7_0x5197);
    public  Action Unknown0x1ED_0x32C7_0x5197()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3310, "unknown", this::unknown0x1ED_0x3310_0x51E0);
    public  Action Unknown0x1ED_0x3310_0x51E0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x331E, "unknown", this::unknown0x1ED_0x331E_0x51EE);
    public  Action Unknown0x1ED_0x331E_0x51EE()
    {

        // unknown_0x1ED_0x3385_0x5255();
        // unknown_0x1ED_0x33BE_0x528E();
        // unknown_0x1ED_0x34A5_0x5375();
        // unknown_0x1ED_0x5274_0x7144();
        // unknown_0x1ED_0x7F27_0x9DF7();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3385, "unknown", this::unknown0x1ED_0x3385_0x5255);
    public  Action Unknown0x1ED_0x3385_0x5255()
    {

        // unknown_0x1ED_0x33AD_0x527D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x33AD, "unknown", this::unknown0x1ED_0x33AD_0x527D);
    public  Action Unknown0x1ED_0x33AD_0x527D()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x33BE, "unknown", this::unknown0x1ED_0x33BE_0x528E);
    public  Action Unknown0x1ED_0x33BE_0x528E()
    {

        // unknown_0x1ED_0x33D9_0x52A9();
        // unknown_0x1ED_0x6603_0x84D3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x33D9, "unknown", this::unknown0x1ED_0x33D9_0x52A9);
    public  Action Unknown0x1ED_0x33D9_0x52A9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3406, "unknown", this::unknown0x1ED_0x3406_0x52D6);
    public  Action Unknown0x1ED_0x3406_0x52D6()
    {

        // unknown_0x1ED_0x342D_0x52FD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x342D, "unknown", this::unknown0x1ED_0x342D_0x52FD);
    public  Action Unknown0x1ED_0x342D_0x52FD()
    {

        // unknown_0x1ED_0x6EFD_0x8DCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x34A5, "unknown", this::unknown0x1ED_0x34A5_0x5375);
    public  Action Unknown0x1ED_0x34A5_0x5375()
    {

        // unknown_0x1ED_0x6639_0x8509();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x34D0, "unknown", this::unknown0x1ED_0x34D0_0x53A0);
    public  Action Unknown0x1ED_0x34D0_0x53A0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3520, "unknown", this::unknown0x1ED_0x3520_0x53F0);
    public  Action Unknown0x1ED_0x3520_0x53F0()
    {

        // unknown_0x1ED_0x2A51_0x4921();
        // unknown_0x1ED_0x2AAF_0x497F();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x96F1_0xB5C1();
        // unknown_0x1ED_0xD280_0xF150();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3551, "unknown", this::unknown0x1ED_0x3551_0x5421);
    public  Action Unknown0x1ED_0x3551_0x5421()
    {

        // unknown_0x1ED_0xD323_0xF1F3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x35AD, "unknown", this::unknown0x1ED_0x35AD_0x547D);
    public  Action Unknown0x1ED_0x35AD_0x547D()
    {

        // unknown_0x1ED_0x3520_0x53F0();
        // unknown_0x1ED_0x3551_0x5421();
        // unknown_0x1ED_0x366F_0x553F();
        // unknown_0x1ED_0x368B_0x555B();
        // unknown_0x1ED_0x40F9_0x5FC9();
        // unknown_0x1ED_0x4182_0x6052();
        // unknown_0x1ED_0x96D8_0xB5A8();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x366F, "unknown", this::unknown0x1ED_0x366F_0x553F);
    public  Action Unknown0x1ED_0x366F_0x553F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x368B, "unknown", this::unknown0x1ED_0x368B_0x555B);
    public  Action Unknown0x1ED_0x368B_0x555B()
    {

        // unknown_0x1ED_0x978E_0xB65E();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC2F2_0xE1C2();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x36D3, "unknown", this::unknown0x1ED_0x36D3_0x55A3);
    public  Action Unknown0x1ED_0x36D3_0x55A3()
    {

        // unknown_0x1ED_0x36EE_0x55BE();
        // unknown_0x1ED_0x98B2_0xB782();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x36EE, "unknown", this::unknown0x1ED_0x36EE_0x55BE);
    public  Action Unknown0x1ED_0x36EE_0x55BE()
    {

        // unknown_0x1ED_0x30B9_0x4F89();
        // unknown_0x1ED_0x3120_0x4FF0();
        // unknown_0x1ED_0x3520_0x53F0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x37B2, "unknown", this::unknown0x1ED_0x37B2_0x5682);
    public  Action Unknown0x1ED_0x37B2_0x5682()
    {

        // unknown_0x1ED_0x37EB_0x56BB();
        // unknown_0x1ED_0x380C_0x56DC();
        // unknown_0x1ED_0x38B4_0x5784();
        // unknown_0x1ED_0x395C_0x582C();
        // unknown_0x1ED_0x3971_0x5841();
        // unknown_0x1ED_0x398C_0x585C();
        // unknown_0x1ED_0x39E6_0x58B6();
        // unknown_0x1ED_0x3A95_0x5965();
        // unknown_0x1ED_0x3AA9_0x5979();
        // mainCode.fill47F8WithFF_0x1ED_0x3AE9_0x59B9 overriden();
        // ida.draw_SAL_ida_0x1ED_0x3B59_0x5A29();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x4988_0x6858();
        // unknown_0x1ED_0x4A5A_0x692A();
        // unknown_0x1ED_0x4D00_0x6BD0();
        // unknown_0x1ED_0x4E12_0x6CE2();
        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // unknown_0x1ED_0x98E6_0xB7B6();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC432_0xE302();
        // ida.hnm_load_ida_0x1ED_0xCA1B_0xE8EB();
        // vgaDriver.copy_pal2_to_pal1_0x2538_0x17B_0x254FB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x37B5, "unknown", this::unknown0x1ED_0x37B5_0x5685);
    public  Action Unknown0x1ED_0x37B5_0x5685()
    {

        // unknown_0x1ED_0x39E6_0x58B6();
        // mainCode.fill47F8WithFF_0x1ED_0x3AE9_0x59B9 overriden();
        // ida.draw_SAL_ida_0x1ED_0x3B59_0x5A29();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x4D00_0x6BD0();
        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // unknown_0x1ED_0xC432_0xE302();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x37EB, "unknown", this::unknown0x1ED_0x37EB_0x56BB);
    public  Action Unknown0x1ED_0x37EB_0x56BB()
    {

        // unknown_0x1ED_0x380C_0x56DC();
        // unknown_0x1ED_0x4E12_0x6CE2();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x37F4, "unknown", this::unknown0x1ED_0x37F4_0x56C4);
    public  Action Unknown0x1ED_0x37F4_0x56C4()
    {

        // unknown_0x1ED_0x395C_0x582C();
        // unknown_0x1ED_0x3971_0x5841();
        // unknown_0x1ED_0x398C_0x585C();
        // unknown_0x1ED_0x4988_0x6858();
        // unknown_0x1ED_0x4A5A_0x692A();
        // ida.hnm_load_ida_0x1ED_0xCA1B_0xE8EB();
        // vgaDriver.copy_pal2_to_pal1_0x2538_0x17B_0x254FB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x380C, "unknown", this::unknown0x1ED_0x380C_0x56DC);
    public  Action Unknown0x1ED_0x380C_0x56DC()
    {

        // unknown_0x1ED_0x388D_0x575D();
        // ida.calc_SAL_index_ida_0x1ED_0x5E4F_0x7D1F();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x388D, "unknown", this::unknown0x1ED_0x388D_0x575D);
    public  Action Unknown0x1ED_0x388D_0x575D()
    {

        // unknown_0x1ED_0x395C_0x582C();
        // unknown_0x1ED_0x3971_0x5841();
        // unknown_0x1ED_0x398C_0x585C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x38B4, "unknown", this::unknown0x1ED_0x38B4_0x5784);
    public  Action Unknown0x1ED_0x38B4_0x5784()
    {

        // unknown_0x1ED_0x388D_0x575D();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x38E1, "unknown", this::unknown0x1ED_0x38E1_0x57B1);
    public  Action Unknown0x1ED_0x38E1_0x57B1()
    {

        // unknown_0x1ED_0x395C_0x582C();
        // unknown_0x1ED_0x3971_0x5841();
        // unknown_0x1ED_0x39B9_0x5889();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x38F1, "unknown", this::unknown0x1ED_0x38F1_0x57C1);
    public  Action Unknown0x1ED_0x38F1_0x57C1()
    {

        // unknown_0x1ED_0x3971_0x5841();
        // unknown_0x1ED_0x39B9_0x5889();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3916, "unknown", this::unknown0x1ED_0x3916_0x57E6);
    public  Action Unknown0x1ED_0x3916_0x57E6()
    {

        // unknown_0x2538_0x175_0x254F5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3950, "unknown", this::unknown0x1ED_0x3950_0x5820);
    public  Action Unknown0x1ED_0x3950_0x5820()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x395C, "unknown", this::unknown0x1ED_0x395C_0x582C);
    public  Action Unknown0x1ED_0x395C_0x582C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3971, "unknown", this::unknown0x1ED_0x3971_0x5841);
    public  Action Unknown0x1ED_0x3971_0x5841()
    {

        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x398C, "unknown", this::unknown0x1ED_0x398C_0x585C);
    public  Action Unknown0x1ED_0x398C_0x585C()
    {

        // unknown_0x2538_0x106_0x25486();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x39B9, "unknown", this::unknown0x1ED_0x39B9_0x5889);
    public  Action Unknown0x1ED_0x39B9_0x5889()
    {

        // unknown_0x2538_0x172_0x254F2();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x39E6, "unknown", this::unknown0x1ED_0x39E6_0x58B6);
    public  Action Unknown0x1ED_0x39E6_0x58B6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3A73, "unknown", this::unknown0x1ED_0x3A73_0x5943);
    public  Action Unknown0x1ED_0x3A73_0x5943()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3A7C, "unknown", this::unknown0x1ED_0x3A7C_0x594C);
    public  Action Unknown0x1ED_0x3A7C_0x594C()
    {

        // unknown_0x1ED_0x39E6_0x58B6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3A95, "unknown", this::unknown0x1ED_0x3A95_0x5965);
    public  Action Unknown0x1ED_0x3A95_0x5965()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3AA9, "unknown", this::unknown0x1ED_0x3AA9_0x5979);
    public  Action Unknown0x1ED_0x3AA9_0x5979()
    {

        // unknown_0x1ED_0xC305_0xE1D5();
        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // Not providing stub for mainCode.fill47F8WithFF. Reason: Function already has an override
    // defineFunction(0x1ED, 0x3AF9, "unknown", this::unknown0x1ED_0x3AF9_0x59C9);
    public  Action Unknown0x1ED_0x3AF9_0x59C9()
    {

        // unknown_0x1ED_0x37B5_0x5685();
        // vgaDriver.copySquareOfPixelsSiIsSourceSegment_0x2538_0x12A_0x254AA overriden();
        // unknown_0x2538_0x16F_0x254EF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3B59, "draw_SAL_ida", this::draw_SAL_ida0x1ED_0x3B59_0x5A29);
    public  Action Draw_SAL_ida0x1ED_0x3B59_0x5A29()
    {

        // ida.SAL_polygon_ida_0x1ED_0x3BE9_0x5AB9();
        // unknown_0x1ED_0x3D2F_0x5BFF();
        // ida.do_weird_shit_with_stack_buffer_ida_0x1ED_0x3D83_0x5C53();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x2538_0x139_0x254B9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3BE9, "SAL_polygon_ida", this::SAL_polygon_ida0x1ED_0x3BE9_0x5AB9);
    public  Action SAL_polygon_ida0x1ED_0x3BE9_0x5AB9()
    {

        // unknown_0x1ED_0x3E13_0x5CE3();
        // vgaDriver.generateTextureOutBP_0x2538_0x16C_0x254EC overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3D2F, "unknown", this::unknown0x1ED_0x3D2F_0x5BFF);
    public  Action Unknown0x1ED_0x3D2F_0x5BFF()
    {

        // unknown_0x1ED_0x127C_0x314C();
        // unknown_0x1ED_0x9123_0xAFF3();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3D83, "do_weird_shit_with_stack_buffer_ida",
    // this::do_weird_shit_with_stack_buffer_ida0x1ED_0x3D83_0x5C53);
    public  Action Do_weird_shit_with_stack_buffer_ida0x1ED_0x3D83_0x5C53()
    {

        // unknown_0x1ED_0x3DF4_0x5CC4();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3DF4, "unknown", this::unknown0x1ED_0x3DF4_0x5CC4);
    public  Action Unknown0x1ED_0x3DF4_0x5CC4()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3E13, "unknown", this::unknown0x1ED_0x3E13_0x5CE3);
    public  Action Unknown0x1ED_0x3E13_0x5CE3()
    {

        // unknown_0x1ED_0x3E80_0x5D50();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3E80, "unknown", this::unknown0x1ED_0x3E80_0x5D50);
    public  Action Unknown0x1ED_0x3E80_0x5D50()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3EFE, "unknown", this::unknown0x1ED_0x3EFE_0x5DCE);
    public  Action Unknown0x1ED_0x3EFE_0x5DCE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3F15, "unknown", this::unknown0x1ED_0x3F15_0x5DE5);
    public  Action Unknown0x1ED_0x3F15_0x5DE5()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x2170_0x4040();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x409A_0x5F6A();
        // unknown_0x1ED_0x40AE_0x5F7E();
        // unknown_0x1ED_0x40C3_0x5F93();
        // unknown_0x1ED_0x425B_0x612B();
        // unknown_0x1ED_0x503C_0x6F0C();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xABD5_0xCAA5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xB532_0xD402();
        // unknown_0x1ED_0xB5CF_0xD49F();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC412_0xE2E2();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3F1A, "unknown", this::unknown0x1ED_0x3F1A_0x5DEA);
    public  Action Unknown0x1ED_0x3F1A_0x5DEA()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x1834_0x3704();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x40C3_0x5F93();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xABD5_0xCAA5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xD2BD_0xF18D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3F1F, "unknown", this::unknown0x1ED_0x3F1F_0x5DEF);
    public  Action Unknown0x1ED_0x3F1F_0x5DEF()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0x1834_0x3704();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x40C3_0x5F93();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xABD5_0xCAA5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // unknown_0x1ED_0xB5CF_0xD49F();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xC412_0xE2E2();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x3F24, "unknown", this::unknown0x1ED_0x3F24_0x5DF4);
    public  Action Unknown0x1ED_0x3F24_0x5DF4()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x1834_0x3704();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x40C3_0x5F93();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xABD5_0xCAA5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xD2BD_0xF18D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4057, "unknown", this::unknown0x1ED_0x4057_0x5F27);
    public  Action Unknown0x1ED_0x4057_0x5F27()
    {

        // unknown_0x1ED_0x40C3_0x5F93();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x407E, "unknown", this::unknown0x1ED_0x407E_0x5F4E);
    public  Action Unknown0x1ED_0x407E_0x5F4E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x409A, "unknown", this::unknown0x1ED_0x409A_0x5F6A);
    public  Action Unknown0x1ED_0x409A_0x5F6A()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40AE, "unknown", this::unknown0x1ED_0x40AE_0x5F7E);
    public  Action Unknown0x1ED_0x40AE_0x5F7E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40C3, "unknown", this::unknown0x1ED_0x40C3_0x5F93);
    public  Action Unknown0x1ED_0x40C3_0x5F93()
    {

        // unknown_0x1ED_0x40C9_0x5F99();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40C9, "unknown", this::unknown0x1ED_0x40C9_0x5F99);
    public  Action Unknown0x1ED_0x40C9_0x5F99()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40D5, "unknown", this::unknown0x1ED_0x40D5_0x5FA5);
    public  Action Unknown0x1ED_0x40D5_0x5FA5()
    {

        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x40E6_0x5FB6();
        // mainCode.setUnknown11CATo0_0x1ED_0x4AC4_0x6994 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40E6, "unknown", this::unknown0x1ED_0x40E6_0x5FB6);
    public  Action Unknown0x1ED_0x40E6_0x5FB6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x40F9, "unknown", this::unknown0x1ED_0x40F9_0x5FC9);
    public  Action Unknown0x1ED_0x40F9_0x5FC9()
    {

        // unknown_0x1ED_0x2EFB_0x4DCB();
        // unknown_0x1ED_0x2FFB_0x4ECB();
        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x409A_0x5F6A();
        // unknown_0x1ED_0x425B_0x612B();
        // unknown_0x1ED_0x4944_0x6814();
        // unknown_0x1ED_0x5124_0x6FF4();
        // unknown_0x1ED_0x6231_0x8101();
        // unknown_0x1ED_0xB56C_0xD43C();
        // unknown_0x1ED_0xD397_0xF267();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4182, "unknown", this::unknown0x1ED_0x4182_0x6052);
    public  Action Unknown0x1ED_0x4182_0x6052()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x5D36_0x7C06();
        // unknown_0x1ED_0xB532_0xD402();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x41C5, "unknown", this::unknown0x1ED_0x41C5_0x6095);
    public  Action Unknown0x1ED_0x41C5_0x6095()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x41E1, "unknown", this::unknown0x1ED_0x41E1_0x60B1);
    public  Action Unknown0x1ED_0x41E1_0x60B1()
    {

        // unknown_0x1ED_0x409A_0x5F6A();
        // unknown_0x1ED_0x5124_0x6FF4();
        // ida.calc_SAL_index_ida_0x1ED_0x5E4F_0x7D1F();
        // unknown_0x1ED_0xB56C_0xD43C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x425B, "unknown", this::unknown0x1ED_0x425B_0x612B);
    public  Action Unknown0x1ED_0x425B_0x612B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x439F, "unknown", this::unknown0x1ED_0x439F_0x626F);
    public  Action Unknown0x1ED_0x439F_0x626F()
    {

        // unknown_0x1ED_0x38B4_0x5784();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x43E3, "unknown", this::unknown0x1ED_0x43E3_0x62B3);
    public  Action Unknown0x1ED_0x43E3_0x62B3()
    {

        // unknown_0x1ED_0x388D_0x575D();
        // unknown_0x1ED_0x4ABE_0x698E();
        // unknown_0x1ED_0xC43E_0xE30E();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4415, "unknown", this::unknown0x1ED_0x4415_0x62E5);
    public  Action Unknown0x1ED_0x4415_0x62E5()
    {

        // unknown_0x1ED_0x2FFB_0x4ECB();
        // unknown_0x1ED_0x43E3_0x62B3();
        // unknown_0x1ED_0x469B_0x656B();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xD717_0xF5E7();
        // map.setMapClickHandlerAddressToInGame_0x1ED_0xD95B_0xF82B overriden();
        // unknown_0x1ED_0xDA5F_0xF92F();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x445D, "unknown", this::unknown0x1ED_0x445D_0x632D);
    public  Action Unknown0x1ED_0x445D_0x632D()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x5B93_0x7A63();
        // unknown_0x1ED_0x62D6_0x81A6();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x1ED_0xC30D_0xE1DD();
        // unknown_0x1ED_0xC4FB_0xE3CB();
        // unknown_0x1ED_0xDA25_0xF8F5();
        // unknown_0x1ED_0xDA5F_0xF92F();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x44AB, "unknown", this::unknown0x1ED_0x44AB_0x637B);
    public  Action Unknown0x1ED_0x44AB_0x637B()
    {

        // unknown_0x1ED_0x5B93_0x7A63();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC30D_0xE1DD();
        // unknown_0x1ED_0xC4FB_0xE3CB();
        // unknown_0x1ED_0xDB74_0xFA44();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x450E, "unknown", this::unknown0x1ED_0x450E_0x63DE);
    public  Action Unknown0x1ED_0x450E_0x63DE()
    {

        // unknown_0x1ED_0x181E_0x36EE();
        // unknown_0x1ED_0x2DBF_0x4C8F();
        // unknown_0x1ED_0x2EB2_0x4D82();
        // unknown_0x1ED_0x38E1_0x57B1();
        // unknown_0x1ED_0x40D5_0x5FA5();
        // unknown_0x1ED_0x41C5_0x6095();
        // unknown_0x1ED_0x456C_0x643C();
        // unknown_0x1ED_0x4586_0x6456();
        // unknown_0x1ED_0x45DE_0x64AE();
        // unknown_0x1ED_0x4795_0x6665();
        // unknown_0x1ED_0x4944_0x6814();
        // unknown_0x1ED_0x4AB8_0x6988();
        // unknown_0x1ED_0x4B3B_0x6A0B();
        // unknown_0x1ED_0x4D00_0x6BD0();
        // ida.close_res_file_handle_ida_0x1ED_0xA9A1_0xC871();
        // unknown_0x1ED_0xAB45_0xCA15();
        // unknown_0x1ED_0xABA9_0xCA79();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xC474_0xE344();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // unknown_0x1ED_0xDA5F_0xF92F();
        // unknown_0x1ED_0xE3A0_0x10270();
        // unknown_0x2538_0x160_0x254E0();
        // soundDriverPcSpeaker.clearAL_0x4822_0x109_0x48329 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x456C, "unknown", this::unknown0x1ED_0x456C_0x643C);
    public  Action Unknown0x1ED_0x456C_0x643C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4586, "unknown", this::unknown0x1ED_0x4586_0x6456);
    public  Action Unknown0x1ED_0x4586_0x6456()
    {

        // unknown_0x1ED_0x469B_0x656B();
        // unknown_0x1ED_0x514E_0x701E();
        // unknown_0x1ED_0x5D1D_0x7BED();
        // unknown_0x1ED_0x5E6D_0x7D3D();
        // unknown_0x1ED_0x629D_0x816D();
        // unknown_0x1ED_0x62A6_0x8176();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD19B_0xF06B();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x45DE, "unknown", this::unknown0x1ED_0x45DE_0x64AE);
    public  Action Unknown0x1ED_0x45DE_0x64AE()
    {

        // unknown_0x1ED_0x4658_0x6528();
        // unknown_0x1ED_0x469B_0x656B();
        // unknown_0x1ED_0x629D_0x816D();
        // unknown_0x1ED_0x62A6_0x8176();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD19B_0xF06B();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4658, "unknown", this::unknown0x1ED_0x4658_0x6528);
    public  Action Unknown0x1ED_0x4658_0x6528()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xDA25_0xF8F5();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x469B, "unknown", this::unknown0x1ED_0x469B_0x656B);
    public  Action Unknown0x1ED_0x469B_0x656B()
    {

        // unknown_0x1ED_0xDA5F_0xF92F();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x46B5, "unknown", this::unknown0x1ED_0x46B5_0x6585);
    public  Action Unknown0x1ED_0x46B5_0x6585()
    {

        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xDB67_0xFA37();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4795, "unknown", this::unknown0x1ED_0x4795_0x6665);
    public  Action Unknown0x1ED_0x4795_0x6665()
    {

        // unknown_0x1ED_0x181E_0x36EE();
        // unknown_0x1ED_0x37B2_0x5682();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // ida.audio_start_voc_ida_0x1ED_0xAB15_0xC9E5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xCE53_0xED23();
        // unknown_0x1ED_0xE353_0x10223();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4821, "unknown", this::unknown0x1ED_0x4821_0x66F1);
    public  Action Unknown0x1ED_0x4821_0x66F1()
    {

        // unknown_0x1ED_0x3A73_0x5943();
        // unknown_0x1ED_0x3A95_0x5965();
        // unknown_0x1ED_0x3AA9_0x5979();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC43E_0xE30E();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4944, "unknown", this::unknown0x1ED_0x4944_0x6814);
    public  Action Unknown0x1ED_0x4944_0x6814()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x50BE_0x6F8E();
        // unknown_0x1ED_0x5124_0x6FF4();
        // unknown_0x1ED_0x5133_0x7003();
        // unknown_0x1ED_0xB5F9_0xD4C9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4988, "unknown", this::unknown0x1ED_0x4988_0x6858);
    public  Action Unknown0x1ED_0x4988_0x6858()
    {

        // unknown_0x1ED_0x5B5D_0x7A2D();
        // unknown_0x1ED_0x5B69_0x7A39();
        // unknown_0x1ED_0x5B93_0x7A63();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x62C9_0x8199();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida_0x1ED_0xC085_0xDF55 overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x49EA, "unknown", this::unknown0x1ED_0x49EA_0x68BA);
    public  Action Unknown0x1ED_0x49EA_0x68BA()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4A00, "unknown", this::unknown0x1ED_0x4A00_0x68D0);
    public  Action Unknown0x1ED_0x4A00_0x68D0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4A1A, "unknown", this::unknown0x1ED_0x4A1A_0x68EA);
    public  Action Unknown0x1ED_0x4A1A_0x68EA()
    {

        // unknown_0x1ED_0x62D6_0x81A6();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida_0x1ED_0xC085_0xDF55 overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4A5A, "unknown", this::unknown0x1ED_0x4A5A_0x692A);
    public  Action Unknown0x1ED_0x4A5A_0x692A()
    {

        // unknown_0x1ED_0x62D6_0x81A6();
        // display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida_0x1ED_0xC085_0xDF55 overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4AB8, "unknown", this::unknown0x1ED_0x4AB8_0x6988);
    public  Action Unknown0x1ED_0x4AB8_0x6988()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4ABE, "unknown", this::unknown0x1ED_0x4ABE_0x698E);
    public  Action Unknown0x1ED_0x4ABE_0x698E()
    {

        // unknown_0x1ED_0x37F4_0x56C4();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        return NearRet();
    }

    // Not providing stub for mainCode.setUnknown11CATo0. Reason: Function already has an override
    // Not providing stub for mainCode.setUnknown11CATo1. Reason: Function already has an override
    // defineFunction(0x1ED, 0x4B2B, "unknown", this::unknown0x1ED_0x4B2B_0x69FB);
    public  Action Unknown0x1ED_0x4B2B_0x69FB()
    {

        // unknown_0x1ED_0xC46F_0xE33F();
        // vgaDriver.restoreImageUnderMouseCursor_0x2538_0x10C_0x2548C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4B3B, "unknown", this::unknown0x1ED_0x4B3B_0x6A0B);
    public  Action Unknown0x1ED_0x4B3B_0x6A0B()
    {

        // unknown_0x1ED_0xFD9_0x2EA9();
        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x40C3_0x5F93();
        // unknown_0x1ED_0x5206_0x70D6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4D00, "unknown", this::unknown0x1ED_0x4D00_0x6BD0);
    public  Action Unknown0x1ED_0x4D00_0x6BD0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4DED, "unknown", this::unknown0x1ED_0x4DED_0x6CBD);
    public  Action Unknown0x1ED_0x4DED_0x6CBD()
    {

        // unknown_0x1ED_0x661D_0x84ED();
        // unknown_0x1ED_0x7F27_0x9DF7();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4E12, "unknown", this::unknown0x1ED_0x4E12_0x6CE2);
    public  Action Unknown0x1ED_0x4E12_0x6CE2()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x409A_0x5F6A();
        // unknown_0x1ED_0x4DED_0x6CBD();
        // unknown_0x1ED_0x4EC6_0x6D96();
        // ida.calc_SAL_index_ida_0x1ED_0x5E4F_0x7D1F();
        // unknown_0x1ED_0xB532_0xD402();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4EC6, "unknown", this::unknown0x1ED_0x4EC6_0x6D96);
    public  Action Unknown0x1ED_0x4EC6_0x6D96()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x4F0C, "unknown", this::unknown0x1ED_0x4F0C_0x6DDC);
    public  Action Unknown0x1ED_0x4F0C_0x6DDC()
    {

        // unknown_0x1ED_0x2E52_0x4D22();
        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x41E1_0x60B1();
        // unknown_0x1ED_0x4A00_0x68D0();
        // unknown_0x1ED_0x4A1A_0x68EA();
        // unknown_0x1ED_0x4B3B_0x6A0B();
        // unknown_0x1ED_0x5206_0x70D6();
        // unknown_0x1ED_0x62D6_0x81A6();
        // unknown_0x1ED_0xB532_0xD402();
        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida_0x1ED_0xC085_0xDF55 overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // ida.hnm_do_frame_ida_0x1ED_0xCA60_0xE930();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x503C, "unknown", this::unknown0x1ED_0x503C_0x6F0C);
    public  Action Unknown0x1ED_0x503C_0x6F0C()
    {

        // unknown_0x1ED_0x5D36_0x7C06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x50BE, "unknown", this::unknown0x1ED_0x50BE_0x6F8E);
    public  Action Unknown0x1ED_0x50BE_0x6F8E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5124, "unknown", this::unknown0x1ED_0x5124_0x6FF4);
    public  Action Unknown0x1ED_0x5124_0x6FF4()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x5133_0x7003();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5133, "unknown", this::unknown0x1ED_0x5133_0x7003);
    public  Action Unknown0x1ED_0x5133_0x7003()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x514E, "unknown", this::unknown0x1ED_0x514E_0x701E);
    public  Action Unknown0x1ED_0x514E_0x701E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5198, "unknown", this::unknown0x1ED_0x5198_0x7068);
    public  Action Unknown0x1ED_0x5198_0x7068()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x51CB, "unknown", this::unknown0x1ED_0x51CB_0x709B);
    public  Action Unknown0x1ED_0x51CB_0x709B()
    {

        // unknown_0x1ED_0x5124_0x6FF4();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5206, "unknown", this::unknown0x1ED_0x5206_0x70D6);
    public  Action Unknown0x1ED_0x5206_0x70D6()
    {

        // unknown_0x1ED_0x5198_0x7068();
        // unknown_0x1ED_0x51CB_0x709B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5274, "unknown", this::unknown0x1ED_0x5274_0x7144);
    public  Action Unknown0x1ED_0x5274_0x7144()
    {

        // unknown_0x1ED_0x5323_0x71F3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5323, "unknown", this::unknown0x1ED_0x5323_0x71F3);
    public  Action Unknown0x1ED_0x5323_0x71F3()
    {

        // unknown_0x1ED_0x5133_0x7003();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x541F, "unknown", this::unknown0x1ED_0x541F_0x72EF);
    public  Action Unknown0x1ED_0x541F_0x72EF()
    {

        // unknown_0x1ED_0x557B_0x744B();
        // unknown_0x1ED_0x5584_0x7454();
        // unknown_0x1ED_0x5605_0x74D5();
        // unknown_0x1ED_0x563E_0x750E();
        // unknown_0x1ED_0x58E4_0x77B4();
        // unknown_0x1ED_0x5B8D_0x7A5D();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x62F2_0x81C2();
        // unknown_0x1ED_0x813E_0xA00E();
        // unknown_0x1ED_0xB647_0xD517();
        // unknown_0x1ED_0xB69A_0xD56A();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC0E8_0xDFB8();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC13B_0xE00B();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // ida.rect_at_si_to_regs_ida_0x1ED_0xC4F0_0xE3C0();
        // unknown_0x1ED_0xC560_0xE430();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x542F, "unknown", this::unknown0x1ED_0x542F_0x72FF);
    public  Action Unknown0x1ED_0x542F_0x72FF()
    {

        // unknown_0x1ED_0x557B_0x744B();
        // unknown_0x1ED_0x5584_0x7454();
        // unknown_0x1ED_0x5605_0x74D5();
        // unknown_0x1ED_0x563E_0x750E();
        // unknown_0x1ED_0x58E4_0x77B4();
        // unknown_0x1ED_0x5B8D_0x7A5D();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x62F2_0x81C2();
        // unknown_0x1ED_0x813E_0xA00E();
        // unknown_0x1ED_0xB647_0xD517();
        // unknown_0x1ED_0xB69A_0xD56A();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC13B_0xE00B();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // ida.rect_at_si_to_regs_ida_0x1ED_0xC4F0_0xE3C0();
        // unknown_0x1ED_0xC560_0xE430();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x557B, "unknown", this::unknown0x1ED_0x557B_0x744B);
    public  Action Unknown0x1ED_0x557B_0x744B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5584, "unknown", this::unknown0x1ED_0x5584_0x7454);
    public  Action Unknown0x1ED_0x5584_0x7454()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5605, "unknown", this::unknown0x1ED_0x5605_0x74D5);
    public  Action Unknown0x1ED_0x5605_0x74D5()
    {

        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x563E, "unknown", this::unknown0x1ED_0x563E_0x750E);
    public  Action Unknown0x1ED_0x563E_0x750E()
    {

        // unknown_0x1ED_0x557B_0x744B();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD194_0xF064();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5692, "unknown", this::unknown0x1ED_0x5692_0x7562);
    public  Action Unknown0x1ED_0x5692_0x7562()
    {

        // unknown_0x1ED_0x557B_0x744B();
        // unknown_0x1ED_0x5605_0x74D5();
        // unknown_0x1ED_0x56ED_0x75BD();
        // unknown_0x1ED_0x629D_0x816D();
        // unknown_0x1ED_0x62A6_0x8176();
        // unknown_0x1ED_0x6639_0x8509();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD1BB_0xF08B();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x56ED, "unknown", this::unknown0x1ED_0x56ED_0x75BD);
    public  Action Unknown0x1ED_0x56ED_0x75BD()
    {

        // unknown_0x1ED_0xC2FD_0xE1CD();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD12F_0xEFFF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5728, "unknown", this::unknown0x1ED_0x5728_0x75F8);
    public  Action Unknown0x1ED_0x5728_0x75F8()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5746, "unknown", this::unknown0x1ED_0x5746_0x7616);
    public  Action Unknown0x1ED_0x5746_0x7616()
    {

        // unknown_0x1ED_0x557B_0x744B();
        // unknown_0x1ED_0x57B2_0x7682();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // unknown_0x2538_0x184_0x25504();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x57B2, "unknown", this::unknown0x1ED_0x57B2_0x7682);
    public  Action Unknown0x1ED_0x57B2_0x7682()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x57E5, "unknown", this::unknown0x1ED_0x57E5_0x76B5);
    public  Action Unknown0x1ED_0x57E5_0x76B5()
    {

        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x58E4, "unknown", this::unknown0x1ED_0x58E4_0x77B4);
    public  Action Unknown0x1ED_0x58E4_0x77B4()
    {

        // unknown_0x1ED_0x57E5_0x76B5();
        // unknown_0x2538_0x17E_0x254FE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x58FA, "unknown", this::unknown0x1ED_0x58FA_0x77CA);
    public  Action Unknown0x1ED_0x58FA_0x77CA()
    {

        // unknown_0x1ED_0x5AD9_0x79A9();
        // unknown_0x1ED_0xC6AD_0xE57D();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5944, "unknown", this::unknown0x1ED_0x5944_0x7814);
    public  Action Unknown0x1ED_0x5944_0x7814()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x599F, "unknown", this::unknown0x1ED_0x599F_0x786F);
    public  Action Unknown0x1ED_0x599F_0x786F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5A1A, "unknown", this::unknown0x1ED_0x5A1A_0x78EA);
    public  Action Unknown0x1ED_0x5A1A_0x78EA()
    {

        // unknown_0x1ED_0x18BA_0x378A();
        // unknown_0x1ED_0x5B5D_0x7A2D();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5A56, "unknown", this::unknown0x1ED_0x5A56_0x7926);
    public  Action Unknown0x1ED_0x5A56_0x7926()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x5A9A_0x796A();
        // unknown_0x1ED_0x5B69_0x7A39();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xB930_0xD800();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD741_0xF611();
        // unknown_0x1ED_0xD792_0xF662();
        // unknown_0x1ED_0xDA25_0xF8F5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5A9A, "unknown", this::unknown0x1ED_0x5A9A_0x796A);
    public  Action Unknown0x1ED_0x5A9A_0x796A()
    {

        // unknown_0x1ED_0x5B8D_0x7A5D();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x6314_0x81E4();
        // unknown_0x1ED_0x6715_0x85E5();
        // unknown_0x1ED_0x878C_0xA65C();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xC6AD_0xE57D();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5AD3, "unknown", this::unknown0x1ED_0x5AD3_0x79A3);
    public  Action Unknown0x1ED_0x5AD3_0x79A3()
    {

        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5AD9, "unknown", this::unknown0x1ED_0x5AD9_0x79A9);
    public  Action Unknown0x1ED_0x5AD9_0x79A9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5ADF, "unknown", this::unknown0x1ED_0x5ADF_0x79AF);
    public  Action Unknown0x1ED_0x5ADF_0x79AF()
    {

        // unknown_0x1ED_0x7B36_0x9A06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5B5D, "unknown", this::unknown0x1ED_0x5B5D_0x7A2D);
    public  Action Unknown0x1ED_0x5B5D_0x7A2D()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5B69, "unknown", this::unknown0x1ED_0x5B69_0x7A39);
    public  Action Unknown0x1ED_0x5B69_0x7A39()
    {

        // unknown_0x1ED_0xC560_0xE430();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5B6E, "unknown", this::unknown0x1ED_0x5B6E_0x7A3E);
    public  Action Unknown0x1ED_0x5B6E_0x7A3E()
    {

        // unknown_0x1ED_0xC560_0xE430();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5B8D, "unknown", this::unknown0x1ED_0x5B8D_0x7A5D);
    public  Action Unknown0x1ED_0x5B8D_0x7A5D()
    {

        // map.unknownMemcopy_0x1ED_0x5B96_0x7A66 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5B93, "unknown", this::unknown0x1ED_0x5B93_0x7A63);
    public  Action Unknown0x1ED_0x5B93_0x7A63()
    {
        return NearRet();
    }

    // Not providing stub for map.unknownMemcopy. Reason: Function already has an override
    // Not providing stub for mainCode.memCopy8BytesDsSIToDsDi. Reason: Function already has an override
    // Not providing stub for mainCode.memCopy8BytesFrom1470ToD83C. Reason: Function already has an override
    // Not providing stub for mainCode.memCopy8Bytes. Reason: Function already has an override
    // defineFunction(0x1ED, 0x5BB0, "unknown", this::unknown0x1ED_0x5BB0_0x7A80);
    public  Action Unknown0x1ED_0x5BB0_0x7A80()
    {

        // unknown_0x1ED_0x7B1B_0x99EB();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD03C_0xEF0C();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xE2E3_0x101B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5BEB, "unknown", this::unknown0x1ED_0x5BEB_0x7ABB);
    public  Action Unknown0x1ED_0x5BEB_0x7ABB()
    {

        // unknown_0x1ED_0xC6AD_0xE57D();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5C03, "unknown", this::unknown0x1ED_0x5C03_0x7AD3);
    public  Action Unknown0x1ED_0x5C03_0x7AD3()
    {

        // unknown_0x1ED_0x5692_0x7562();
        // unknown_0x1ED_0x5746_0x7616();
        // unknown_0x1ED_0x5E6D_0x7D3D();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5C76, "unknown", this::unknown0x1ED_0x5C76_0x7B46);
    public  Action Unknown0x1ED_0x5C76_0x7B46()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x58FA_0x77CA();
        // unknown_0x1ED_0x5BEB_0x7ABB();
        // unknown_0x1ED_0x5E6D_0x7D3D();
        // unknown_0x1ED_0x5EE4_0x7DB4();
        // unknown_0x1ED_0x600E_0x7EDE();
        // unknown_0x1ED_0x60AC_0x7F7C();
        // unknown_0x1ED_0x6252_0x8122();
        // unknown_0x1ED_0x629D_0x816D();
        // unknown_0x1ED_0x62A6_0x8176();
        // unknown_0x1ED_0x6946_0x8816();
        // unknown_0x1ED_0x7B36_0x9A06();
        // unknown_0x1ED_0x7BA3_0x9A73();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x7D0C_0x9BDC();
        // unknown_0x1ED_0x7EE2_0x9DB2();
        // unknown_0x1ED_0x7F27_0x9DF7();
        // unknown_0x1ED_0x9719_0xB5E9();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xC13B_0xE00B();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // unknown_0x1ED_0xD280_0xF150();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD338_0xF208();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5D1D, "unknown", this::unknown0x1ED_0x5D1D_0x7BED);
    public  Action Unknown0x1ED_0x5D1D_0x7BED()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5D36, "unknown", this::unknown0x1ED_0x5D36_0x7C06);
    public  Action Unknown0x1ED_0x5D36_0x7C06()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5DCE, "unknown", this::unknown0x1ED_0x5DCE_0x7C9E);
    public  Action Unknown0x1ED_0x5DCE_0x7C9E()
    {

        // unknown_0x1ED_0x5E42_0x7D12();
        // unknown_0x1ED_0x62C9_0x8199();
        // unknown_0x1ED_0x633B_0x820B();
        // unknown_0x1ED_0x7C8F_0x9B5F();
        // unknown_0x1ED_0xC343_0xE213();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5E42, "unknown", this::unknown0x1ED_0x5E42_0x7D12);
    public  Action Unknown0x1ED_0x5E42_0x7D12()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5E4F, "calc_SAL_index_ida", this::calc_SAL_index_ida0x1ED_0x5E4F_0x7D1F);
    public  Action Calc_SAL_index_ida0x1ED_0x5E4F_0x7D1F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5E6D, "unknown", this::unknown0x1ED_0x5E6D_0x7D3D);
    public  Action Unknown0x1ED_0x5E6D_0x7D3D()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5ED0, "unknown", this::unknown0x1ED_0x5ED0_0x7DA0);
    public  Action Unknown0x1ED_0x5ED0_0x7DA0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5EE4, "unknown", this::unknown0x1ED_0x5EE4_0x7DB4);
    public  Action Unknown0x1ED_0x5EE4_0x7DB4()
    {

        // unknown_0x1ED_0x5ED0_0x7DA0();
        // unknown_0x1ED_0x6252_0x8122();
        // unknown_0x1ED_0xC0E8_0xDFB8();
        // unknown_0x1ED_0xC53E_0xE40E();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5F79, "unknown", this::unknown0x1ED_0x5F79_0x7E49);
    public  Action Unknown0x1ED_0x5F79_0x7E49()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC6AD_0xE57D();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x5F91, "unknown", this::unknown0x1ED_0x5F91_0x7E61);
    public  Action Unknown0x1ED_0x5F91_0x7E61()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // unknown_0x1ED_0xC6AD_0xE57D();
        // unknown_0x2538_0x15A_0x254DA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x600E, "unknown", this::unknown0x1ED_0x600E_0x7EDE);
    public  Action Unknown0x1ED_0x600E_0x7EDE()
    {

        // unknown_0x1ED_0x5EE4_0x7DB4();
        // unknown_0x1ED_0x60AC_0x7F7C();
        // unknown_0x1ED_0x6252_0x8122();
        // unknown_0x1ED_0x629D_0x816D();
        // unknown_0x1ED_0x62A6_0x8176();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x60AC, "unknown", this::unknown0x1ED_0x60AC_0x7F7C);
    public  Action Unknown0x1ED_0x60AC_0x7F7C()
    {

        // unknown_0x1ED_0x627E_0x814E();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD19B_0xF06B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x61D3, "unknown", this::unknown0x1ED_0x61D3_0x80A3);
    public  Action Unknown0x1ED_0x61D3_0x80A3()
    {

        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6231, "unknown", this::unknown0x1ED_0x6231_0x8101);
    public  Action Unknown0x1ED_0x6231_0x8101()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6252, "unknown", this::unknown0x1ED_0x6252_0x8122);
    public  Action Unknown0x1ED_0x6252_0x8122()
    {

        // unknown_0x1ED_0x5D36_0x7C06();
        // unknown_0x1ED_0x6231_0x8101();
        // unknown_0x1ED_0x627E_0x814E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x627E, "unknown", this::unknown0x1ED_0x627E_0x814E);
    public  Action Unknown0x1ED_0x627E_0x814E()
    {

        // unknown_0x1ED_0x5D36_0x7C06();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x629D, "unknown", this::unknown0x1ED_0x629D_0x816D);
    public  Action Unknown0x1ED_0x629D_0x816D()
    {

        // unknown_0x1ED_0x6231_0x8101();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD1BB_0xF08B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x62A6, "unknown", this::unknown0x1ED_0x62A6_0x8176);
    public  Action Unknown0x1ED_0x62A6_0x8176()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD096_0xEF66();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD1BB_0xF08B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x62C9, "unknown", this::unknown0x1ED_0x62C9_0x8199);
    public  Action Unknown0x1ED_0x62C9_0x8199()
    {

        // unknown_0x1ED_0xB647_0xD517();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x62D6, "unknown", this::unknown0x1ED_0x62D6_0x81A6);
    public  Action Unknown0x1ED_0x62D6_0x81A6()
    {

        // unknown_0x1ED_0xB647_0xD517();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x62F2, "unknown", this::unknown0x1ED_0x62F2_0x81C2);
    public  Action Unknown0x1ED_0x62F2_0x81C2()
    {

        // unknown_0x1ED_0x62C9_0x8199();
        // unknown_0x1ED_0x68EB_0x87BB();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x1ED_0xC30D_0xE1DD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6314, "unknown", this::unknown0x1ED_0x6314_0x81E4);
    public  Action Unknown0x1ED_0x6314_0x81E4()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x62D6_0x81A6();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x1ED_0xC30D_0xE1DD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x633B, "unknown", this::unknown0x1ED_0x633B_0x820B);
    public  Action Unknown0x1ED_0x633B_0x820B()
    {

        // unknown_0x1ED_0x634D_0x821D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x634D, "unknown", this::unknown0x1ED_0x634D_0x821D);
    public  Action Unknown0x1ED_0x634D_0x821D()
    {

        // unknown_0x1ED_0x62D6_0x81A6();
        // unknown_0x1ED_0x636A_0x823A();
        // unknown_0x1ED_0x639A_0x826A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x636A, "unknown", this::unknown0x1ED_0x636A_0x823A);
    public  Action Unknown0x1ED_0x636A_0x823A()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x639A, "unknown", this::unknown0x1ED_0x639A_0x826A);
    public  Action Unknown0x1ED_0x639A_0x826A()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x63F0, "map_func_qq_ida", this::map_func_qq_ida0x1ED_0x63F0_0x82C0);
    public  Action Map_func_qq_ida0x1ED_0x63F0_0x82C0()
    {

        // unknown_0x1ED_0x642E_0x82FE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x642E, "unknown", this::unknown0x1ED_0x642E_0x82FE);
    public  Action Unknown0x1ED_0x642E_0x82FE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x644E, "unknown", this::unknown0x1ED_0x644E_0x831E);
    public  Action Unknown0x1ED_0x644E_0x831E()
    {

        // unknown_0x1ED_0x64EF_0x83BF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x646F, "unknown", this::unknown0x1ED_0x646F_0x833F);
    public  Action Unknown0x1ED_0x646F_0x833F()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x64EF, "unknown", this::unknown0x1ED_0x64EF_0x83BF);
    public  Action Unknown0x1ED_0x64EF_0x83BF()
    {

        // unknown_0x1ED_0x646F_0x833F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6603, "unknown", this::unknown0x1ED_0x6603_0x84D3);
    public  Action Unknown0x1ED_0x6603_0x84D3()
    {

        // unknown_0x1ED_0x1E0_0x20B0();
        // unknown_0x1ED_0x316E_0x503E();
        // unknown_0x1ED_0x3406_0x52D6();
        // unknown_0x1ED_0x34D0_0x53A0();
        // unknown_0x1ED_0x5728_0x75F8();
        // unknown_0x1ED_0x6906_0x87D6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x661D, "unknown", this::unknown0x1ED_0x661D_0x84ED);
    public  Action Unknown0x1ED_0x661D_0x84ED()
    {

        // unknown_0x1ED_0x6906_0x87D6();
        // unknown_0x1ED_0x6E82_0x8D52();
        // unknown_0x1ED_0x6ECB_0x8D9B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6639, "unknown", this::unknown0x1ED_0x6639_0x8509);
    public  Action Unknown0x1ED_0x6639_0x8509()
    {

        // unknown_0x1ED_0x6603_0x84D3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x66CE, "unknown", this::unknown0x1ED_0x66CE_0x859E);
    public  Action Unknown0x1ED_0x66CE_0x859E()
    {

        // unknown_0x1ED_0x1AC5_0x3995();
        // unknown_0x1ED_0x644E_0x831E();
        // unknown_0x1ED_0x6B25_0x89F5();
        // unknown_0x1ED_0x6F78_0x8E48();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6715, "unknown", this::unknown0x1ED_0x6715_0x85E5);
    public  Action Unknown0x1ED_0x6715_0x85E5()
    {

        // unknown_0x1ED_0x6757_0x8627();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6757, "unknown", this::unknown0x1ED_0x6757_0x8627);
    public  Action Unknown0x1ED_0x6757_0x8627()
    {

        // unknown_0x1ED_0x6770_0x8640();
        // unknown_0x1ED_0x686E_0x873E();
        // unknown_0x1ED_0x6906_0x87D6();
        // unknown_0x1ED_0xC5CF_0xE49F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6770, "unknown", this::unknown0x1ED_0x6770_0x8640);
    public  Action Unknown0x1ED_0x6770_0x8640()
    {

        // unknown_0x1ED_0x693B_0x880B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x686E, "unknown", this::unknown0x1ED_0x686E_0x873E);
    public  Action Unknown0x1ED_0x686E_0x873E()
    {

        // unknown_0x1ED_0xB647_0xD517();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x68EB, "unknown", this::unknown0x1ED_0x68EB_0x87BB);
    public  Action Unknown0x1ED_0x68EB_0x87BB()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6906, "unknown", this::unknown0x1ED_0x6906_0x87D6);
    public  Action Unknown0x1ED_0x6906_0x87D6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6917, "unknown", this::unknown0x1ED_0x6917_0x87E7);
    public  Action Unknown0x1ED_0x6917_0x87E7()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x693B, "unknown", this::unknown0x1ED_0x693B_0x880B);
    public  Action Unknown0x1ED_0x693B_0x880B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6946, "unknown", this::unknown0x1ED_0x6946_0x8816);
    public  Action Unknown0x1ED_0x6946_0x8816()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x697C, "unknown", this::unknown0x1ED_0x697C_0x884C);
    public  Action Unknown0x1ED_0x697C_0x884C()
    {

        // unknown_0x1ED_0x5ED0_0x7DA0();
        // unknown_0x1ED_0x686E_0x873E();
        // unknown_0x1ED_0x6917_0x87E7();
        // unknown_0x1ED_0xC5CF_0xE49F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x69A3, "unknown", this::unknown0x1ED_0x69A3_0x8873);
    public  Action Unknown0x1ED_0x69A3_0x8873()
    {

        // unknown_0x1ED_0xC58A_0xE45A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6A89, "unknown", this::unknown0x1ED_0x6A89_0x8959);
    public  Action Unknown0x1ED_0x6A89_0x8959()
    {

        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x693B_0x880B();
        // unknown_0x1ED_0x6ACB_0x899B();
        // unknown_0x1ED_0x7BB9_0x9A89();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6ACB, "unknown", this::unknown0x1ED_0x6ACB_0x899B);
    public  Action Unknown0x1ED_0x6ACB_0x899B()
    {

        // unknown_0x1ED_0x693B_0x880B();
        // unknown_0x1ED_0x6B25_0x89F5();
        // unknown_0x1ED_0x6C15_0x8AE5();
        // unknown_0x1ED_0x7847_0x9717();
        // unknown_0x1ED_0x8461_0xA331();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6AD4, "unknown", this::unknown0x1ED_0x6AD4_0x89A4);
    public  Action Unknown0x1ED_0x6AD4_0x89A4()
    {

        // unknown_0x1ED_0x693B_0x880B();
        // unknown_0x1ED_0x6B25_0x89F5();
        // unknown_0x1ED_0x6C15_0x8AE5();
        // unknown_0x1ED_0x8461_0xA331();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6B25, "unknown", this::unknown0x1ED_0x6B25_0x89F5);
    public  Action Unknown0x1ED_0x6B25_0x89F5()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6B34, "unknown", this::unknown0x1ED_0x6B34_0x8A04);
    public  Action Unknown0x1ED_0x6B34_0x8A04()
    {

        // unknown_0x1ED_0xC661_0xE531();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6B96, "unknown", this::unknown0x1ED_0x6B96_0x8A66);
    public  Action Unknown0x1ED_0x6B96_0x8A66()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6C15, "unknown", this::unknown0x1ED_0x6C15_0x8AE5);
    public  Action Unknown0x1ED_0x6C15_0x8AE5()
    {

        // unknown_0x1ED_0x8461_0xA331();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6C46, "unknown", this::unknown0x1ED_0x6C46_0x8B16);
    public  Action Unknown0x1ED_0x6C46_0x8B16()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6C6F, "unknown", this::unknown0x1ED_0x6C6F_0x8B3F);
    public  Action Unknown0x1ED_0x6C6F_0x8B3F()
    {

        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x6C46_0x8B16();
        // unknown_0x1ED_0x6D19_0x8BE9();
        // unknown_0x1ED_0x6D7B_0x8C4B();
        // unknown_0x1ED_0x6FE5_0x8EB5();
        // unknown_0x1ED_0x8308_0xA1D8();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6CFC, "unknown", this::unknown0x1ED_0x6CFC_0x8BCC);
    public  Action Unknown0x1ED_0x6CFC_0x8BCC()
    {

        // unknown_0x1ED_0x644E_0x831E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6D19, "unknown", this::unknown0x1ED_0x6D19_0x8BE9);
    public  Action Unknown0x1ED_0x6D19_0x8BE9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6D7B, "unknown", this::unknown0x1ED_0x6D7B_0x8C4B);
    public  Action Unknown0x1ED_0x6D7B_0x8C4B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6E20, "unknown", this::unknown0x1ED_0x6E20_0x8CF0);
    public  Action Unknown0x1ED_0x6E20_0x8CF0()
    {

        // unknown_0x1ED_0x1AC5_0x3995();
        // unknown_0x1ED_0x661D_0x84ED();
        // unknown_0x1ED_0x6CFC_0x8BCC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6E82, "unknown", this::unknown0x1ED_0x6E82_0x8D52);
    public  Action Unknown0x1ED_0x6E82_0x8D52()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6EBF, "unknown", this::unknown0x1ED_0x6EBF_0x8D8F);
    public  Action Unknown0x1ED_0x6EBF_0x8D8F()
    {

        // unknown_0x1ED_0x661D_0x84ED();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6ECB, "unknown", this::unknown0x1ED_0x6ECB_0x8D9B);
    public  Action Unknown0x1ED_0x6ECB_0x8D9B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6EFD, "unknown", this::unknown0x1ED_0x6EFD_0x8DCD);
    public  Action Unknown0x1ED_0x6EFD_0x8DCD()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6F78, "unknown", this::unknown0x1ED_0x6F78_0x8E48);
    public  Action Unknown0x1ED_0x6F78_0x8E48()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x6FE5, "unknown", this::unknown0x1ED_0x6FE5_0x8EB5);
    public  Action Unknown0x1ED_0x6FE5_0x8EB5()
    {

        // unknown_0x1ED_0x6B96_0x8A66();
        // unknown_0x1ED_0x6E20_0x8CF0();
        // unknown_0x1ED_0x708A_0x8F5A();
        // unknown_0x1ED_0x714C_0x901C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x708A, "unknown", this::unknown0x1ED_0x708A_0x8F5A);
    public  Action Unknown0x1ED_0x708A_0x8F5A()
    {

        // unknown_0x1ED_0x6EFD_0x8DCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x714C, "unknown", this::unknown0x1ED_0x714C_0x901C);
    public  Action Unknown0x1ED_0x714C_0x901C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x780A, "unknown", this::unknown0x1ED_0x780A_0x96DA);
    public  Action Unknown0x1ED_0x780A_0x96DA()
    {

        // unknown_0x1ED_0x7847_0x9717();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // unknown_0x1ED_0xD323_0xF1F3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7847, "unknown", this::unknown0x1ED_0x7847_0x9717);
    public  Action Unknown0x1ED_0x7847_0x9717()
    {

        // unknown_0x1ED_0x7F27_0x9DF7();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x79DE, "unknown", this::unknown0x1ED_0x79DE_0x98AE);
    public  Action Unknown0x1ED_0x79DE_0x98AE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x79EE, "unknown", this::unknown0x1ED_0x79EE_0x98BE);
    public  Action Unknown0x1ED_0x79EE_0x98BE()
    {

        // unknown_0x1ED_0x6917_0x87E7();
        // unknown_0x1ED_0x7B0F_0x99DF();
        // unknown_0x1ED_0x7B1B_0x99EB();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9D6A_0xBC3A();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.gfx_copy_rect_to_screen_ida_0x1ED_0xC4AA_0xE37A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7B0F, "unknown", this::unknown0x1ED_0x7B0F_0x99DF);
    public  Action Unknown0x1ED_0x7B0F_0x99DF()
    {

        // unknown_0x1ED_0xC0E8_0xDFB8();
        // unknown_0x1ED_0xC53E_0xE40E();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7B1B, "unknown", this::unknown0x1ED_0x7B1B_0x99EB);
    public  Action Unknown0x1ED_0x7B1B_0x99EB()
    {

        // unknown_0x1ED_0xC53E_0xE40E();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7B2B, "unknown", this::unknown0x1ED_0x7B2B_0x99FB);
    public  Action Unknown0x1ED_0x7B2B_0x99FB()
    {

        // unknown_0x2538_0x15A_0x254DA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7B36, "unknown", this::unknown0x1ED_0x7B36_0x9A06);
    public  Action Unknown0x1ED_0x7B36_0x9A06()
    {

        // unknown_0x1ED_0x5F79_0x7E49();
        // unknown_0x1ED_0x79DE_0x98AE();
        // unknown_0x1ED_0x8770_0xA640();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7B58, "unknown", this::unknown0x1ED_0x7B58_0x9A28);
    public  Action Unknown0x1ED_0x7B58_0x9A28()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7BA3, "unknown", this::unknown0x1ED_0x7BA3_0x9A73);
    public  Action Unknown0x1ED_0x7BA3_0x9A73()
    {

        // unknown_0x1ED_0x79EE_0x98BE();
        // unknown_0x1ED_0x9F40_0xBE10();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7BB9, "unknown", this::unknown0x1ED_0x7BB9_0x9A89);
    public  Action Unknown0x1ED_0x7BB9_0x9A89()
    {

        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x96F1_0xB5C1();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7BBE, "unknown", this::unknown0x1ED_0x7BBE_0x9A8E);
    public  Action Unknown0x1ED_0x7BBE_0x9A8E()
    {

        // unknown_0x1ED_0x96F1_0xB5C1();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7BE0, "unknown", this::unknown0x1ED_0x7BE0_0x9AB0);
    public  Action Unknown0x1ED_0x7BE0_0x9AB0()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x7BA3_0x9A73();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x9719_0xB5E9();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7BED, "unknown", this::unknown0x1ED_0x7BED_0x9ABD);
    public  Action Unknown0x1ED_0x7BED_0x9ABD()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x7BA3_0x9A73();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x9719_0xB5E9();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7C02, "unknown", this::unknown0x1ED_0x7C02_0x9AD2);
    public  Action Unknown0x1ED_0x7C02_0x9AD2()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x7BA3_0x9A73();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x7E1E_0x9CEE();
        // unknown_0x1ED_0x7EFB_0x9DCB();
        // unknown_0x1ED_0x9719_0xB5E9();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7C63, "unknown", this::unknown0x1ED_0x7C63_0x9B33);
    public  Action Unknown0x1ED_0x7C63_0x9B33()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7C8F, "unknown", this::unknown0x1ED_0x7C8F_0x9B5F);
    public  Action Unknown0x1ED_0x7C8F_0x9B5F()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7D0C, "unknown", this::unknown0x1ED_0x7D0C_0x9BDC);
    public  Action Unknown0x1ED_0x7D0C_0x9BDC()
    {

        // unknown_0x1ED_0x7B1B_0x99EB();
        // unknown_0x1ED_0x7E1E_0x9CEE();
        // unknown_0x1ED_0x7E3D_0x9D0D();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD280_0xF150();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7D68, "unknown", this::unknown0x1ED_0x7D68_0x9C38);
    public  Action Unknown0x1ED_0x7D68_0x9C38()
    {

        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x7BB9_0x9A89();
        // unknown_0x1ED_0x7F11_0x9DE1();
        // unknown_0x1ED_0x8461_0xA331();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7DD9, "unknown", this::unknown0x1ED_0x7DD9_0x9CA9);
    public  Action Unknown0x1ED_0x7DD9_0x9CA9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7E1E, "unknown", this::unknown0x1ED_0x7E1E_0x9CEE);
    public  Action Unknown0x1ED_0x7E1E_0x9CEE()
    {

        // unknown_0x1ED_0x61D3_0x80A3();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // unknown_0x1ED_0xD19B_0xF06B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7E3D, "unknown", this::unknown0x1ED_0x7E3D_0x9D0D);
    public  Action Unknown0x1ED_0x7E3D_0x9D0D()
    {

        // unknown_0x1ED_0x61D3_0x80A3();
        // unknown_0x1ED_0xC13B_0xE00B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7EE2, "unknown", this::unknown0x1ED_0x7EE2_0x9DB2);
    public  Action Unknown0x1ED_0x7EE2_0x9DB2()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7EFB, "unknown", this::unknown0x1ED_0x7EFB_0x9DCB);
    public  Action Unknown0x1ED_0x7EFB_0x9DCB()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7F11, "unknown", this::unknown0x1ED_0x7F11_0x9DE1);
    public  Action Unknown0x1ED_0x7F11_0x9DE1()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7F27, "unknown", this::unknown0x1ED_0x7F27_0x9DF7);
    public  Action Unknown0x1ED_0x7F27_0x9DF7()
    {

        // unknown_0x1ED_0x6906_0x87D6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7F5F, "unknown", this::unknown0x1ED_0x7F5F_0x9E2F);
    public  Action Unknown0x1ED_0x7F5F_0x9E2F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x7F75, "unknown", this::unknown0x1ED_0x7F75_0x9E45);
    public  Action Unknown0x1ED_0x7F75_0x9E45()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x80AC, "unknown", this::unknown0x1ED_0x80AC_0x9F7C);
    public  Action Unknown0x1ED_0x80AC_0x9F7C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x80DF, "unknown", this::unknown0x1ED_0x80DF_0x9FAF);
    public  Action Unknown0x1ED_0x80DF_0x9FAF()
    {

        // unknown_0x1ED_0x541F_0x72EF();
        // unknown_0x1ED_0x88AF_0xA77F();
        // unknown_0x1ED_0x8FD1_0xAEA1();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // unknown_0x1ED_0x9F82_0xBE52();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x813E, "unknown", this::unknown0x1ED_0x813E_0xA00E);
    public  Action Unknown0x1ED_0x813E_0xA00E()
    {

        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x81D7_0xA0A7();
        // unknown_0x2538_0x139_0x254B9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x81D7, "unknown", this::unknown0x1ED_0x81D7_0xA0A7);
    public  Action Unknown0x1ED_0x81D7_0xA0A7()
    {

        // unknown_0x1ED_0xB647_0xD517();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x81EC, "unknown", this::unknown0x1ED_0x81EC_0xA0BC);
    public  Action Unknown0x1ED_0x81EC_0xA0BC()
    {

        // unknown_0x1ED_0x5944_0x7814();
        // unknown_0x1ED_0x5E6D_0x7D3D();
        // unknown_0x1ED_0x8256_0xA126();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8250, "unknown", this::unknown0x1ED_0x8250_0xA120);
    public  Action Unknown0x1ED_0x8250_0xA120()
    {

        // unknown_0x1ED_0x5AD3_0x79A3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8256, "unknown", this::unknown0x1ED_0x8256_0xA126);
    public  Action Unknown0x1ED_0x8256_0xA126()
    {

        // unknown_0x1ED_0x542F_0x72FF();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x80AC_0x9F7C();
        // unknown_0x1ED_0xD33A_0xF20A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x82B7, "unknown", this::unknown0x1ED_0x82B7_0xA187);
    public  Action Unknown0x1ED_0x82B7_0xA187()
    {

        // unknown_0x1ED_0x58FA_0x77CA();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x7BE0_0x9AB0();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xC551_0xE421();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x82DA, "unknown", this::unknown0x1ED_0x82DA_0xA1AA);
    public  Action Unknown0x1ED_0x82DA_0xA1AA()
    {

        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x7BBE_0x9A8E();
        // unknown_0x1ED_0x9F82_0xBE52();
        // unknown_0x1ED_0xA1C4_0xC094();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8308, "unknown", this::unknown0x1ED_0x8308_0xA1D8);
    public  Action Unknown0x1ED_0x8308_0xA1D8()
    {

        // unknown_0x1ED_0x5D36_0x7C06();
        // unknown_0x1ED_0x686E_0x873E();
        // unknown_0x1ED_0x6917_0x87E7();
        // unknown_0x1ED_0x6AD4_0x89A4();
        // unknown_0x1ED_0x7F5F_0x9E2F();
        // unknown_0x1ED_0x8347_0xA217();
        // unknown_0x1ED_0x851F_0xA3EF();
        // unknown_0x1ED_0x85CC_0xA49C();
        // unknown_0x1ED_0x8604_0xA4D4();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8347, "unknown", this::unknown0x1ED_0x8347_0xA217);
    public  Action Unknown0x1ED_0x8347_0xA217()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8461, "unknown", this::unknown0x1ED_0x8461_0xA331);
    public  Action Unknown0x1ED_0x8461_0xA331()
    {

        // unknown_0x1ED_0x5ED0_0x7DA0();
        // unknown_0x1ED_0x6757_0x8627();
        // unknown_0x1ED_0x6917_0x87E7();
        // unknown_0x1ED_0xC58A_0xE45A();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x848F, "unknown", this::unknown0x1ED_0x848F_0xA35F);
    public  Action Unknown0x1ED_0x848F_0xA35F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x84A6, "unknown", this::unknown0x1ED_0x84A6_0xA376);
    public  Action Unknown0x1ED_0x84A6_0xA376()
    {

        // unknown_0x1ED_0x686E_0x873E();
        // unknown_0x1ED_0x6917_0x87E7();
        // unknown_0x1ED_0x6EBF_0x8D8F();
        // unknown_0x1ED_0x7F75_0x9E45();
        // unknown_0x1ED_0x8461_0xA331();
        // unknown_0x1ED_0x848F_0xA35F();
        // unknown_0x1ED_0x858C_0xA45C();
        // unknown_0x1ED_0x8604_0xA4D4();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC202_0xE0D2();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x851F, "unknown", this::unknown0x1ED_0x851F_0xA3EF);
    public  Action Unknown0x1ED_0x851F_0xA3EF()
    {

        // unknown_0x1ED_0x6906_0x87D6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x858C, "unknown", this::unknown0x1ED_0x858C_0xA45C);
    public  Action Unknown0x1ED_0x858C_0xA45C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x85CC, "unknown", this::unknown0x1ED_0x85CC_0xA49C);
    public  Action Unknown0x1ED_0x85CC_0xA49C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8604, "unknown", this::unknown0x1ED_0x8604_0xA4D4);
    public  Action Unknown0x1ED_0x8604_0xA4D4()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8751, "unknown", this::unknown0x1ED_0x8751_0xA621);
    public  Action Unknown0x1ED_0x8751_0xA621()
    {

        // unknown_0x1ED_0x1AC5_0x3995();
        // unknown_0x1ED_0x1EBE_0x3D8E();
        // unknown_0x1ED_0x69A3_0x8873();
        // unknown_0x1ED_0x7B2B_0x99FB();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8770, "unknown", this::unknown0x1ED_0x8770_0xA640);
    public  Action Unknown0x1ED_0x8770_0xA640()
    {

        // unknown_0x1ED_0x878C_0xA65C();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x878C, "unknown", this::unknown0x1ED_0x878C_0xA65C);
    public  Action Unknown0x1ED_0x878C_0xA65C()
    {

        // unknown_0x1ED_0x6906_0x87D6();
        // unknown_0x1ED_0x7F27_0x9DF7();
        // unknown_0x1ED_0xD338_0xF208();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x881F, "unknown", this::unknown0x1ED_0x881F_0xA6EF);
    public  Action Unknown0x1ED_0x881F_0xA6EF()
    {

        // unknown_0x1ED_0x5A9A_0x796A();
        // unknown_0x1ED_0x5BEB_0x7ABB();
        // unknown_0x1ED_0x7B36_0x9A06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8824, "unknown", this::unknown0x1ED_0x8824_0xA6F4);
    public  Action Unknown0x1ED_0x8824_0xA6F4()
    {

        // unknown_0x1ED_0x5A9A_0x796A();
        // unknown_0x1ED_0x5BEB_0x7ABB();
        // unknown_0x1ED_0x7B36_0x9A06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8829, "unknown", this::unknown0x1ED_0x8829_0xA6F9);
    public  Action Unknown0x1ED_0x8829_0xA6F9()
    {

        // unknown_0x1ED_0x5A9A_0x796A();
        // unknown_0x1ED_0x5BEB_0x7ABB();
        // unknown_0x1ED_0x7B36_0x9A06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x882E, "unknown", this::unknown0x1ED_0x882E_0xA6FE);
    public  Action Unknown0x1ED_0x882E_0xA6FE()
    {

        // unknown_0x1ED_0x5A9A_0x796A();
        // unknown_0x1ED_0x5BEB_0x7ABB();
        // unknown_0x1ED_0x7B36_0x9A06();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8865, "unknown", this::unknown0x1ED_0x8865_0xA735);
    public  Action Unknown0x1ED_0x8865_0xA735()
    {

        // unknown_0x1ED_0x88F1_0xA7C1();
        // unknown_0x1ED_0x8944_0xA814();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD1BB_0xF08B();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x88AF, "unknown", this::unknown0x1ED_0x88AF_0xA77F);
    public  Action Unknown0x1ED_0x88AF_0xA77F()
    {

        // unknown_0x1ED_0x541F_0x72EF();
        // unknown_0x1ED_0x88AF_0xA77F();
        // unknown_0x1ED_0x88F1_0xA7C1();
        // unknown_0x1ED_0x8944_0xA814();
        // unknown_0x1ED_0x8B11_0xA9E1();
        // unknown_0x1ED_0x8FD1_0xAEA1();
        // unknown_0x1ED_0x9F82_0xBE52();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xCF70_0xEE40();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x88D2, "unknown", this::unknown0x1ED_0x88D2_0xA7A2);
    public  Action Unknown0x1ED_0x88D2_0xA7A2()
    {

        // unknown_0x1ED_0x8944_0xA814();
        // unknown_0x1ED_0x8B11_0xA9E1();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x88F1, "unknown", this::unknown0x1ED_0x88F1_0xA7C1);
    public  Action Unknown0x1ED_0x88F1_0xA7C1()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8944, "unknown", this::unknown0x1ED_0x8944_0xA814);
    public  Action Unknown0x1ED_0x8944_0xA814()
    {

        // unknown_0x1ED_0x8A23_0xA8F3();
        // unknown_0x1ED_0x8A3B_0xA90B();
        // unknown_0x1ED_0x8AC3_0xA993();
        // unknown_0x1ED_0x8ACC_0xA99C();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xE3B7_0x10287();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8A23, "unknown", this::unknown0x1ED_0x8A23_0xA8F3);
    public  Action Unknown0x1ED_0x8A23_0xA8F3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8A3B, "unknown", this::unknown0x1ED_0x8A3B_0xA90B);
    public  Action Unknown0x1ED_0x8A3B_0xA90B()
    {

        // unknown_0x1ED_0x8AC3_0xA993();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8AC3, "unknown", this::unknown0x1ED_0x8AC3_0xA993);
    public  Action Unknown0x1ED_0x8AC3_0xA993()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8ACC, "unknown", this::unknown0x1ED_0x8ACC_0xA99C);
    public  Action Unknown0x1ED_0x8ACC_0xA99C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8B11, "unknown", this::unknown0x1ED_0x8B11_0xA9E1);
    public  Action Unknown0x1ED_0x8B11_0xA9E1()
    {

        // unknown_0x1ED_0x8C8A_0xAB5A();
        // unknown_0x1ED_0x8CCD_0xAB9D();
        // unknown_0x1ED_0x8DF0_0xACC0();
        // unknown_0x1ED_0x8F28_0xADF8();
        // unknown_0x1ED_0x9046_0xAF16();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD096_0xEF66();
        // unknown_0x1ED_0xD12F_0xEFFF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8C8A, "unknown", this::unknown0x1ED_0x8C8A_0xAB5A);
    public  Action Unknown0x1ED_0x8C8A_0xAB5A()
    {

        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0xC446_0xE316();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8CCD, "unknown", this::unknown0x1ED_0x8CCD_0xAB9D);
    public  Action Unknown0x1ED_0x8CCD_0xAB9D()
    {

        // unknown_0x1ED_0x8E16_0xACE6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8DF0, "unknown", this::unknown0x1ED_0x8DF0_0xACC0);
    public  Action Unknown0x1ED_0x8DF0_0xACC0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8E16, "unknown", this::unknown0x1ED_0x8E16_0xACE6);
    public  Action Unknown0x1ED_0x8E16_0xACE6()
    {

        // unknown_0x1ED_0x8E9E_0xAD6E();
        // unknown_0x1ED_0x8ED3_0xADA3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8E9E, "unknown", this::unknown0x1ED_0x8E9E_0xAD6E);
    public  Action Unknown0x1ED_0x8E9E_0xAD6E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8ED3, "unknown", this::unknown0x1ED_0x8ED3_0xADA3);
    public  Action Unknown0x1ED_0x8ED3_0xADA3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8F28, "unknown", this::unknown0x1ED_0x8F28_0xADF8);
    public  Action Unknown0x1ED_0x8F28_0xADF8()
    {

        // display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida_0x1ED_0xC085_0xDF55 overriden();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x8FD1, "unknown", this::unknown0x1ED_0x8FD1_0xAEA1);
    public  Action Unknown0x1ED_0x8FD1_0xAEA1()
    {

        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9025, "unknown", this::unknown0x1ED_0x9025_0xAEF5);
    public  Action Unknown0x1ED_0x9025_0xAEF5()
    {

        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9046, "unknown", this::unknown0x1ED_0x9046_0xAF16);
    public  Action Unknown0x1ED_0x9046_0xAF16()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x908C, "unknown", this::unknown0x1ED_0x908C_0xAF5C);
    public  Action Unknown0x1ED_0x908C_0xAF5C()
    {

        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x90BD, "unknown", this::unknown0x1ED_0x90BD_0xAF8D);
    public  Action Unknown0x1ED_0x90BD_0xAF8D()
    {

        // unknown_0x1ED_0x92C9_0xB199();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9123, "unknown", this::unknown0x1ED_0x9123_0xAFF3);
    public  Action Unknown0x1ED_0x9123_0xAFF3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9197, "unknown", this::unknown0x1ED_0x9197_0xB067);
    public  Action Unknown0x1ED_0x9197_0xB067()
    {

        // unknown_0x1ED_0x9123_0xAFF3();
        // unknown_0x1ED_0xC1AA_0xE07A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x91A0, "unknown", this::unknown0x1ED_0x91A0_0xB070);
    public  Action Unknown0x1ED_0x91A0_0xB070()
    {

        // unknown_0x1ED_0x9123_0xAFF3();
        // unknown_0x1ED_0x920F_0xB0DF();
        // unknown_0x1ED_0x98B2_0xB782();
        // unknown_0x1ED_0xC1AA_0xE07A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x920F, "unknown", this::unknown0x1ED_0x920F_0xB0DF);
    public  Action Unknown0x1ED_0x920F_0xB0DF()
    {

        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // vgaDriver.noOp_0x2538_0x13C_0x254BC overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9215, "unknown", this::unknown0x1ED_0x9215_0xB0E5);
    public  Action Unknown0x1ED_0x9215_0xB0E5()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x1EBE_0x3D8E();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x36D3_0x55A3();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x38E1_0x57B1();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x3EFE_0x5DCE();
        // unknown_0x1ED_0x40C3_0x5F93();
        // unknown_0x1ED_0x439F_0x626F();
        // unknown_0x1ED_0x445D_0x632D();
        // unknown_0x1ED_0x4658_0x6528();
        // unknown_0x1ED_0x49EA_0x68BA();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x5B5D_0x7A2D();
        // unknown_0x1ED_0x5B93_0x7A63();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9285_0xB155();
        // unknown_0x1ED_0x92C9_0xB199();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x98B2_0xB782();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xAB4F_0xCA1F();
        // unknown_0x1ED_0xABD5_0xCAA5();
        // sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida_0x1ED_0xAC30_0xCB00 overriden();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // ida.open_sav_cl_ida_0x1ED_0xB389_0xD259();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD323_0xF1F3();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // unknown_0x1ED_0xD72B_0xF5FB();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        // map.setSiToMapCursorTypeDC58_0x1ED_0xDAAA_0xF97A overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9285, "unknown", this::unknown0x1ED_0x9285_0xB155);
    public  Action Unknown0x1ED_0x9285_0xB155()
    {

        // unknown_0x1ED_0xD6FE_0xF5CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x92C9, "unknown", this::unknown0x1ED_0x92C9_0xB199);
    public  Action Unknown0x1ED_0x92C9_0xB199()
    {

        // unknown_0x1ED_0xD6FE_0xF5CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x93DF, "unknown", this::unknown0x1ED_0x93DF_0xB2AF);
    public  Action Unknown0x1ED_0x93DF_0xB2AF()
    {

        // unknown_0x1ED_0x90BD_0xAF8D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x941D, "unknown", this::unknown0x1ED_0x941D_0xB2ED);
    public  Action Unknown0x1ED_0x941D_0xB2ED()
    {

        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x2DB1_0x4C81();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9285_0xB155();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x945B, "unknown", this::unknown0x1ED_0x945B_0xB32B);
    public  Action Unknown0x1ED_0x945B_0xB32B()
    {

        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x88D2_0xA7A2();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA03F_0xBF0F();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x94F3, "unknown", this::unknown0x1ED_0x94F3_0xB3C3);
    public  Action Unknown0x1ED_0x94F3_0xB3C3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x956D, "unknown", this::unknown0x1ED_0x956D_0xB43D);
    public  Action Unknown0x1ED_0x956D_0xB43D()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9673, "unknown", this::unknown0x1ED_0x9673_0xB543);
    public  Action Unknown0x1ED_0x9673_0xB543()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD1F2_0xF0C2();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x96B5, "unknown", this::unknown0x1ED_0x96B5_0xB585);
    public  Action Unknown0x1ED_0x96B5_0xB585()
    {

        // unknown_0x1ED_0x9F9E_0xBE6E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x96D8, "unknown", this::unknown0x1ED_0x96D8_0xB5A8);
    public  Action Unknown0x1ED_0x96D8_0xB5A8()
    {

        // unknown_0x1ED_0x9702_0xB5D2();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x96F1, "unknown", this::unknown0x1ED_0x96F1_0xB5C1);
    public  Action Unknown0x1ED_0x96F1_0xB5C1()
    {

        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9702, "unknown", this::unknown0x1ED_0x9702_0xB5D2);
    public  Action Unknown0x1ED_0x9702_0xB5D2()
    {

        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9719, "unknown", this::unknown0x1ED_0x9719_0xB5E9);
    public  Action Unknown0x1ED_0x9719_0xB5E9()
    {

        // unknown_0x1ED_0x2A51_0x4921();
        // unknown_0x1ED_0x9F82_0xBE52();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA1C4_0xC094();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9761, "unknown", this::unknown0x1ED_0x9761_0xB631);
    public  Action Unknown0x1ED_0x9761_0xB631()
    {

        // unknown_0x1ED_0x88AF_0xA77F();
        // unknown_0x1ED_0x94F3_0xB3C3();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0xA396_0xC266();
        // dialogues.initDialogue_0x1ED_0xC85B_0xE72B overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x978E, "unknown", this::unknown0x1ED_0x978E_0xB65E);
    public  Action Unknown0x1ED_0x978E_0xB65E()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x9025_0xAEF5();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.gfx_copy_rect_at_si_ida_0x1ED_0xC477_0xE347();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x97CF, "unknown", this::unknown0x1ED_0x97CF_0xB69F);
    public  Action Unknown0x1ED_0x97CF_0xB69F()
    {

        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x2EFB_0x4DCB();
        // unknown_0x1ED_0x2FFB_0x4ECB();
        // unknown_0x1ED_0x3090_0x4F60();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x37F4_0x56C4();
        // unknown_0x1ED_0x8C8A_0xAB5A();
        // unknown_0x1ED_0x9673_0xB543();
        // unknown_0x1ED_0x9B8B_0xBA5B();
        // unknown_0x1ED_0xA7A5_0xC675();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x98B2, "unknown", this::unknown0x1ED_0x98B2_0xB782);
    public  Action Unknown0x1ED_0x98B2_0xB782()
    {

        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xC446_0xE316();
        // ida.rect_at_si_to_regs_ida_0x1ED_0xC4F0_0xE3C0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x98E6, "unknown", this::unknown0x1ED_0x98E6_0xB7B6);
    public  Action Unknown0x1ED_0x98E6_0xB7B6()
    {

        // display.clearUnknownValuesAndAX_0x1ED_0x98F5_0xB7C5 overriden();
        // unknown_0x1ED_0xA7A5_0xC675();
        return NearRet();
    }

    // Not providing stub for display.clearUnknownValuesAndAX. Reason: Function already has an override
    // Not providing stub for display.set479ETo0. Reason: Function already has an override
    // defineFunction(0x1ED, 0x9908, "unknown", this::unknown0x1ED_0x9908_0xB7D8);
    public  Action Unknown0x1ED_0x9908_0xB7D8()
    {

        // unknown_0x1ED_0x127C_0x314C();
        // unknown_0x1ED_0x994F_0xB81F();
        // unknown_0x1ED_0x996C_0xB83C();
        // unknown_0x1ED_0xDA25_0xF8F5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x994F, "unknown", this::unknown0x1ED_0x994F_0xB81F);
    public  Action Unknown0x1ED_0x994F_0xB81F()
    {

        // unknown_0x1ED_0xE3B7_0x10287();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x996C, "unknown", this::unknown0x1ED_0x996C_0xB83C);
    public  Action Unknown0x1ED_0x996C_0xB83C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9985, "unknown", this::unknown0x1ED_0x9985_0xB855);
    public  Action Unknown0x1ED_0x9985_0xB855()
    {

        // unknown_0x1ED_0x99BE_0xB88E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x99BE, "unknown", this::unknown0x1ED_0x99BE_0xB88E);
    public  Action Unknown0x1ED_0x99BE_0xB88E()
    {

        // unknown_0x1ED_0x908C_0xAF5C();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x994F_0xB81F();
        // unknown_0x1ED_0x996C_0xB83C();
        // unknown_0x1ED_0x9A60_0xB930();
        // unknown_0x1ED_0x9A7B_0xB94B();
        // unknown_0x1ED_0x9AB4_0xB984();
        // unknown_0x1ED_0x9BB1_0xBA81();
        // ida.rect_at_si_to_regs_ida_0x1ED_0xC4F0_0xE3C0();
        // unknown_0x1ED_0xDB74_0xFA44();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x99F6, "unknown", this::unknown0x1ED_0x99F6_0xB8C6);
    public  Action Unknown0x1ED_0x99F6_0xB8C6()
    {

        // unknown_0x1ED_0x908C_0xAF5C();
        // unknown_0x1ED_0x9BB1_0xBA81();
        // ida.rect_at_si_to_regs_ida_0x1ED_0xC4F0_0xE3C0();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9A60, "unknown", this::unknown0x1ED_0x9A60_0xB930);
    public  Action Unknown0x1ED_0x9A60_0xB930()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9A7B, "unknown", this::unknown0x1ED_0x9A7B_0xB94B);
    public  Action Unknown0x1ED_0x9A7B_0xB94B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9AB4, "unknown", this::unknown0x1ED_0x9AB4_0xB984);
    public  Action Unknown0x1ED_0x9AB4_0xB984()
    {

        // unknown_0x1ED_0x8865_0xA735();
        // unknown_0x1ED_0x9B09_0xB9D9();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9B09, "unknown", this::unknown0x1ED_0x9B09_0xB9D9);
    public  Action Unknown0x1ED_0x9B09_0xB9D9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9B49, "unknown", this::unknown0x1ED_0x9B49_0xBA19);
    public  Action Unknown0x1ED_0x9B49_0xBA19()
    {

        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0xE353_0x10223();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9B8B, "unknown", this::unknown0x1ED_0x9B8B_0xBA5B);
    public  Action Unknown0x1ED_0x9B8B_0xBA5B()
    {

        // unknown_0x1ED_0xA7A5_0xC675();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9BAC, "unknown", this::unknown0x1ED_0x9BAC_0xBA7C);
    public  Action Unknown0x1ED_0x9BAC_0xBA7C()
    {

        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x9BEE_0xBABE();
        // unknown_0x1ED_0x9D16_0xBBE6();
        // unknown_0x1ED_0xC446_0xE316();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9BB1, "unknown", this::unknown0x1ED_0x9BB1_0xBA81);
    public  Action Unknown0x1ED_0x9BB1_0xBA81()
    {

        // unknown_0x1ED_0x9BEE_0xBABE();
        // unknown_0x1ED_0x9C2D_0xBAFD();
        // unknown_0x1ED_0x9D16_0xBBE6();
        // unknown_0x1ED_0xC446_0xE316();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9BEE, "unknown", this::unknown0x1ED_0x9BEE_0xBABE);
    public  Action Unknown0x1ED_0x9BEE_0xBABE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9C2D, "unknown", this::unknown0x1ED_0x9C2D_0xBAFD);
    public  Action Unknown0x1ED_0x9C2D_0xBAFD()
    {

        // unknown_0x1ED_0x9C54_0xBB24();
        // unknown_0x1ED_0x9CC6_0xBB96();
        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9C54, "unknown", this::unknown0x1ED_0x9C54_0xBB24);
    public  Action Unknown0x1ED_0x9C54_0xBB24()
    {

        // unknown_0x1ED_0x9CC6_0xBB96();
        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9CC6, "unknown", this::unknown0x1ED_0x9CC6_0xBB96);
    public  Action Unknown0x1ED_0x9CC6_0xBB96()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9D16, "unknown", this::unknown0x1ED_0x9D16_0xBBE6);
    public  Action Unknown0x1ED_0x9D16_0xBBE6()
    {

        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9D6A, "unknown", this::unknown0x1ED_0x9D6A_0xBC3A);
    public  Action Unknown0x1ED_0x9D6A_0xBC3A()
    {

        // unknown_0x1ED_0x9D94_0xBC64();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9D94, "unknown", this::unknown0x1ED_0x9D94_0xBC64);
    public  Action Unknown0x1ED_0x9D94_0xBC64()
    {

        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9EFD, "unknown", this::unknown0x1ED_0x9EFD_0xBDCD);
    public  Action Unknown0x1ED_0x9EFD_0xBDCD()
    {

        // unknown_0x1ED_0xA6CC_0xC59C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9F31, "unknown", this::unknown0x1ED_0x9F31_0xBE01);
    public  Action Unknown0x1ED_0x9F31_0xBE01()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9F40, "unknown", this::unknown0x1ED_0x9F40_0xBE10);
    public  Action Unknown0x1ED_0x9F40_0xBE10()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9F82, "unknown", this::unknown0x1ED_0x9F82_0xBE52);
    public  Action Unknown0x1ED_0x9F82_0xBE52()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9F8B, "unknown", this::unknown0x1ED_0x9F8B_0xBE5B);
    public  Action Unknown0x1ED_0x9F8B_0xBE5B()
    {

        // unknown_0x1ED_0x9F9E_0xBE6E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0x9F9E, "unknown", this::unknown0x1ED_0x9F9E_0xBE6E);
    public  Action Unknown0x1ED_0x9F9E_0xBE6E()
    {

        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x1803_0x36D3();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x88AF_0xA77F();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x94F3_0xB3C3();
        // unknown_0x1ED_0x978E_0xB65E();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // unknown_0x1ED_0xA0F1_0xBFC1();
        // unknown_0x1ED_0xA172_0xC042();
        // unknown_0x1ED_0xA1D0_0xC0A0();
        // unknown_0x1ED_0xA1D6_0xC0A6();
        // unknown_0x1ED_0xA1DC_0xC0AC();
        // dialogues.incUnknown47A8_0x1ED_0xA1E8_0xC0B8 overriden();
        // unknown_0x1ED_0xA1F7_0xC0C7();
        // unknown_0x1ED_0xA219_0xC0E9();
        // unknown_0x1ED_0xA235_0xC105();
        // unknown_0x1ED_0xA25B_0xC12B();
        // unknown_0x1ED_0xA396_0xC266();
        // dialogues.initDialogue_0x1ED_0xC85B_0xE72B overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA03F, "unknown", this::unknown0x1ED_0xA03F_0xBF0F);
    public  Action Unknown0x1ED_0xA03F_0xBF0F()
    {

        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x978E_0xB65E();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // unknown_0x1ED_0xA219_0xC0E9();
        // dialogues.initDialogue_0x1ED_0xC85B_0xE72B overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA0F1, "unknown", this::unknown0x1ED_0xA0F1_0xBFC1);
    public  Action Unknown0x1ED_0xA0F1_0xBFC1()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA172, "unknown", this::unknown0x1ED_0xA172_0xC042);
    public  Action Unknown0x1ED_0xA172_0xC042()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA1C4, "unknown", this::unknown0x1ED_0xA1C4_0xC094);
    public  Action Unknown0x1ED_0xA1C4_0xC094()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA1D0, "unknown", this::unknown0x1ED_0xA1D0_0xC0A0);
    public  Action Unknown0x1ED_0xA1D0_0xC0A0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA1D6, "unknown", this::unknown0x1ED_0xA1D6_0xC0A6);
    public  Action Unknown0x1ED_0xA1D6_0xC0A6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA1DC, "unknown", this::unknown0x1ED_0xA1DC_0xC0AC);
    public  Action Unknown0x1ED_0xA1DC_0xC0AC()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA1E2, "unknown", this::unknown0x1ED_0xA1E2_0xC0B2);
    public  Action Unknown0x1ED_0xA1E2_0xC0B2()
    {
        return NearRet();
    }

    // Not providing stub for dialogues.incUnknown47A8. Reason: Function already has an override
    // defineFunction(0x1ED, 0xA1F7, "unknown", this::unknown0x1ED_0xA1F7_0xC0C7);
    public  Action Unknown0x1ED_0xA1F7_0xC0C7()
    {

        // unknown_0x1ED_0xAD5E_0xCC2E();
        // mainCode.inc2788_0x1ED_0xB2B9_0xD189 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA219, "unknown", this::unknown0x1ED_0xA219_0xC0E9);
    public  Action Unknown0x1ED_0xA219_0xC0E9()
    {

        // unknown_0x1ED_0x100B_0x2EDB();
        // unknown_0x1ED_0xB17A_0xD04A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA235, "unknown", this::unknown0x1ED_0xA235_0xC105);
    public  Action Unknown0x1ED_0xA235_0xC105()
    {

        // unknown_0x1ED_0x1011_0x2EE1();
        // unknown_0x1ED_0xB17A_0xD04A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA25B, "unknown", this::unknown0x1ED_0xA25B_0xC12B);
    public  Action Unknown0x1ED_0xA25B_0xC12B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA30B, "unknown", this::unknown0x1ED_0xA30B_0xC1DB);
    public  Action Unknown0x1ED_0xA30B_0xC1DB()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA334, "unknown", this::unknown0x1ED_0xA334_0xC204);
    public  Action Unknown0x1ED_0xA334_0xC204()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA396, "unknown", this::unknown0x1ED_0xA396_0xC266);
    public  Action Unknown0x1ED_0xA396_0xC266()
    {

        // unknown_0x1ED_0xA30B_0xC1DB();
        // unknown_0x1ED_0xA334_0xC204();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA42C, "unknown", this::unknown0x1ED_0xA42C_0xC2FC);
    public  Action Unknown0x1ED_0xA42C_0xC2FC()
    {

        // unknown_0x1ED_0xA465_0xC335();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA44C, "unknown", this::unknown0x1ED_0xA44C_0xC31C);
    public  Action Unknown0x1ED_0xA44C_0xC31C()
    {

        // unknown_0x1ED_0xA465_0xC335();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA45C, "unknown", this::unknown0x1ED_0xA45C_0xC32C);
    public  Action Unknown0x1ED_0xA45C_0xC32C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA465, "unknown", this::unknown0x1ED_0xA465_0xC335);
    public  Action Unknown0x1ED_0xA465_0xC335()
    {

        // unknown_0x1ED_0xA45C_0xC32C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA47D, "unknown", this::unknown0x1ED_0xA47D_0xC34D);
    public  Action Unknown0x1ED_0xA47D_0xC34D()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA4C6, "unknown", this::unknown0x1ED_0xA4C6_0xC396);
    public  Action Unknown0x1ED_0xA4C6_0xC396()
    {

        // unknown_0x1ED_0xA502_0xC3D2();
        // mainCode.isUnknownDBC80x100_0x1ED_0xAE28_0xCCF8 overriden();
        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA502, "unknown", this::unknown0x1ED_0xA502_0xC3D2);
    public  Action Unknown0x1ED_0xA502_0xC3D2()
    {

        // unknown_0x1ED_0xA45C_0xC32C();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA541, "unknown", this::unknown0x1ED_0xA541_0xC411);
    public  Action Unknown0x1ED_0xA541_0xC411()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // map.setMapClickHandlerAddressToInGame_0x1ED_0xD95B_0xF82B overriden();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA5AA, "unknown", this::unknown0x1ED_0xA5AA_0xC47A);
    public  Action Unknown0x1ED_0xA5AA_0xC47A()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA637, "unknown", this::unknown0x1ED_0xA637_0xC507);
    public  Action Unknown0x1ED_0xA637_0xC507()
    {

        // soundDriverPcSpeaker.clearAL_0x4822_0x115_0x48335 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA650, "unknown", this::unknown0x1ED_0xA650_0xC520);
    public  Action Unknown0x1ED_0xA650_0xC520()
    {

        // soundDriverPcSpeaker.clearAL_0x482B_0x112_0x483C2 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA6CC, "unknown", this::unknown0x1ED_0xA6CC_0xC59C);
    public  Action Unknown0x1ED_0xA6CC_0xC59C()
    {

        // unknown_0x1ED_0x9123_0xAFF3();
        // unknown_0x1ED_0xA7A5_0xC675();
        // unknown_0x1ED_0xA83F_0xC70F();
        // unknown_0x1ED_0xA8BC_0xC78C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA7A5, "unknown", this::unknown0x1ED_0xA7A5_0xC675);
    public  Action Unknown0x1ED_0xA7A5_0xC675()
    {

        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        // unknown_0x1ED_0xD61D_0xF4ED();
        // unknown_0x1ED_0xDA5F_0xF92F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA7C2, "unknown", this::unknown0x1ED_0xA7C2_0xC692);
    public  Action Unknown0x1ED_0xA7C2_0xC692()
    {

        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA83F, "unknown", this::unknown0x1ED_0xA83F_0xC70F);
    public  Action Unknown0x1ED_0xA83F_0xC70F()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA87E, "audio_test_frequency_ida", this::audio_test_frequency_ida0x1ED_0xA87E_0xC74E);
    public  Action Audio_test_frequency_ida0x1ED_0xA87E_0xC74E()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // Not providing stub for dialogues.unknown. Reason: Function already has an override
    // defineFunction(0x1ED, 0xA8BC, "unknown", this::unknown0x1ED_0xA8BC_0xC78C);
    public  Action Unknown0x1ED_0xA8BC_0xC78C()
    {

        // dialogues.unknown_0x1ED_0xA8B1_0xC781 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xA9A1, "close_res_file_handle_ida", this::close_res_file_handle_ida0x1ED_0xA9A1_0xC871);
    public  Action Close_res_file_handle_ida0x1ED_0xA9A1_0xC871()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAA0F, "decode_sd_block_ida", this::decode_sd_block_ida0x1ED_0xAA0F_0xC8DF);
    public  Action Decode_sd_block_ida0x1ED_0xAA0F_0xC8DF()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAA96, "unknown", this::unknown0x1ED_0xAA96_0xC966);
    public  Action Unknown0x1ED_0xAA96_0xC966()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAB15, "audio_start_voc_ida", this::audio_start_voc_ida0x1ED_0xAB15_0xC9E5);
    public  Action Audio_start_voc_ida0x1ED_0xAB15_0xC9E5()
    {

        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAB45, "unknown", this::unknown0x1ED_0xAB45_0xCA15);
    public  Action Unknown0x1ED_0xAB45_0xCA15()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAB4F, "unknown", this::unknown0x1ED_0xAB4F_0xCA1F);
    public  Action Unknown0x1ED_0xAB4F_0xCA1F()
    {

        // unknown_0x1ED_0xA8BC_0xC78C();
        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xABA3, "check_res_file_open_ida", this::check_res_file_open_ida0x1ED_0xABA3_0xCA73);
    public  Action Check_res_file_open_ida0x1ED_0xABA3_0xCA73()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xABA9, "unknown", this::unknown0x1ED_0xABA9_0xCA79);
    public  Action Unknown0x1ED_0xABA9_0xCA79()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // Not providing stub for mainCode.isUnknownDC2BZero. Reason: Function already has an override
    // defineFunction(0x1ED, 0xABD5, "unknown", this::unknown0x1ED_0xABD5_0xCAA5);
    public  Action Unknown0x1ED_0xABD5_0xCAA5()
    {

        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAC14, "pcm_stop_voc_q_ida", this::pcm_stop_voc_q_ida0x1ED_0xAC14_0xCAE4);
    public  Action Pcm_stop_voc_q_ida0x1ED_0xAC14_0xCAE4()
    {

        // ida.close_res_file_handle_ida_0x1ED_0xA9A1_0xC871();
        // unknown_0x1ED_0xDA5F_0xF92F();
        // soundDriverPcSpeaker.clearAL_0x4822_0x109_0x48329 overriden();
        return NearRet();
    }

    // Not providing stub for sound.soundDriverUnknownClearAL/call_pcm_audio_vtable_func_5_ida. Reason: Function already
    // has an override
    // defineFunction(0x1ED, 0xAC3A, "unknown", this::unknown0x1ED_0xAC3A_0xCB0A);
    public  Action Unknown0x1ED_0xAC3A_0xCB0A()
    {

        // mainCode.isUnknownDBC80x100_0x1ED_0xAE28_0xCCF8 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xACE6, "unknown", this::unknown0x1ED_0xACE6_0xCBB6);
    public  Action Unknown0x1ED_0xACE6_0xCBB6()
    {

        // mainCode.isUnknownDC2BZero_0x1ED_0xABCC_0xCA9C overriden();
        // ida.load_music_ida_0x1ED_0xAE62_0xCD32();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x103_0x483B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAD43, "unknown", this::unknown0x1ED_0xAD43_0xCC13);
    public  Action Unknown0x1ED_0xAD43_0xCC13()
    {

        // ida.load_music_ida_0x1ED_0xAE62_0xCD32();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x103_0x483B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAD50, "unknown", this::unknown0x1ED_0xAD50_0xCC20);
    public  Action Unknown0x1ED_0xAD50_0xCC20()
    {

        // ida.load_music_ida_0x1ED_0xAE62_0xCD32();
        // sound.checkSoundPresent/midi_func_2_0_ida_0x1ED_0xAEB7_0xCD87 overriden();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x103_0x483B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAD57, "play_music_MORNING_HSQ_ida", this::play_music_MORNING_HSQ_ida0x1ED_0xAD57_0xCC27);
    public  Action Play_music_MORNING_HSQ_ida0x1ED_0xAD57_0xCC27()
    {

        // ida.load_music_ida_0x1ED_0xAE62_0xCD32();
        // sound.checkSoundPresent/midi_func_2_0_ida_0x1ED_0xAEB7_0xCD87 overriden();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x103_0x483B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAD5E, "unknown", this::unknown0x1ED_0xAD5E_0xCC2E);
    public  Action Unknown0x1ED_0xAD5E_0xCC2E()
    {

        // unknown_0x1ED_0xAA96_0xC966();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x109_0x483B9();
        // unknown_0x482B_0x10C_0x483BC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAD95, "unknown", this::unknown0x1ED_0xAD95_0xCC65);
    public  Action Unknown0x1ED_0xAD95_0xCC65()
    {

        // ida.load_music_ida_0x1ED_0xAE62_0xCD32();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x103_0x483B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xADBE, "unknown", this::unknown0x1ED_0xADBE_0xCC8E);
    public  Action Unknown0x1ED_0xADBE_0xCC8E()
    {

        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x482B_0x10C_0x483BC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xADE0, "unknown", this::unknown0x1ED_0xADE0_0xCCB0);
    public  Action Unknown0x1ED_0xADE0_0xCCB0()
    {

        // unknown_0x482B_0x10C_0x483BC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xADED, "unknown", this::unknown0x1ED_0xADED_0xCCBD);
    public  Action Unknown0x1ED_0xADED_0xCCBD()
    {

        // unknown_0x482B_0x10C_0x483BC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAE04, "unknown", this::unknown0x1ED_0xAE04_0xCCD4);
    public  Action Unknown0x1ED_0xAE04_0xCCD4()
    {

        // unknown_0x1ED_0xAD43_0xCC13();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // Not providing stub for mainCode.isUnknownDBC80x100. Reason: Function already has an override
    // Not providing stub for mainCode.isUnknownDBC8And1/check_pcm_enabled_ida. Reason: Function already has an override
    // defineFunction(0x1ED, 0xAE3F, "unknown", this::unknown0x1ED_0xAE3F_0xCD0F);
    public  Action Unknown0x1ED_0xAE3F_0xCD0F()
    {

        // mainCode.isUnknownDBC80x100_0x1ED_0xAE28_0xCCF8 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAE54, "unknown", this::unknown0x1ED_0xAE54_0xCD24);
    public  Action Unknown0x1ED_0xAE54_0xCD24()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAE62, "load_music_ida", this::load_music_ida0x1ED_0xAE62_0xCD32);
    public  Action Load_music_ida0x1ED_0xAE62_0xCD32()
    {

        // sound.checkSoundPresent/midi_func_2_0_ida_0x1ED_0xAEB7_0xCD87 overriden();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // Not providing stub for sound.checkSoundPresent/midi_func_2_0_ida. Reason: Function already has an override
    // Not providing stub for mainCode.isUnknownDBC80x100And2943BitmaskNonZero. Reason: Function already has an override
    // defineFunction(0x1ED, 0xAED6, "unknown", this::unknown0x1ED_0xAED6_0xCDA6);
    public  Action Unknown0x1ED_0xAED6_0xCDA6()
    {

        // unknown_0x1ED_0x181E_0x36EE();
        // unknown_0x1ED_0x18BA_0x378A();
        // unknown_0x1ED_0xAD43_0xCC13();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // mainCode.inc2788_0x1ED_0xB2B9_0xD189 overriden();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // map.setMapClickHandlerAddressToInGame_0x1ED_0xD95B_0xF82B overriden();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAF00, "unknown", this::unknown0x1ED_0xAF00_0xCDD0);
    public  Action Unknown0x1ED_0xAF00_0xCDD0()
    {

        // unknown_0x1ED_0xB147_0xD017();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xAF26, "unknown", this::unknown0x1ED_0xAF26_0xCDF6);
    public  Action Unknown0x1ED_0xAF26_0xCDF6()
    {

        // unknown_0x1ED_0xAF00_0xCDD0();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x1ED_0xC2F2_0xE1C2();
        // unknown_0x1ED_0xC432_0xE302();
        // unknown_0x1ED_0xD33A_0xF20A();
        // unknown_0x1ED_0xD72B_0xF5FB();
        // unknown_0x1ED_0xD7AD_0xF67D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB147, "unknown", this::unknown0x1ED_0xB147_0xD017);
    public  Action Unknown0x1ED_0xB147_0xD017()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB17A, "unknown", this::unknown0x1ED_0xB17A_0xD04A);
    public  Action Unknown0x1ED_0xB17A_0xD04A()
    {

        // unknown_0x1ED_0x96B5_0xB585();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB2AA, "unknown", this::unknown0x1ED_0xB2AA_0xD17A);
    public  Action Unknown0x1ED_0xB2AA_0xD17A()
    {

        // mainCode.inc2788_0x1ED_0xB2B9_0xD189 overriden();
        // unknown_0x1ED_0xD280_0xF150();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD338_0xF208();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB2B3, "unknown", this::unknown0x1ED_0xB2B3_0xD183);
    public  Action Unknown0x1ED_0xB2B3_0xD183()
    {
        return NearRet();
    }

    // Not providing stub for mainCode.inc2788. Reason: Function already has an override
    // Not providing stub for mainCode.setUnknown2788To0. Reason: Function already has an override
    // defineFunction(0x1ED, 0xB2C4, "unknown", this::unknown0x1ED_0xB2C4_0xD194);
    public  Action Unknown0x1ED_0xB2C4_0xD194()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD03C_0xEF0C();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        // unknown_0x1ED_0xE2E3_0x101B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB2CD, "unknown", this::unknown0x1ED_0xB2CD_0xD19D);
    public  Action Unknown0x1ED_0xB2CD_0xD19D()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD03C_0xEF0C();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        // unknown_0x1ED_0xE2E3_0x101B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB30F, "unknown", this::unknown0x1ED_0xB30F_0xD1DF);
    public  Action Unknown0x1ED_0xB30F_0xD1DF()
    {

        // unknown_0x1ED_0xB2C4_0xD194();
        // ida.strcpy_to_filename_buf_ida_0x1ED_0xF2FC_0x111CC();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB389, "open_sav_cl_ida", this::open_sav_cl_ida0x1ED_0xB389_0xD259);
    public  Action Open_sav_cl_ida0x1ED_0xB389_0xD259()
    {

        // ida.map_func_ida_0x1ED_0xB427_0xD2F7();
        // unknown_0x1ED_0xB4EA_0xD3BA();
        // ida.strcpy_to_filename_buf_ida_0x1ED_0xF2FC_0x111CC();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB427, "map_func_ida", this::map_func_ida0x1ED_0xB427_0xD2F7);
    public  Action Map_func_ida0x1ED_0xB427_0xD2F7()
    {

        // ida.alloc_cx_pages_to_di_ida_0x1ED_0xF11C_0x10FEC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB4EA, "unknown", this::unknown0x1ED_0xB4EA_0xD3BA);
    public  Action Unknown0x1ED_0xB4EA_0xD3BA()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB532, "unknown", this::unknown0x1ED_0xB532_0xD402);
    public  Action Unknown0x1ED_0xB532_0xD402()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB53B, "unknown", this::unknown0x1ED_0xB53B_0xD40B);
    public  Action Unknown0x1ED_0xB53B_0xD40B()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB56C, "unknown", this::unknown0x1ED_0xB56C_0xD43C);
    public  Action Unknown0x1ED_0xB56C_0xD43C()
    {

        // unknown_0x1ED_0xB53B_0xD40B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB58B, "map_func_ida", this::map_func_ida0x1ED_0xB58B_0xD45B);
    public  Action Map_func_ida0x1ED_0xB58B_0xD45B()
    {

        // unknown_0x1ED_0xB5A0_0xD470();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB5A0, "unknown", this::unknown0x1ED_0xB5A0_0xD470);
    public  Action Unknown0x1ED_0xB5A0_0xD470()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB5C5, "unknown", this::unknown0x1ED_0xB5C5_0xD495);
    public  Action Unknown0x1ED_0xB5C5_0xD495()
    {

        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB5CF, "unknown", this::unknown0x1ED_0xB5CF_0xD49F);
    public  Action Unknown0x1ED_0xB5CF_0xD49F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB5F9, "unknown", this::unknown0x1ED_0xB5F9_0xD4C9);
    public  Action Unknown0x1ED_0xB5F9_0xD4C9()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB647, "unknown", this::unknown0x1ED_0xB647_0xD517);
    public  Action Unknown0x1ED_0xB647_0xD517()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB683, "unknown", this::unknown0x1ED_0xB683_0xD553);
    public  Action Unknown0x1ED_0xB683_0xD553()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB69A, "unknown", this::unknown0x1ED_0xB69A_0xD56A);
    public  Action Unknown0x1ED_0xB69A_0xD56A()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB6C3, "map_func_ida", this::map_func_ida0x1ED_0xB6C3_0xD593);
    public  Action Map_func_ida0x1ED_0xB6C3_0xD593()
    {

        // unknown_0x1ED_0xB7D2_0xD6A2();
        // unknown_0x2538_0x142_0x254C2();
        // unknown_0x2538_0x157_0x254D7();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB7D2, "unknown", this::unknown0x1ED_0xB7D2_0xD6A2);
    public  Action Unknown0x1ED_0xB7D2_0xD6A2()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB827, "unknown", this::unknown0x1ED_0xB827_0xD6F7);
    public  Action Unknown0x1ED_0xB827_0xD6F7()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0xAA96_0xC966();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x1ED_0xB84A_0xD71A();
        // unknown_0x1ED_0xB87E_0xD74E();
        // unknown_0x1ED_0xB941_0xD811();
        // unknown_0x1ED_0xD72B_0xF5FB();
        // unknown_0x1ED_0xD7B2_0xF682();
        // unknown_0x482B_0x10C_0x483BC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB84A, "unknown", this::unknown0x1ED_0xB84A_0xD71A);
    public  Action Unknown0x1ED_0xB84A_0xD71A()
    {

        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // map.setSiToMapCursorTypeDC58_0x1ED_0xDAAA_0xF97A overriden();
        // unknown_0x2538_0x11E_0x2549E();
        // unknown_0x2538_0x145_0x254C5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB85A, "unknown", this::unknown0x1ED_0xB85A_0xD72A);
    public  Action Unknown0x1ED_0xB85A_0xD72A()
    {

        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // map.setSiToMapCursorTypeDC58_0x1ED_0xDAAA_0xF97A overriden();
        // unknown_0x2538_0x145_0x254C5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB87E, "unknown", this::unknown0x1ED_0xB87E_0xD74E);
    public  Action Unknown0x1ED_0xB87E_0xD74E()
    {

        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC305_0xE1D5();
        // unknown_0x1ED_0xC30D_0xE1DD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB8A7, "unknown", this::unknown0x1ED_0xB8A7_0xD777);
    public  Action Unknown0x1ED_0xB8A7_0xD777()
    {

        // unknown_0x1ED_0xBA75_0xD945();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB8C6, "unknown", this::unknown0x1ED_0xB8C6_0xD796);
    public  Action Unknown0x1ED_0xB8C6_0xD796()
    {

        // unknown_0x1ED_0x17E6_0x36B6();
        // unknown_0x1ED_0x5ADF_0x79AF();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // unknown_0x1ED_0xB8A7_0xD777();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB8F3, "unknown", this::unknown0x1ED_0xB8F3_0xD7C3);
    public  Action Unknown0x1ED_0xB8F3_0xD7C3()
    {

        // unknown_0x1ED_0xB84A_0xD71A();
        // unknown_0x1ED_0xB87E_0xD74E();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC43E_0xE30E();
        // unknown_0x1ED_0xC474_0xE344();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB915, "unknown", this::unknown0x1ED_0xB915_0xD7E5);
    public  Action Unknown0x1ED_0xB915_0xD7E5()
    {

        // mainCode.memCopy8Bytes_0x1ED_0x5BA8_0x7A78 overriden();
        // unknown_0x1ED_0xB87E_0xD74E();
        // unknown_0x1ED_0xB93B_0xD80B();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC305_0xE1D5();
        // unknown_0x1ED_0xC30D_0xE1DD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB930, "unknown", this::unknown0x1ED_0xB930_0xD800);
    public  Action Unknown0x1ED_0xB930_0xD800()
    {

        // unknown_0x1ED_0xDA5F_0xF92F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB93B, "unknown", this::unknown0x1ED_0xB93B_0xD80B);
    public  Action Unknown0x1ED_0xB93B_0xD80B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB941, "unknown", this::unknown0x1ED_0xB941_0xD811);
    public  Action Unknown0x1ED_0xB941_0xD811()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // unknown_0x1ED_0xD48A_0xF35A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB977, "map_func_gfx_ida", this::map_func_gfx_ida0x1ED_0xB977_0xD847);
    public  Action Map_func_gfx_ida0x1ED_0xB977_0xD847()
    {

        // unknown_0x2538_0x145_0x254C5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB98B, "unknown", this::unknown0x1ED_0xB98B_0xD85B);
    public  Action Unknown0x1ED_0xB98B_0xD85B()
    {

        // ida.map_func_gfx_ida_0x1ED_0xB977_0xD847();
        // unknown_0x1ED_0xBAF2_0xD9C2();
        // unknown_0x1ED_0xBC0C_0xDADC();
        // unknown_0x1ED_0xC4ED_0xE3BD();
        // unknown_0x1ED_0xDB67_0xFA37();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB9AE, "unknown", this::unknown0x1ED_0xB9AE_0xD87E);
    public  Action Unknown0x1ED_0xB9AE_0xD87E()
    {

        // unknown_0x1ED_0xBAF2_0xD9C2();
        // unknown_0x1ED_0xBC0C_0xDADC();
        // unknown_0x1ED_0xC4ED_0xE3BD();
        // unknown_0x1ED_0xDB67_0xFA37();
        // unknown_0x1ED_0xDB74_0xFA44();
        // unknown_0x2538_0x148_0x254C8();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB9B9, "unknown", this::unknown0x1ED_0xB9B9_0xD889);
    public  Action Unknown0x1ED_0xB9B9_0xD889()
    {

        // ida.map_func_gfx_ida_0x1ED_0xB977_0xD847();
        // unknown_0x1ED_0xBA15_0xD8E5();
        // unknown_0x1ED_0xBAF2_0xD9C2();
        // unknown_0x1ED_0xC4ED_0xE3BD();
        // unknown_0x1ED_0xDB67_0xFA37();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB9D3, "unknown", this::unknown0x1ED_0xB9D3_0xD8A3);
    public  Action Unknown0x1ED_0xB9D3_0xD8A3()
    {

        // ida.map_func_gfx_ida_0x1ED_0xB977_0xD847();
        // unknown_0x1ED_0xB9E0_0xD8B0();
        // unknown_0x1ED_0xBAF2_0xD9C2();
        // unknown_0x1ED_0xBC0C_0xDADC();
        // unknown_0x1ED_0xC4ED_0xE3BD();
        // unknown_0x1ED_0xDB67_0xFA37();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB9E0, "unknown", this::unknown0x1ED_0xB9E0_0xD8B0);
    public  Action Unknown0x1ED_0xB9E0_0xD8B0()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xB9F6, "unknown", this::unknown0x1ED_0xB9F6_0xD8C6);
    public  Action Unknown0x1ED_0xB9F6_0xD8C6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBA15, "unknown", this::unknown0x1ED_0xBA15_0xD8E5);
    public  Action Unknown0x1ED_0xBA15_0xD8E5()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBA75, "unknown", this::unknown0x1ED_0xBA75_0xD945);
    public  Action Unknown0x1ED_0xBA75_0xD945()
    {

        // unknown_0x1ED_0xB9F6_0xD8C6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBA9E, "unknown", this::unknown0x1ED_0xBA9E_0xD96E);
    public  Action Unknown0x1ED_0xBA9E_0xD96E()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0xB683_0xD553();
        // unknown_0x1ED_0xB98B_0xD85B();
        // unknown_0x1ED_0xB9E0_0xD8B0();
        // unknown_0x1ED_0xBA15_0xD8E5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBAF2, "unknown", this::unknown0x1ED_0xBAF2_0xD9C2);
    public  Action Unknown0x1ED_0xBAF2_0xD9C2()
    {

        // unknown_0x1ED_0x407E_0x5F4E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBC0C, "unknown", this::unknown0x1ED_0xBC0C_0xDADC);
    public  Action Unknown0x1ED_0xBC0C_0xDADC()
    {

        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBC1F, "unknown", this::unknown0x1ED_0xBC1F_0xDAEF);
    public  Action Unknown0x1ED_0xBC1F_0xDAEF()
    {

        // unknown_0x1ED_0xBC4E_0xDB1E();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // unknown_0x1ED_0xD48A_0xF35A();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBC4E, "unknown", this::unknown0x1ED_0xBC4E_0xDB1E);
    public  Action Unknown0x1ED_0xBC4E_0xDB1E()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBC99, "unknown", this::unknown0x1ED_0xBC99_0xDB69);
    public  Action Unknown0x1ED_0xBC99_0xDB69()
    {

        // unknown_0x1ED_0xBD00_0xDBD0();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xC551_0xE421();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBD00, "unknown", this::unknown0x1ED_0xBD00_0xDBD0);
    public  Action Unknown0x1ED_0xBD00_0xDBD0()
    {

        // unknown_0x1ED_0xC0D5_0xDFA5();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBDBB, "unknown", this::unknown0x1ED_0xBDBB_0xDC8B);
    public  Action Unknown0x1ED_0xBDBB_0xDC8B()
    {

        // unknown_0x1ED_0xBDFA_0xDCCA();
        // unknown_0x1ED_0xBED7_0xDDA7();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD1A6_0xF076();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBDFA, "unknown", this::unknown0x1ED_0xBDFA_0xDCCA);
    public  Action Unknown0x1ED_0xBDFA_0xDCCA()
    {

        // time.getSunlightDay_0x1ED_0x1AD1_0x39A1 overriden();
        // unknown_0x1ED_0xBFA7_0xDE77();
        // display.setFontToIntro_0x1ED_0xD068_0xEF38 overriden();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xE2DB_0x101AB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBE1D, "unknown", this::unknown0x1ED_0xBE1D_0xDCED);
    public  Action Unknown0x1ED_0xBE1D_0xDCED()
    {

        // unknown_0x1ED_0xBDFA_0xDCCA();
        // unknown_0x1ED_0xBED7_0xDDA7();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD1A6_0xF076();
        // unknown_0x1ED_0xDA25_0xF8F5();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBE57, "unknown", this::unknown0x1ED_0xBE57_0xDD27);
    public  Action Unknown0x1ED_0xBE57_0xDD27()
    {

        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xC2FD_0xE1CD();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xDB74_0xFA44();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBED7, "unknown", this::unknown0x1ED_0xBED7_0xDDA7);
    public  Action Unknown0x1ED_0xBED7_0xDDA7()
    {

        // unknown_0x1ED_0xBF26_0xDDF6();
        // unknown_0x1ED_0xC02E_0xDEFE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBF26, "unknown", this::unknown0x1ED_0xBF26_0xDDF6);
    public  Action Unknown0x1ED_0xBF26_0xDDF6()
    {

        // unknown_0x1ED_0xBF61_0xDE31();
        // unknown_0x1ED_0xBF73_0xDE43();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD03C_0xEF0C();
        // unknown_0x1ED_0xE31C_0x101EC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBF61, "unknown", this::unknown0x1ED_0xBF61_0xDE31);
    public  Action Unknown0x1ED_0xBF61_0xDE31()
    {

        // unknown_0x1ED_0xD03C_0xEF0C();
        // unknown_0x1ED_0xE31C_0x101EC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBF73, "unknown", this::unknown0x1ED_0xBF73_0xDE43);
    public  Action Unknown0x1ED_0xBF73_0xDE43()
    {

        // unknown_0x1ED_0xD03C_0xEF0C();
        // unknown_0x1ED_0xE2E3_0x101B3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBFA7, "unknown", this::unknown0x1ED_0xBFA7_0xDE77);
    public  Action Unknown0x1ED_0xBFA7_0xDE77()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xBFE3, "map_func_ida", this::map_func_ida0x1ED_0xBFE3_0xDEB3);
    public  Action Map_func_ida0x1ED_0xBFE3_0xDEB3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC02E, "unknown", this::unknown0x1ED_0xC02E_0xDEFE);
    public  Action Unknown0x1ED_0xC02E_0xDEFE()
    {

        // ida.map_func_ida_0x1ED_0xBFE3_0xDEB3();
        return NearRet();
    }

    // Not providing stub for display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida. Reason:
    // Function already has an override
    // Not providing stub for display.setDialogueVideoBufferSegmentDC32/set_backbuffer_as_frame_buffer_ida. Reason:
    // Function already has an override
    // Not providing stub for display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida. Reason: Function
    // already has an override
    // defineFunction(0x1ED, 0xC097, "gfx_call_bp_with_front_buffer_as_screen_ida",
    // this::gfx_call_bp_with_front_buffer_as_screen_ida0x1ED_0xC097_0xDF67);
    public  Action Gfx_call_bp_with_front_buffer_as_screen_ida0x1ED_0xC097_0xDF67()
    {

        // unknown_0x1ED_0x2C1_0x2191();
        // unknown_0x1ED_0x301_0x21D1();
        // ida.load_VIRGIN_HNM_ida_0x1ED_0x61C_0x24EC();
        // ida.load_CRYO_HNM_ida_0x1ED_0x64D_0x251D();
        // ida.load_CRYO2_HNM_ida_0x1ED_0x658_0x2528();
        // ida.load_PRESENT_HNM_ida_0x1ED_0x678_0x2548();
        // ida.load_INTRO_HNM_ida_0x1ED_0x69E_0x256E();
        // ida.play_CREDITS_HNM_ida_0x1ED_0x9EF_0x28BF();
        // unknown_0x1ED_0xED0_0x2DA0();
        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x2DB1_0x4C81();
        // unknown_0x1ED_0x2EB2_0x4D82();
        // unknown_0x1ED_0x5A56_0x7926();
        // unknown_0x1ED_0x98B2_0xB782();
        // unknown_0x1ED_0xAF26_0xCDF6();
        // unknown_0x1ED_0xB827_0xD6F7();
        // unknown_0x1ED_0xBE1D_0xDCED();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.load_IRULn_HSQ_ida_0x1ED_0xCEFC_0xEDCC();
        // unknown_0x1ED_0xD1EF_0xF0BF();
        // unknown_0x1ED_0xD717_0xF5E7();
        // unknown_0x1ED_0xD75A_0xF62A();
        return NearRet();
    }

    // Not providing stub for display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida. Reason: Function already has an
    // override
    // defineFunction(0x1ED, 0xC0D5, "unknown", this::unknown0x1ED_0xC0D5_0xDFA5);
    public  Action Unknown0x1ED_0xC0D5_0xDFA5()
    {

        // unknown_0x2538_0x15A_0x254DA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC0E8, "unknown", this::unknown0x1ED_0xC0E8_0xDFB8);
    public  Action Unknown0x1ED_0xC0E8_0xDFB8()
    {

        // unknown_0x2538_0x15A_0x254DA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC0F4, "unknown", this::unknown0x1ED_0xC0F4_0xDFC4);
    public  Action Unknown0x1ED_0xC0F4_0xDFC4()
    {

        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC102, "unknown", this::unknown0x1ED_0xC102_0xDFD2);
    public  Action Unknown0x1ED_0xC102_0xDFD2()
    {

        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // unknown_0x2538_0x151_0x254D1();
        // unknown_0x2538_0x160_0x254E0();
        // vgaDriver.copy_pal2_to_pal1_0x2538_0x17B_0x254FB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC108, "transition_ida", this::transition_ida0x1ED_0xC108_0xDFD8);
    public  Action Transition_ida0x1ED_0xC108_0xDFD8()
    {

        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // unknown_0x2538_0x151_0x254D1();
        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC137, "load_icons_sprites_ida", this::load_icons_sprites_ida0x1ED_0xC137_0xE007);
    public  Action Load_icons_sprites_ida0x1ED_0xC137_0xE007()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC13B, "unknown", this::unknown0x1ED_0xC13B_0xE00B);
    public  Action Unknown0x1ED_0xC13B_0xE00B()
    {

        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // vgaDriver.noOp_0x2538_0x13C_0x254BC overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC13E, "open_sprite_sheet_ida", this::open_sprite_sheet_ida0x1ED_0xC13E_0xE00E);
    public  Action Open_sprite_sheet_ida0x1ED_0xC13E_0xE00E()
    {

        // unknown_0x1ED_0xC1AA_0xE07A();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        // vgaDriver.noOp_0x2538_0x13C_0x254BC overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC1AA, "unknown", this::unknown0x1ED_0xC1AA_0xE07A);
    public  Action Unknown0x1ED_0xC1AA_0xE07A()
    {

        // unknown_0x2538_0x106_0x25486();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC1BA, "hnm_apply_palette_ida", this::hnm_apply_palette_ida0x1ED_0xC1BA_0xE08A);
    public  Action Hnm_apply_palette_ida0x1ED_0xC1BA_0xE08A()
    {

        // unknown_0x2538_0x106_0x25486();
        return NearRet();
    }

    // Not providing stub for datastructures.getEsSiPointerToUnknown. Reason: Function already has an override
    // defineFunction(0x1ED, 0xC202, "unknown", this::unknown0x1ED_0xC202_0xE0D2);
    public  Action Unknown0x1ED_0xC202_0xE0D2()
    {

        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC21B, "unknown", this::unknown0x1ED_0xC21B_0xE0EB);
    public  Action Unknown0x1ED_0xC21B_0xE0EB()
    {

        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC22F, "draw_sprite_ida", this::draw_sprite_ida0x1ED_0xC22F_0xE0FF);
    public  Action Draw_sprite_ida0x1ED_0xC22F_0xE0FF()
    {

        // unknown_0x1ED_0xC2A1_0xE171();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        // unknown_0x2538_0x169_0x254E9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC2A1, "unknown", this::unknown0x1ED_0xC2A1_0xE171);
    public  Action Unknown0x1ED_0xC2A1_0xE171()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC2F2, "unknown", this::unknown0x1ED_0xC2F2_0xE1C2);
    public  Action Unknown0x1ED_0xC2F2_0xE1C2()
    {

        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC2FD, "unknown", this::unknown0x1ED_0xC2FD_0xE1CD);
    public  Action Unknown0x1ED_0xC2FD_0xE1CD()
    {

        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC305, "unknown", this::unknown0x1ED_0xC305_0xE1D5);
    public  Action Unknown0x1ED_0xC305_0xE1D5()
    {

        // unknown_0x1ED_0xC30D_0xE1DD();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC30D, "unknown", this::unknown0x1ED_0xC30D_0xE1DD);
    public  Action Unknown0x1ED_0xC30D_0xE1DD()
    {

        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC343, "unknown", this::unknown0x1ED_0xC343_0xE213);
    public  Action Unknown0x1ED_0xC343_0xE213()
    {

        // unknown_0x2538_0x112_0x25492();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC412, "unknown", this::unknown0x1ED_0xC412_0xE2E2);
    public  Action Unknown0x1ED_0xC412_0xE2E2()
    {

        // vgaDriver.memcpyDSToESFor64000_0x2538_0x121_0x254A1 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC432, "unknown", this::unknown0x1ED_0xC432_0xE302);
    public  Action Unknown0x1ED_0xC432_0xE302()
    {

        // unknown_0x2538_0x11B_0x2549B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC43E, "unknown", this::unknown0x1ED_0xC43E_0xE30E);
    public  Action Unknown0x1ED_0xC43E_0xE30E()
    {

        // vgaDriver.copySquareOfPixelsSiIsSourceSegment_0x2538_0x12A_0x254AA overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC443, "unknown", this::unknown0x1ED_0xC443_0xE313);
    public  Action Unknown0x1ED_0xC443_0xE313()
    {

        // vgaDriver.copySquareOfPixelsSiIsSourceSegment_0x2538_0x12A_0x254AA overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC446, "unknown", this::unknown0x1ED_0xC446_0xE316);
    public  Action Unknown0x1ED_0xC446_0xE316()
    {

        // vgaDriver.copySquareOfPixelsSiIsSourceSegment_0x2538_0x12A_0x254AA overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC46F, "unknown", this::unknown0x1ED_0xC46F_0xE33F);
    public  Action Unknown0x1ED_0xC46F_0xE33F()
    {

        // vgaDriver.copySquareOfPixelsSiIsSourceSegment_0x2538_0x12A_0x254AA overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC474, "unknown", this::unknown0x1ED_0xC474_0xE344);
    public  Action Unknown0x1ED_0xC474_0xE344()
    {

        // vgaDriver.copyRectangle_0x2538_0x124_0x254A4();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC477, "gfx_copy_rect_at_si_ida", this::gfx_copy_rect_at_si_ida0x1ED_0xC477_0xE347);
    public  Action Gfx_copy_rect_at_si_ida0x1ED_0xC477_0xE347()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4AA, "gfx_copy_rect_to_screen_ida", this::gfx_copy_rect_to_screen_ida0x1ED_0xC4AA_0xE37A);
    public  Action Gfx_copy_rect_to_screen_ida0x1ED_0xC4AA_0xE37A()
    {

        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4CD, "gfx_copy_framebuf_to_screen_ida",
    // this::gfx_copy_framebuf_to_screen_ida0x1ED_0xC4CD_0xE39D);
    public  Action Gfx_copy_framebuf_to_screen_ida0x1ED_0xC4CD_0xE39D()
    {

        // vgaDriver.memcpyDSToESFor64000_0x2538_0x12D_0x254AD overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4DD, "unknown", this::unknown0x1ED_0xC4DD_0xE3AD);
    public  Action Unknown0x1ED_0xC4DD_0xE3AD()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4ED, "unknown", this::unknown0x1ED_0xC4ED_0xE3BD);
    public  Action Unknown0x1ED_0xC4ED_0xE3BD()
    {

        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4F0, "rect_at_si_to_regs_ida", this::rect_at_si_to_regs_ida0x1ED_0xC4F0_0xE3C0);
    public  Action Rect_at_si_to_regs_ida0x1ED_0xC4F0_0xE3C0()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC4FB, "unknown", this::unknown0x1ED_0xC4FB_0xE3CB);
    public  Action Unknown0x1ED_0xC4FB_0xE3CB()
    {

        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC51E, "unknown", this::unknown0x1ED_0xC51E_0xE3EE);
    public  Action Unknown0x1ED_0xC51E_0xE3EE()
    {

        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC53E, "unknown", this::unknown0x1ED_0xC53E_0xE40E);
    public  Action Unknown0x1ED_0xC53E_0xE40E()
    {

        // unknown_0x2538_0x139_0x254B9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC551, "unknown", this::unknown0x1ED_0xC551_0xE421);
    public  Action Unknown0x1ED_0xC551_0xE421()
    {

        // unknown_0x1ED_0xC53E_0xE40E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC560, "unknown", this::unknown0x1ED_0xC560_0xE430);
    public  Action Unknown0x1ED_0xC560_0xE430()
    {

        // unknown_0x1ED_0xC53E_0xE40E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC58A, "unknown", this::unknown0x1ED_0xC58A_0xE45A);
    public  Action Unknown0x1ED_0xC58A_0xE45A()
    {

        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC5CF, "unknown", this::unknown0x1ED_0xC5CF_0xE49F);
    public  Action Unknown0x1ED_0xC5CF_0xE49F()
    {

        // unknown_0x1ED_0xC13B_0xE00B();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x1ED_0xC202_0xE0D2();
        // unknown_0x1ED_0xC60B_0xE4DB();
        // unknown_0x1ED_0xE3DF_0x102AF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC60B, "unknown", this::unknown0x1ED_0xC60B_0xE4DB);
    public  Action Unknown0x1ED_0xC60B_0xE4DB()
    {

        // unknown_0x1ED_0xC13B_0xE00B();
        // datastructures.getEsSiPointerToUnknown_0x1ED_0xC1F4_0xE0C4 overriden();
        // unknown_0x1ED_0xC202_0xE0D2();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC661, "unknown", this::unknown0x1ED_0xC661_0xE531);
    public  Action Unknown0x1ED_0xC661_0xE531()
    {

        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC6AD_0xE57D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC6AD, "unknown", this::unknown0x1ED_0xC6AD_0xE57D);
    public  Action Unknown0x1ED_0xC6AD_0xE57D()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC30D_0xE1DD();
        // unknown_0x1ED_0xC443_0xE313();
        // unknown_0x1ED_0xC51E_0xE3EE();
        // unknown_0x1ED_0xC7D4_0xE6A4();
        // unknown_0x1ED_0xC835_0xE705();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC7D4, "unknown", this::unknown0x1ED_0xC7D4_0xE6A4);
    public  Action Unknown0x1ED_0xC7D4_0xE6A4()
    {

        // vgaDriver.moveSquareOfPixels_0x2538_0x130_0x254B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC835, "unknown", this::unknown0x1ED_0xC835_0xE705);
    public  Action Unknown0x1ED_0xC835_0xE705()
    {
        return NearRet();
    }

    // Not providing stub for dialogues.initDialogue. Reason: Function already has an override
    // Not providing stub for video.read33A3WithAxOffset/get_hnm_resource_flag_name_ptr_by_index_ax_to_bx_ida. Reason:
    // Function already has an override
    // defineFunction(0x1ED, 0xC92B, "hnm_reset_and_read_header_ida",
    // this::hnm_reset_and_read_header_ida0x1ED_0xC92B_0xE7FB);
    public  Action Hnm_reset_and_read_header_ida0x1ED_0xC92B_0xE7FB()
    {

        // ida.hnm_apply_palette_ida_0x1ED_0xC1BA_0xE08A();
        // video.read33A3WithAxOffset/get_hnm_resource_flag_name_ptr_by_index_ax_to_bx_ida_0x1ED_0xC921_0xE7F1 overriden();
        // ida.hnm_close_resource_ida_0x1ED_0xCA01_0xE8D1();
        // ida.hnm_read_header_size_ida_0x1ED_0xCD8F_0xEC5F();
        // ida.hnm_read_from_file_handle_ida_0x1ED_0xCDBF_0xEC8F();
        // unknown_0x1ED_0xCE01_0xECD1();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        // ida.open_res_or_file_or_die_ida_0x1ED_0xF229_0x110F9();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC9E8, "hnm_do_frame_skippable_ida", this::hnm_do_frame_skippable_ida0x1ED_0xC9E8_0xE8B8);
    public  Action Hnm_do_frame_skippable_ida0x1ED_0xC9E8_0xE8B8()
    {

        // ida.hnm_do_frame_ida_0x1ED_0xCA60_0xE930();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xC9F4, "do_frame_and_check_if_frame_advanced_ida",
    // this::do_frame_and_check_if_frame_advanced_ida0x1ED_0xC9F4_0xE8C4);
    public  Action Do_frame_and_check_if_frame_advanced_ida0x1ED_0xC9F4_0xE8C4()
    {

        // ida.hnm_do_frame_ida_0x1ED_0xCA60_0xE930();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCA01, "hnm_close_resource_ida", this::hnm_close_resource_ida0x1ED_0xCA01_0xE8D1);
    public  Action Hnm_close_resource_ida0x1ED_0xCA01_0xE8D1()
    {

        // unknown_0x1ED_0xCE01_0xECD1();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCA1B, "hnm_load_ida", this::hnm_load_ida0x1ED_0xCA1B_0xE8EB);
    public  Action Hnm_load_ida0x1ED_0xCA1B_0xE8EB()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        return NearRet();
    }

    // Not providing stub for video.videoPlayRelated. Reason: Function already has an override
    // Not providing stub for ida.hnm_do_frame_ida. Reason: Function has different return types: [NEAR, FAR, INTERRUPT]
    // Not providing stub for unknown. Reason: Function has different return types: [NEAR, FAR, INTERRUPT]
    // defineFunction(0x1ED, 0xCA9A, "unknown", this::unknown0x1ED_0xCA9A_0xE96A);
    public  Action Unknown0x1ED_0xCA9A_0xE96A()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCAA0, "unknown", this::unknown0x1ED_0xCAA0_0xE970);
    public  Action Unknown0x1ED_0xCAA0_0xE970()
    {

        // unknown_0x1ED_0xCCF4_0xEBC4();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCAD4, "unknown", this::unknown0x1ED_0xCAD4_0xE9A4);
    public  Action Unknown0x1ED_0xCAD4_0xE9A4()
    {

        // video.videoPlayRelated_0x1ED_0xCA59_0xE929 overriden();
        return NearRet();
    }

    // Not providing stub for unknown. Reason: Function has different return types: [NEAR, FAR, INTERRUPT]
    // defineFunction(0x1ED, 0xCC0C, "unknown", this::unknown0x1ED_0xCC0C_0xEADC);
    public  Action Unknown0x1ED_0xCC0C_0xEADC()
    {
        return NearRet();
    }

    // Not providing stub for unknown. Reason: Function has different return types: [NEAR, FAR, INTERRUPT]
    // defineFunction(0x1ED, 0xCC4E, "unknown", this::unknown0x1ED_0xCC4E_0xEB1E);
    public  Action Unknown0x1ED_0xCC4E_0xEB1E()
    {
        return NearRet();
    }

    // Not providing stub for video.isLastFrame/check_if_hnm_complete_ida. Reason: Function already has an override
    // defineFunction(0x1ED, 0xCC96, "hnm_decode_video_frame_ida", this::hnm_decode_video_frame_ida0x1ED_0xCC96_0xEB66);
    public  Action Hnm_decode_video_frame_ida0x1ED_0xCC96_0xEB66()
    {

        // unknown_0x1ED_0x4B2B_0x69FB();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        // vgaDriver.copy_fbuf_explode_and_center_ida_0x2538_0x133_0x254B3();
        // unknown_0x2538_0x136_0x254B6();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCCF4, "unknown", this::unknown0x1ED_0xCCF4_0xEBC4);
    public  Action Unknown0x1ED_0xCCF4_0xEBC4()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        // ida.hsq_decomp_skip_header_dssi_to_esdi_ida_0x1ED_0xF403_0x112D3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCD8F, "hnm_read_header_size_ida", this::hnm_read_header_size_ida0x1ED_0xCD8F_0xEC5F);
    public  Action Hnm_read_header_size_ida0x1ED_0xCD8F_0xEC5F()
    {

        // ida.hnm_read_from_file_handle_ida_0x1ED_0xCDBF_0xEC8F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCDA0, "hnm_prepare_header_read_ida", this::hnm_prepare_header_read_ida0x1ED_0xCDA0_0xEC70);
    public  Action Hnm_prepare_header_read_ida0x1ED_0xCDA0_0xEC70()
    {

        // ida.hnm_read_header_size_ida_0x1ED_0xCD8F_0xEC5F();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCDBF, "hnm_read_from_file_handle_ida",
    // this::hnm_read_from_file_handle_ida0x1ED_0xCDBF_0xEC8F);
    public  Action Hnm_read_from_file_handle_ida0x1ED_0xCDBF_0xEC8F()
    {

        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE01, "unknown", this::unknown0x1ED_0xCE01_0xECD1);
    public  Action Unknown0x1ED_0xCE01_0xECD1()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE07, "unknown", this::unknown0x1ED_0xCE07_0xECD7);
    public  Action Unknown0x1ED_0xCE07_0xECD7()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE1A, "hnm_reset_ida", this::hnm_reset_ida0x1ED_0xCE1A_0xECEA);
    public  Action Hnm_reset_ida0x1ED_0xCE1A_0xECEA()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE3B, "hnm_handle_pal_chunk_ida", this::hnm_handle_pal_chunk_ida0x1ED_0xCE3B_0xED0B);
    public  Action Hnm_handle_pal_chunk_ida0x1ED_0xCE3B_0xED0B()
    {

        // ida.hnm_apply_palette_ida_0x1ED_0xC1BA_0xE08A();
        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE53, "unknown", this::unknown0x1ED_0xCE53_0xED23);
    public  Action Unknown0x1ED_0xCE53_0xED23()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCE6C, "initialize_memory_handler_ida",
    // this::initialize_memory_handler_ida0x1ED_0xCE6C_0xED3C);
    public  Action Initialize_memory_handler_ida0x1ED_0xCE6C_0xED3C()
    {

        // video.read33A3WithAxOffset/get_hnm_resource_flag_name_ptr_by_index_ax_to_bx_ida_0x1ED_0xC921_0xE7F1 overriden();
        // unknown_0x1ED_0xCE01_0xECD1();
        // unknown_0x1ED_0xCEB0_0xED80();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCEB0, "unknown", this::unknown0x1ED_0xCEB0_0xED80);
    public  Action Unknown0x1ED_0xCEB0_0xED80()
    {

        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // video.read33A3WithAxOffset/get_hnm_resource_flag_name_ptr_by_index_ax_to_bx_ida_0x1ED_0xC921_0xE7F1 overriden();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCEC9, "unknown", this::unknown0x1ED_0xCEC9_0xED99);
    public  Action Unknown0x1ED_0xCEC9_0xED99()
    {

        // unknown_0x1ED_0xCAA0_0xE970();
        // unknown_0x1ED_0xCAD4_0xE9A4();
        // unknown_0x1ED_0xCC4E_0xEB1E();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCEFC, "load_IRULn_HSQ_ida", this::load_IRULn_HSQ_ida0x1ED_0xCEFC_0xEDCC);
    public  Action Load_IRULn_HSQ_ida0x1ED_0xCEFC_0xEDCC()
    {

        // ida.decode_sd_block_ida_0x1ED_0xAA0F_0xC8DF();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // ida.hnm_reset_and_read_header_ida_0x1ED_0xC92B_0xE7FB();
        // unknown_0x1ED_0xCB1A_0xE9EA();
        // ida.hnm_decode_video_frame_ida_0x1ED_0xCC96_0xEB66();
        // unknown_0x1ED_0xCCF4_0xEBC4();
        // ida.hnm_prepare_header_read_ida_0x1ED_0xCDA0_0xEC70();
        // ida.hnm_reset_ida_0x1ED_0xCE1A_0xECEA();
        // vgaDriver.updateVgaOffset01A3FromLineNumberAsAx_0x2538_0x163_0x254E3 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCF1B, "play_IRULx_HSQ_ida", this::play_IRULx_HSQ_ida0x1ED_0xCF1B_0xEDEB);
    public  Action Play_IRULx_HSQ_ida0x1ED_0xCF1B_0xEDEB()
    {

        // ida.pcm_stop_voc_q_ida_0x1ED_0xAC14_0xCAE4();
        // ida.play_music_MORNING_HSQ_ida_0x1ED_0xAD57_0xCC27();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.hnm_do_frame_skippable_ida_0x1ED_0xC9E8_0xE8B8();
        // ida.hnm_close_resource_ida_0x1ED_0xCA01_0xE8D1();
        // video.isLastFrame/check_if_hnm_complete_ida_0x1ED_0xCC85_0xEB55 overriden();
        // ida.IRULx_draw_or_clear_subtitle_ida_0x1ED_0xCF4B_0xEE1B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCF4B, "IRULx_draw_or_clear_subtitle_ida",
    // this::IRULx_draw_or_clear_subtitle_ida0x1ED_0xCF4B_0xEE1B);
    public  Action IRULx_draw_or_clear_subtitle_ida0x1ED_0xCF4B_0xEE1B()
    {

        // vgaDriver.blit_0x2538_0x10F_0x2548F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCF70, "unknown", this::unknown0x1ED_0xCF70_0xEE40);
    public  Action Unknown0x1ED_0xCF70_0xEE40()
    {

        // ida.load_PHRASExx_HSQ_ida_0x1ED_0xD00F_0xEEDF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCFA0, "check_amr_or_eng_language_ida",
    // this::check_amr_or_eng_language_ida0x1ED_0xCFA0_0xEE70);
    public  Action Check_amr_or_eng_language_ida0x1ED_0xCFA0_0xEE70()
    {

        // mainCode.isUnknownDBC8And1/check_pcm_enabled_ida_0x1ED_0xAE2F_0xCCFF overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xCFB9, "unknown", this::unknown0x1ED_0xCFB9_0xEE89);
    public  Action Unknown0x1ED_0xCFB9_0xEE89()
    {

        // datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida_0x1ED_0x98_0x1F68 overriden();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD00F, "load_PHRASExx_HSQ_ida", this::load_PHRASExx_HSQ_ida0x1ED_0xD00F_0xEEDF);
    public  Action Load_PHRASExx_HSQ_ida0x1ED_0xD00F_0xEEDF()
    {

        // datastructures.convertIndexTableToPointerTable/adjust_sub_resource_pointers_ida_0x1ED_0x98_0x1F68 overriden();
        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD03C, "unknown", this::unknown0x1ED_0xD03C_0xEF0C);
    public  Action Unknown0x1ED_0xD03C_0xEF0C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD04E, "unknown", this::unknown0x1ED_0xD04E_0xEF1E);
    public  Action Unknown0x1ED_0xD04E_0xEF1E()
    {
        return NearRet();
    }

    // Not providing stub for display.getCharacterCoordsXY. Reason: Function already has an override
    // Not providing stub for display.setFontToIntro. Reason: Function already has an override
    // Not providing stub for display.setFontToMenu. Reason: Function already has an override
    // defineFunction(0x1ED, 0xD096, "unknown", this::unknown0x1ED_0xD096_0xEF66);
    public  Action Unknown0x1ED_0xD096_0xEF66()
    {

        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // unknown_0x2538_0x115_0x25495();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD12F, "unknown", this::unknown0x1ED_0xD12F_0xEFFF);
    public  Action Unknown0x1ED_0xD12F_0xEFFF()
    {

        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // unknown_0x2538_0x115_0x25495();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD194, "unknown", this::unknown0x1ED_0xD194_0xF064);
    public  Action Unknown0x1ED_0xD194_0xF064()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD1BB_0xF08B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD19B, "unknown", this::unknown0x1ED_0xD19B_0xF06B);
    public  Action Unknown0x1ED_0xD19B_0xF06B()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD1BB_0xF08B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD1A6, "unknown", this::unknown0x1ED_0xD1A6_0xF076);
    public  Action Unknown0x1ED_0xD1A6_0xF076()
    {

        // unknown_0x1ED_0xD194_0xF064();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD1BB, "unknown", this::unknown0x1ED_0xD1BB_0xF08B);
    public  Action Unknown0x1ED_0xD1BB_0xF08B()
    {

        // unknown_0x1ED_0xD096_0xEF66();
        // unknown_0x1ED_0xD12F_0xEFFF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD1EF, "unknown", this::unknown0x1ED_0xD1EF_0xF0BF);
    public  Action Unknown0x1ED_0xD1EF_0xF0BF()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD1F2, "unknown", this::unknown0x1ED_0xD1F2_0xF0C2);
    public  Action Unknown0x1ED_0xD1F2_0xF0C2()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD200, "unknown", this::unknown0x1ED_0xD200_0xF0D0);
    public  Action Unknown0x1ED_0xD200_0xF0D0()
    {

        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // unknown_0x2538_0x11B_0x2549B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD239, "unknown", this::unknown0x1ED_0xD239_0xF109);
    public  Action Unknown0x1ED_0xD239_0xF109()
    {

        // unknown_0x1ED_0x1A34_0x3904();
        // unknown_0x1ED_0xD1F2_0xF0C2();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD23D, "unknown", this::unknown0x1ED_0xD23D_0xF10D);
    public  Action Unknown0x1ED_0xD23D_0xF10D()
    {

        // unknown_0x1ED_0x1A34_0x3904();
        // unknown_0x1ED_0xD1F2_0xF0C2();
        // unknown_0x1ED_0xE387_0x10257();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD280, "unknown", this::unknown0x1ED_0xD280_0xF150);
    public  Action Unknown0x1ED_0xD280_0xF150()
    {

        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD2BD, "unknown", this::unknown0x1ED_0xD2BD_0xF18D);
    public  Action Unknown0x1ED_0xD2BD_0xF18D()
    {

        // unknown_0x1ED_0xD2EA_0xF1BA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD2EA, "unknown", this::unknown0x1ED_0xD2EA_0xF1BA);
    public  Action Unknown0x1ED_0xD2EA_0xF1BA()
    {

        // mainCode.noOp_0x1ED_0xF66_0x2E36 overriden();
        // unknown_0x1ED_0x19FC_0x38CC();
        // unknown_0x1ED_0x4415_0x62E5();
        // unknown_0x1ED_0x5F91_0x7E61();
        // unknown_0x1ED_0x7D68_0x9C38();
        // unknown_0x1ED_0x97CF_0xB69F();
        // unknown_0x1ED_0xA541_0xC411();
        // unknown_0x1ED_0xB2B3_0xD183();
        // unknown_0x1ED_0xD36D_0xF23D();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD2FD, "unknown", this::unknown0x1ED_0xD2FD_0xF1CD);
    public  Action Unknown0x1ED_0xD2FD_0xF1CD()
    {

        // unknown_0x1ED_0xD36D_0xF23D();
        return NearRet();
    }

    // Not providing stub for mainCode.menuAnimationRelated. Reason: Function already has an override
    // defineFunction(0x1ED, 0xD323, "unknown", this::unknown0x1ED_0xD323_0xF1F3);
    public  Action Unknown0x1ED_0xD323_0xF1F3()
    {

        // unknown_0x1ED_0xD280_0xF150();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD338_0xF208();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD338, "unknown", this::unknown0x1ED_0xD338_0xF208);
    public  Action Unknown0x1ED_0xD338_0xF208()
    {

        // unknown_0x1ED_0x8751_0xA621();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD33A, "unknown", this::unknown0x1ED_0xD33A_0xF20A);
    public  Action Unknown0x1ED_0xD33A_0xF20A()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD36D, "unknown", this::unknown0x1ED_0xD36D_0xF23D);
    public  Action Unknown0x1ED_0xD36D_0xF23D()
    {

        // unknown_0x1ED_0x9285_0xB155();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD397, "unknown", this::unknown0x1ED_0xD397_0xF267);
    public  Action Unknown0x1ED_0xD397_0xF267()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // unknown_0x1ED_0xD48A_0xF35A();
        return NearRet();
    }

    // Not providing stub for mainCode.setBpToCurrentMenuTypeForScreenAction. Reason: Function already has an override
    // defineFunction(0x1ED, 0xD42F, "unknown", this::unknown0x1ED_0xD42F_0xF2FF);
    public  Action Unknown0x1ED_0xD42F_0xF2FF()
    {

        // unknown_0x1ED_0xA3E_0x290E();
        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x189A_0x376A();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x5ADF_0x79AF();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0x8770_0xA640();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xADBE_0xCC8E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // mainCode.setUnknown2788To0_0x1ED_0xB2BE_0xD18E overriden();
        // unknown_0x1ED_0xB930_0xD800();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC412_0xE2E2();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // ida.hnm_close_resource_ida_0x1ED_0xCA01_0xE8D1();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // map.setMapClickHandlerAddressToInGame_0x1ED_0xD95B_0xF82B overriden();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD434, "unknown", this::unknown0x1ED_0xD434_0xF304);
    public  Action Unknown0x1ED_0xD434_0xF304()
    {

        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x80AC_0x9F7C();
        // unknown_0x1ED_0x80DF_0x9FAF();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xB2AA_0xD17A();
        // unknown_0x1ED_0xB30F_0xD1DF();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD280_0xF150();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD338_0xF208();
        // unknown_0x1ED_0xD33A_0xF20A();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD439, "unknown", this::unknown0x1ED_0xD439_0xF309);
    public  Action Unknown0x1ED_0xD439_0xF309()
    {

        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x3AF9_0x59C9();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x7B1B_0x99EB();
        // unknown_0x1ED_0x7BE0_0x9AB0();
        // unknown_0x1ED_0x7C02_0x9AD2();
        // unknown_0x1ED_0x7DD9_0x9CA9();
        // unknown_0x1ED_0x7E1E_0x9CEE();
        // unknown_0x1ED_0x7E3D_0x9D0D();
        // unknown_0x1ED_0x7EFB_0x9DCB();
        // unknown_0x1ED_0x7F27_0x9DF7();
        // unknown_0x1ED_0x8250_0xA120();
        // unknown_0x1ED_0x82B7_0xA187();
        // unknown_0x1ED_0x82DA_0xA1AA();
        // unknown_0x1ED_0x84A6_0xA376();
        // unknown_0x1ED_0x9197_0xB067();
        // unknown_0x1ED_0x91A0_0xB070();
        // unknown_0x1ED_0x93DF_0xB2AF();
        // unknown_0x1ED_0x9908_0xB7D8();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9BAC_0xBA7C();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xB2AA_0xD17A();
        // unknown_0x1ED_0xB30F_0xD1DF();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD194_0xF064();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD280_0xF150();
        // unknown_0x1ED_0xD2FD_0xF1CD();
        // unknown_0x1ED_0xD323_0xF1F3();
        // unknown_0x1ED_0xD338_0xF208();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD43E, "unknown", this::unknown0x1ED_0xD43E_0xF30E);
    public  Action Unknown0x1ED_0xD43E_0xF30E()
    {

        // unknown_0x1ED_0x181E_0x36EE();
        // unknown_0x1ED_0x2EFB_0x4DCB();
        // unknown_0x1ED_0x3093_0x4F63();
        // unknown_0x1ED_0x38E1_0x57B1();
        // unknown_0x1ED_0x439F_0x626F();
        // unknown_0x1ED_0x445D_0x632D();
        // unknown_0x1ED_0x4658_0x6528();
        // unknown_0x1ED_0x49EA_0x68BA();
        // mainCode.setUnknown11CATo1_0x1ED_0x4ACA_0x699A overriden();
        // unknown_0x1ED_0x58FA_0x77CA();
        // unknown_0x1ED_0x5A1A_0x78EA();
        // unknown_0x1ED_0x5B5D_0x7A2D();
        // unknown_0x1ED_0x5B93_0x7A63();
        // mainCode.memCopy8BytesDsSIToDsDi_0x1ED_0x5B99_0x7A69 overriden();
        // unknown_0x1ED_0x5DCE_0x7C9E();
        // unknown_0x1ED_0x5F79_0x7E49();
        // unknown_0x1ED_0x66CE_0x859E();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x6906_0x87D6();
        // unknown_0x1ED_0x697C_0x884C();
        // unknown_0x1ED_0x69A3_0x8873();
        // unknown_0x1ED_0x6ACB_0x899B();
        // unknown_0x1ED_0x780A_0x96DA();
        // unknown_0x1ED_0x79DE_0x98AE();
        // unknown_0x1ED_0x7B58_0x9A28();
        // unknown_0x1ED_0x7BB9_0x9A89();
        // unknown_0x1ED_0x7C02_0x9AD2();
        // unknown_0x1ED_0x8C8A_0xAB5A();
        // unknown_0x1ED_0x90BD_0xAF8D();
        // unknown_0x1ED_0x956D_0xB43D();
        // unknown_0x1ED_0x98B2_0xB782();
        // unknown_0x1ED_0x98E6_0xB7B6();
        // unknown_0x1ED_0x9F31_0xBE01();
        // unknown_0x1ED_0x9F8B_0xBE5B();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA42C_0xC2FC();
        // unknown_0x1ED_0xA44C_0xC31C();
        // unknown_0x1ED_0xA47D_0xC34D();
        // unknown_0x1ED_0xA4C6_0xC396();
        // unknown_0x1ED_0xA7C2_0xC692();
        // unknown_0x1ED_0xAB4F_0xCA1F();
        // unknown_0x1ED_0xAC3A_0xCB0A();
        // mainCode.inc2788_0x1ED_0xB2B9_0xD189 overriden();
        // unknown_0x1ED_0xB2CD_0xD19D();
        // ida.open_sav_cl_ida_0x1ED_0xB389_0xD259();
        // ida.map_func_ida_0x1ED_0xB6C3_0xD593();
        // unknown_0x1ED_0xB8F3_0xD7C3();
        // unknown_0x1ED_0xB915_0xD7E5();
        // unknown_0x1ED_0xB98B_0xD85B();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xC21B_0xE0EB();
        // ida.draw_sprite_ida_0x1ED_0xC22F_0xE0FF();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // unknown_0x1ED_0xC4DD_0xE3AD();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD280_0xF150();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // unknown_0x1ED_0xD323_0xF1F3();
        // unknown_0x1ED_0xD338_0xF208();
        // unknown_0x1ED_0xD33A_0xF20A();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD72B_0xF5FB();
        // map.setMapClickHandlerAddressFromAx_0x1ED_0xD95E_0xF82E overriden();
        // map.setSiToMapCursorTypeDC58_0x1ED_0xDAAA_0xF97A overriden();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        // unknown_0x1ED_0xDDB0_0xFC80();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        // unknown_0x2538_0x151_0x254D1();
        // unknown_0x2538_0x160_0x254E0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD443, "dispatcherJumpsToBX", this::dispatcherJumpsToBX0x1ED_0xD443_0xF313);
    public  Action DispatcherJumpsToBX0x1ED_0xD443_0xF313()
    {

        // unknown_0x1ED_0x1797_0x3667();
        // unknown_0x1ED_0x17BE_0x368E();
        // unknown_0x1ED_0x181E_0x36EE();
        // unknown_0x1ED_0x1834_0x3704();
        // unknown_0x1ED_0x186B_0x373B();
        // unknown_0x1ED_0x18BA_0x378A();
        // unknown_0x1ED_0x2170_0x4040();
        // ida.open_SAL_resource_ida_0x1ED_0x2D74_0x4C44();
        // unknown_0x1ED_0x2DBF_0x4C8F();
        // unknown_0x1ED_0x2E98_0x4D68();
        // unknown_0x1ED_0x31F6_0x50C6();
        // unknown_0x1ED_0x35AD_0x547D();
        // unknown_0x1ED_0x37B2_0x5682();
        // unknown_0x1ED_0x38E1_0x57B1();
        // unknown_0x1ED_0x4057_0x5F27();
        // unknown_0x1ED_0x407E_0x5F4E();
        // unknown_0x1ED_0x409A_0x5F6A();
        // unknown_0x1ED_0x40AE_0x5F7E();
        // unknown_0x1ED_0x40C3_0x5F93();
        // unknown_0x1ED_0x40D5_0x5FA5();
        // unknown_0x1ED_0x4182_0x6052();
        // unknown_0x1ED_0x41C5_0x6095();
        // unknown_0x1ED_0x425B_0x612B();
        // unknown_0x1ED_0x4795_0x6665();
        // unknown_0x1ED_0x4944_0x6814();
        // unknown_0x1ED_0x49EA_0x68BA();
        // unknown_0x1ED_0x4AB8_0x6988();
        // mainCode.setUnknown11CATo0_0x1ED_0x4AC4_0x6994 overriden();
        // unknown_0x1ED_0x4B3B_0x6A0B();
        // unknown_0x1ED_0x4D00_0x6BD0();
        // unknown_0x1ED_0x503C_0x6F0C();
        // unknown_0x1ED_0x5ADF_0x79AF();
        // unknown_0x1ED_0x5B5D_0x7A2D();
        // mainCode.memCopy8BytesFrom1470ToD83C_0x1ED_0x5BA0_0x7A70 overriden();
        // unknown_0x1ED_0x5BB0_0x7A80();
        // unknown_0x1ED_0x68EB_0x87BB();
        // unknown_0x1ED_0x693B_0x880B();
        // unknown_0x1ED_0x6A89_0x8959();
        // unknown_0x1ED_0x6ACB_0x899B();
        // unknown_0x1ED_0x7BA3_0x9A73();
        // unknown_0x1ED_0x7BB9_0x9A89();
        // unknown_0x1ED_0x7C63_0x9B33();
        // unknown_0x1ED_0x7E1E_0x9CEE();
        // unknown_0x1ED_0x7EFB_0x9DCB();
        // unknown_0x1ED_0x88D2_0xA7A2();
        // unknown_0x1ED_0x9719_0xB5E9();
        // display.set479ETo0_0x1ED_0x9901_0xB7D1 overriden();
        // unknown_0x1ED_0x9B49_0xBA19();
        // unknown_0x1ED_0x9EFD_0xBDCD();
        // unknown_0x1ED_0x9F40_0xBE10();
        // unknown_0x1ED_0x9F9E_0xBE6E();
        // unknown_0x1ED_0xA03F_0xBF0F();
        // unknown_0x1ED_0xA1C4_0xC094();
        // unknown_0x1ED_0xA1E2_0xC0B2();
        // unknown_0x1ED_0xA7C2_0xC692();
        // ida.close_res_file_handle_ida_0x1ED_0xA9A1_0xC871();
        // unknown_0x1ED_0xAD43_0xCC13();
        // unknown_0x1ED_0xAD5E_0xCC2E();
        // unknown_0x1ED_0xADBE_0xCC8E();
        // unknown_0x1ED_0xAE04_0xCCD4();
        // mainCode.isUnknownDBC80x100And2943BitmaskNonZero_0x1ED_0xAEC6_0xCD96 overriden();
        // unknown_0x1ED_0xB2CD_0xD19D();
        // ida.open_sav_cl_ida_0x1ED_0xB389_0xD259();
        // unknown_0x1ED_0xB532_0xD402();
        // ida.map_func_ida_0x1ED_0xB58B_0xD45B();
        // unknown_0x1ED_0xB930_0xD800();
        // unknown_0x1ED_0xBA9E_0xD96E();
        // unknown_0x1ED_0xBC99_0xDB69();
        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // ida.gfx_call_bp_with_front_buffer_as_screen_ida_0x1ED_0xC097_0xDF67();
        // unknown_0x1ED_0xC0D5_0xDFA5();
        // unknown_0x1ED_0xC0F4_0xDFC4();
        // ida.transition_ida_0x1ED_0xC108_0xDFD8();
        // unknown_0x1ED_0xC13B_0xE00B();
        // unknown_0x1ED_0xC412_0xE2E2();
        // unknown_0x1ED_0xC474_0xE344();
        // ida.gfx_copy_framebuf_to_screen_ida_0x1ED_0xC4CD_0xE39D();
        // ida.hnm_close_resource_ida_0x1ED_0xCA01_0xE8D1();
        // unknown_0x1ED_0xD239_0xF109();
        // unknown_0x1ED_0xD23D_0xF10D();
        // unknown_0x1ED_0xD2BD_0xF18D();
        // unknown_0x1ED_0xD2EA_0xF1BA();
        // mainCode.menuAnimationRelated_0x1ED_0xD316_0xF1E6 overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD717_0xF5E7();
        // unknown_0x1ED_0xDA5F_0xF92F();
        // map.initMapCursorTypeDC58To0_0x1ED_0xDAA3_0xF973 overriden();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        // unknown_0x1ED_0xDDB0_0xFC80();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        // unknown_0x1ED_0xE387_0x10257();
        // unknown_0x1ED_0xE3CC_0x1029C();
        // ida.uninitialize_memory_driver_ida_0x1ED_0xE8D5_0x107A5();
        // unknown_0x2538_0x160_0x254E0();
        // soundDriverPcSpeaker.clearAL_0x4822_0x103_0x48323 overriden();
        // soundDriverPcSpeaker.clearAL_0x4822_0x109_0x48329 overriden();
        // soundDriverPcSpeaker.clearAL_0x482B_0x106_0x483B6 overriden();
        // providedInterrupts.provided_interrupt_handler_0x10_0xF000_0xA_0xF000A overriden();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD454, "dispatcherHelperDeterminesWhereToJump",
    // this::dispatcherHelperDeterminesWhereToJump0x1ED_0xD454_0xF324);
    public  Action DispatcherHelperDeterminesWhereToJump0x1ED_0xD454_0xF324()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD48A, "unknown", this::unknown0x1ED_0xD48A_0xF35A);
    public  Action Unknown0x1ED_0xD48A_0xF35A()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD04E_0xEF1E();
        // display.getCharacterCoordsXY_0x1ED_0xD05F_0xEF2F overriden();
        // display.setFontToMenu_0x1ED_0xD075_0xEF45 overriden();
        // unknown_0x1ED_0xD12F_0xEFFF();
        // unknown_0x1ED_0xD1BB_0xF08B();
        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD50F, "unknown", this::unknown0x1ED_0xD50F_0xF3DF);
    public  Action Unknown0x1ED_0xD50F_0xF3DF()
    {

        // unknown_0x1ED_0x9285_0xB155();
        // unknown_0x1ED_0x92C9_0xB199();
        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // mainCode.dispatcherHelperDeterminesWhereToJump_0x1ED_0xD454_0xF324();
        // unknown_0x1ED_0xD48A_0xF35A();
        // unknown_0x1ED_0xD6FE_0xF5CE();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD61D, "unknown", this::unknown0x1ED_0xD61D_0xF4ED);
    public  Action Unknown0x1ED_0xD61D_0xF4ED()
    {

        // mainCode.setBpToCurrentMenuTypeForScreenAction_0x1ED_0xD41B_0xF2EB overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD64E, "unknown", this::unknown0x1ED_0xD64E_0xF51E);
    public  Action Unknown0x1ED_0xD64E_0xF51E()
    {

        // unknown_0x1ED_0xD50F_0xF3DF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD65A, "unknown", this::unknown0x1ED_0xD65A_0xF52A);
    public  Action Unknown0x1ED_0xD65A_0xF52A()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD694, "unknown", this::unknown0x1ED_0xD694_0xF564);
    public  Action Unknown0x1ED_0xD694_0xF564()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD6B7, "unknown", this::unknown0x1ED_0xD6B7_0xF587);
    public  Action Unknown0x1ED_0xD6B7_0xF587()
    {

        // unknown_0x1ED_0xD694_0xF564();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD6FE, "unknown", this::unknown0x1ED_0xD6FE_0xF5CE);
    public  Action Unknown0x1ED_0xD6FE_0xF5CE()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD717, "unknown", this::unknown0x1ED_0xD717_0xF5E7);
    public  Action Unknown0x1ED_0xD717_0xF5E7()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        // unknown_0x1ED_0xD741_0xF611();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD72B, "unknown", this::unknown0x1ED_0xD72B_0xF5FB);
    public  Action Unknown0x1ED_0xD72B_0xF5FB()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        // unknown_0x1ED_0xD741_0xF611();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD741, "unknown", this::unknown0x1ED_0xD741_0xF611);
    public  Action Unknown0x1ED_0xD741_0xF611()
    {

        // unknown_0x2538_0x11E_0x2549E();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD75A, "unknown", this::unknown0x1ED_0xD75A_0xF62A);
    public  Action Unknown0x1ED_0xD75A_0xF62A()
    {

        // unknown_0x1ED_0x1A34_0x3904();
        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD1F2_0xF0C2();
        // unknown_0x1ED_0xD200_0xF0D0();
        // unknown_0x1ED_0xD795_0xF665();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD763, "unknown", this::unknown0x1ED_0xD763_0xF633);
    public  Action Unknown0x1ED_0xD763_0xF633()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD1F2_0xF0C2();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD792, "unknown", this::unknown0x1ED_0xD792_0xF662);
    public  Action Unknown0x1ED_0xD792_0xF662()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD795, "unknown", this::unknown0x1ED_0xD795_0xF665);
    public  Action Unknown0x1ED_0xD795_0xF665()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD7AD, "unknown", this::unknown0x1ED_0xD7AD_0xF67D);
    public  Action Unknown0x1ED_0xD7AD_0xF67D()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD7B2, "unknown", this::unknown0x1ED_0xD7B2_0xF682);
    public  Action Unknown0x1ED_0xD7B2_0xF682()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // unknown_0x1ED_0xD200_0xF0D0();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xD7B7, "unknown", this::unknown0x1ED_0xD7B7_0xF687);
    public  Action Unknown0x1ED_0xD7B7_0xF687()
    {

        // ida.load_icons_sprites_ida_0x1ED_0xC137_0xE007();
        // ida.open_sprite_sheet_ida_0x1ED_0xC13E_0xE00E();
        // unknown_0x1ED_0xD763_0xF633();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        // ida.draw_mouse_ida_0x1ED_0xDBEC_0xFABC();
        return NearRet();
    }

    // Not providing stub for unknown. Reason: Function has no return
    // Not providing stub for mainCode.noOp. Reason: Function already has an override
    // Not providing stub for map.setMapClickHandlerAddressToInGame. Reason: Function already has an override
    // Not providing stub for map.setMapClickHandlerAddressFromAx. Reason: Function already has an override
    // defineFunction(0x1ED, 0xD9D2, "unknown", this::unknown0x1ED_0xD9D2_0xF8A2);
    public  Action Unknown0x1ED_0xD9D2_0xF8A2()
    {

        // unknown_0x1ED_0x176B_0x363B();
        // unknown_0x1ED_0x3916_0x57E6();
        // unknown_0x1ED_0x44AB_0x637B();
        // unknown_0x1ED_0x46B5_0x6585();
        // unknown_0x1ED_0x6B34_0x8A04();
        // unknown_0x1ED_0x99BE_0xB88E();
        // unknown_0x1ED_0xACE6_0xCBB6();
        // unknown_0x1ED_0xB9AE_0xD87E();
        // unknown_0x1ED_0xBE57_0xDD27();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDA25, "unknown", this::unknown0x1ED_0xDA25_0xF8F5);
    public  Action Unknown0x1ED_0xDA25_0xF8F5()
    {
        return NearRet();
    }

    // Not providing stub for initRelated.vgaInitRelated. Reason: Function already has an override
    // defineFunction(0x1ED, 0xDA5F, "unknown", this::unknown0x1ED_0xDA5F_0xF92F);
    public  Action Unknown0x1ED_0xDA5F_0xF92F()
    {
        return NearRet();
    }

    // Not providing stub for map.initMapCursorTypeDC58To0. Reason: Function already has an override
    // Not providing stub for map.setSiToMapCursorTypeDC58. Reason: Function already has an override
    // defineFunction(0x1ED, 0xDAE3, "set_mouse_pos_ida", this::set_mouse_pos_ida0x1ED_0xDAE3_0xF9B3);
    public  Action Set_mouse_pos_ida0x1ED_0xDAE3_0xF9B3()
    {

        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDB03, "unknown", this::unknown0x1ED_0xDB03_0xF9D3);
    public  Action Unknown0x1ED_0xDB03_0xF9D3()
    {

        // ida.set_mouse_pos_ida_0x1ED_0xDAE3_0xF9B3();
        // ida.call_restore_cursor_ida_0x1ED_0xDBB2_0xFA82();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDB14, "define_mouse_range_ida", this::define_mouse_range_ida0x1ED_0xDB14_0xF9E4);
    public  Action Define_mouse_range_ida0x1ED_0xDB14_0xF9E4()
    {

        // mainCode.shlDXAndCXByAH_0x1ED_0xDB44_0xFA14 overriden();
        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // Not providing stub for mainCode.shlDXAndCXByAH. Reason: Function already has an override
    // defineFunction(0x1ED, 0xDB4C, "mouse_stuff_ida", this::mouse_stuff_ida0x1ED_0xDB4C_0xFA1C);
    public  Action Mouse_stuff_ida0x1ED_0xDB4C_0xFA1C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDB67, "unknown", this::unknown0x1ED_0xDB67_0xFA37);
    public  Action Unknown0x1ED_0xDB67_0xFA37()
    {

        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDB74, "unknown", this::unknown0x1ED_0xDB74_0xFA44);
    public  Action Unknown0x1ED_0xDB74_0xFA44()
    {

        // vgaDriver.restoreImageUnderMouseCursor_0x2538_0x10C_0x2548C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDBB2, "call_restore_cursor_ida", this::call_restore_cursor_ida0x1ED_0xDBB2_0xFA82);
    public  Action Call_restore_cursor_ida0x1ED_0xDBB2_0xFA82()
    {

        // vgaDriver.restoreImageUnderMouseCursor_0x2538_0x10C_0x2548C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDBEC, "draw_mouse_ida", this::draw_mouse_ida0x1ED_0xDBEC_0xFABC);
    public  Action Draw_mouse_ida0x1ED_0xDBEC_0xFABC()
    {

        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDC20, "redraw_mouse_ida", this::redraw_mouse_ida0x1ED_0xDC20_0xFAF0);
    public  Action Redraw_mouse_ida0x1ED_0xDC20_0xFAF0()
    {

        // unknown_0x1ED_0xDC6A_0xFB3A();
        // vgaDriver.drawMouseCursor_0x2538_0x109_0x25489();
        // vgaDriver.restoreImageUnderMouseCursor_0x2538_0x10C_0x2548C overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDC6A, "unknown", this::unknown0x1ED_0xDC6A_0xFB3A);
    public  Action Unknown0x1ED_0xDC6A_0xFB3A()
    {

        // unknown_0x1ED_0xD6FE_0xF5CE();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDD63, "stc_on_user_input_ida", this::stc_on_user_input_ida0x1ED_0xDD63_0xFC33);
    public  Action Stc_on_user_input_ida0x1ED_0xDD63_0xFC33()
    {

        // unknown_0x1ED_0xD9D2_0xF8A2();
        // unknown_0x1ED_0xDE54_0xFD24();
        // unknown_0x1ED_0xDE7B_0xFD4B();
        // unknown_0x1ED_0xE3CC_0x1029C();
        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDDB0, "unknown", this::unknown0x1ED_0xDDB0_0xFC80);
    public  Action Unknown0x1ED_0xDDB0_0xFC80()
    {

        // unknown_0x1ED_0xD64E_0xF51E();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        // mainCode.setCEE8To0_0x1ED_0xDE4E_0xFD1E overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDDF0, "unknown", this::unknown0x1ED_0xDDF0_0xFCC0);
    public  Action Unknown0x1ED_0xDDF0_0xFCC0()
    {

        // ida.check_res_file_open_ida_0x1ED_0xABA3_0xCA73();
        // ida.stc_on_user_input_ida_0x1ED_0xDD63_0xFC33();
        // mainCode.setCEE8To0_0x1ED_0xDE4E_0xFD1E overriden();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDE0C, "check_midi_ida", this::check_midi_ida0x1ED_0xDE0C_0xFCDC);
    public  Action Check_midi_ida0x1ED_0xDE0C_0xFCDC()
    {
        return NearRet();
    }

    // Not providing stub for mainCode.setCEE8To0. Reason: Function already has an override
    // defineFunction(0x1ED, 0xDE54, "unknown", this::unknown0x1ED_0xDE54_0xFD24);
    public  Action Unknown0x1ED_0xDE54_0xFD24()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDE7B, "unknown", this::unknown0x1ED_0xDE7B_0xFD4B);
    public  Action Unknown0x1ED_0xDE7B_0xFD4B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xDF1E, "get_mouse_pos_etc_ida", this::get_mouse_pos_etc_ida0x1ED_0xDF1E_0xFDEE);
    public  Action Get_mouse_pos_etc_ida0x1ED_0xDF1E_0xFDEE()
    {

        // unknown_0x1ED_0xDE7B_0xFD4B();
        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // Not providing stub for mainCode.noOp. Reason: Function already has an override
    // Not providing stub for display.pushAll. Reason: Function already has an override
    // Not providing stub for display.popAll. Reason: Function already has an override
    // defineFunction(0x1ED, 0xE290, "unknown", this::unknown0x1ED_0xE290_0x10160);
    public  Action Unknown0x1ED_0xE290_0x10160()
    {

        // unknown_0x1ED_0xD04E_0xEF1E();
        // unknown_0x1ED_0xD12F_0xEFFF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE2DB, "unknown", this::unknown0x1ED_0xE2DB_0x101AB);
    public  Action Unknown0x1ED_0xE2DB_0x101AB()
    {

        // unknown_0x1ED_0xCF70_0xEE40();
        // unknown_0x1ED_0xD03C_0xEF0C();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE2E3, "unknown", this::unknown0x1ED_0xE2E3_0x101B3);
    public  Action Unknown0x1ED_0xE2E3_0x101B3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE31C, "unknown", this::unknown0x1ED_0xE31C_0x101EC);
    public  Action Unknown0x1ED_0xE31C_0x101EC()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE353, "unknown", this::unknown0x1ED_0xE353_0x10223);
    public  Action Unknown0x1ED_0xE353_0x10223()
    {

        // unknown_0x1ED_0x4821_0x66F1();
        // unknown_0x1ED_0x99F6_0xB8C6();
        // unknown_0x1ED_0xDE7B_0xFD4B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE387, "unknown", this::unknown0x1ED_0xE387_0x10257);
    public  Action Unknown0x1ED_0xE387_0x10257()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE3A0, "unknown", this::unknown0x1ED_0xE3A0_0x10270);
    public  Action Unknown0x1ED_0xE3A0_0x10270()
    {

        // unknown_0x1ED_0xD9D2_0xF8A2();
        // display.pushAll_0x1ED_0xE270_0x10140 overriden();
        // display.popAll_0x1ED_0xE283_0x10153 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE3B7, "unknown", this::unknown0x1ED_0xE3B7_0x10287);
    public  Action Unknown0x1ED_0xE3B7_0x10287()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE3CC, "unknown", this::unknown0x1ED_0xE3CC_0x1029C);
    public  Action Unknown0x1ED_0xE3CC_0x1029C()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE3DF, "unknown", this::unknown0x1ED_0xE3DF_0x102AF);
    public  Action Unknown0x1ED_0xE3DF_0x102AF()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE4AD, "parse_command_line_ida", this::parse_command_line_ida0x1ED_0xE4AD_0x1037D);
    public  Action Parse_command_line_ida0x1ED_0xE4AD_0x1037D()
    {

        // ida.parse_cmd_is_end_of_arg_ida_0x1ED_0xE56B_0x1043B();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE56B, "parse_cmd_is_end_of_arg_ida",
    // this::parse_cmd_is_end_of_arg_ida0x1ED_0xE56B_0x1043B);
    public  Action Parse_cmd_is_end_of_arg_ida0x1ED_0xE56B_0x1043B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE57B, "load_driver_ax_with_vtable_at_si_ida",
    // this::load_driver_ax_with_vtable_at_si_ida0x1ED_0xE57B_0x1044B);
    public  Action Load_driver_ax_with_vtable_at_si_ida0x1ED_0xE57B_0x1044B()
    {

        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE594, "initialize_ida", this::initialize_ida0x1ED_0xE594_0x10464);
    public  Action Initialize_ida0x1ED_0xE594_0x10464()
    {

        // display.setVideoBufferSegmentDBD6/set_frontbuffer_as_active_framebuffer_ida_0x1ED_0xC07C_0xDF4C overriden();
        // display.setTextVideoBufferSegmentDBD8/set_screen_as_active_framebuffer_ida_0x1ED_0xC08E_0xDF5E overriden();
        // display.clearCurrentVideoBuffer/gfx_clear_frame_buffer_ida_0x1ED_0xC0AD_0xDF7D overriden();
        // ida.initialize_memory_handler_ida_0x1ED_0xCE6C_0xED3C();
        // unknown_0x1ED_0xDB03_0xF9D3();
        // ida.define_mouse_range_ida_0x1ED_0xDB14_0xF9E4();
        // ida.load_driver_ax_with_vtable_at_si_ida_0x1ED_0xE57B_0x1044B();
        // ida.open_dune_dat_ida_0x1ED_0xE675_0x10545();
        // ida.initialize_audio_ida_0x1ED_0xE76A_0x1063A();
        // unknown_0x1ED_0xE85C_0x1072C();
        // ida.initialize_mouse_ida_0x1ED_0xE97A_0x1084A();
        // ida.memory_func_qq_ida_0x1ED_0xEA7B_0x1094B();
        // ida.bump_alloc_get_addr_in_di_ida_0x1ED_0xF0F6_0x10FC6();
        // ida.bump_allocate_bump_cx_bytes_ida_0x1ED_0xF0FF_0x10FCF();
        // vgaDriver.setMode_0x2538_0x100_0x25480();
        // vgaDriver.getInfoInAxCxBp_0x2538_0x103_0x25483 overriden();
        // vgaDriver.memcpyDSToESFor64000_0x2538_0x121_0x254A1 overriden();
        // unknown_0x2538_0x154_0x254D4();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE675, "open_dune_dat_ida", this::open_dune_dat_ida0x1ED_0xE675_0x10545);
    public  Action Open_dune_dat_ida0x1ED_0xE675_0x10545()
    {

        // ida.read_dune_dat_toc_ida_0x1ED_0xE741_0x10611();
        // mainCode.unknownStructCreation_0x1ED_0xE75B_0x1062B overriden();
        // ida.open_res_or_file_to_dx_size_ax_ida_0x1ED_0xF1FB_0x110CB();
        // ida.locate_res_by_name_dssi_ida_0x1ED_0xF314_0x111E4();
        // unknown_0x1ED_0xF3A7_0x11277();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE741, "read_dune_dat_toc_ida", this::read_dune_dat_toc_ida0x1ED_0xE741_0x10611);
    public  Action Read_dune_dat_toc_ida0x1ED_0xE741_0x10611()
    {

        // ida.seek_dune_dat_offset_dxax_ida_0x1ED_0xF2D6_0x111A6();
        // ida.read_dune_dat_cx_to_esdi_ida_0x1ED_0xF2EA_0x111BA();
        return NearRet();
    }

    // Not providing stub for mainCode.unknownStructCreation. Reason: Function already has an override
    // defineFunction(0x1ED, 0xE76A, "initialize_audio_ida", this::initialize_audio_ida0x1ED_0xE76A_0x1063A);
    public  Action Initialize_audio_ida0x1ED_0xE76A_0x1063A()
    {

        // unknown_0x1ED_0xA637_0xC507();
        // unknown_0x1ED_0xA650_0xC520();
        // ida.audio_test_frequency_ida_0x1ED_0xA87E_0xC74E();
        // mainCode.isUnknownDBC80x100_0x1ED_0xAE28_0xCCF8 overriden();
        // unknown_0x1ED_0xAE3F_0xCD0F();
        // unknown_0x1ED_0xAE54_0xCD24();
        // ida.load_driver_ax_with_vtable_at_si_ida_0x1ED_0xE57B_0x1044B();
        // unknown_0x1ED_0xE826_0x106F6();
        // mainCode.checkUnknown39B9_0x1ED_0xE851_0x10721 overriden();
        // soundDriverPcSpeaker.pcSpeakerActivationWithBXAndALCleanup_0x4822_0x100_0x48320 overriden();
        // soundDriverPcSpeaker.pcSpeakerActivationWithBXAndALCleanup_0x482B_0x100_0x483B0 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE826, "unknown", this::unknown0x1ED_0xE826_0x106F6);
    public  Action Unknown0x1ED_0xE826_0x106F6()
    {

        // ida.read_dune_dat_toc_ida_0x1ED_0xE741_0x10611();
        // mainCode.unknownStructCreation_0x1ED_0xE75B_0x1062B overriden();
        // ida.locate_res_by_name_dssi_ida_0x1ED_0xF314_0x111E4();
        // unknown_0x1ED_0xF3A7_0x11277();
        return NearRet();
    }

    // Not providing stub for mainCode.checkUnknown39B9. Reason: Function already has an override
    // defineFunction(0x1ED, 0xE85C, "unknown", this::unknown0x1ED_0xE85C_0x1072C);
    public  Action Unknown0x1ED_0xE85C_0x1072C()
    {

        // ida.install_interrupt_handlers_ida_0x1ED_0xE913_0x107E3();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE8A8, "set_pit_timer_to_18_2Hz_ida",
    // this::set_pit_timer_to_18_2Hz_ida0x1ED_0xE8A8_0x10778);
    public  Action Set_pit_timer_to_18_2Hz_ida0x1ED_0xE8A8_0x10778()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE8B8, "get_pit_timer_value_ida", this::get_pit_timer_value_ida0x1ED_0xE8B8_0x10788);
    public  Action Get_pit_timer_value_ida0x1ED_0xE8B8_0x10788()
    {

        // unknown_0x1ED_0xEFBA_0x10E8A();
        return InterruptRet();
    }

    // defineFunction(0x1ED, 0xE8D5, "uninitialize_memory_driver_ida",
    // this::uninitialize_memory_driver_ida0x1ED_0xE8D5_0x107A5);
    public  Action Uninitialize_memory_driver_ida0x1ED_0xE8D5_0x107A5()
    {

        // ida.set_pit_timer_to_18_2Hz_ida_0x1ED_0xE8A8_0x10778();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE913, "install_interrupt_handlers_ida",
    // this::install_interrupt_handlers_ida0x1ED_0xE913_0x107E3);
    public  Action Install_interrupt_handlers_ida0x1ED_0xE913_0x107E3()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xE97A, "initialize_mouse_ida", this::initialize_mouse_ida0x1ED_0xE97A_0x1084A);
    public  Action Initialize_mouse_ida0x1ED_0xE97A_0x1084A()
    {

        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        // providedInterrupts.provided_interrupt_handler_0x33_0xF000_0x2D_0xF002D overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xEA7B, "memory_func_qq_ida", this::memory_func_qq_ida0x1ED_0xEA7B_0x1094B);
    public  Action Memory_func_qq_ida0x1ED_0xEA7B_0x1094B()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xEF6A, "interrupt_handler_0x8", this::interrupt_handler_0x80x1ED_0xEF6A_0x10E3A);
    public  Action Interrupt_handler_0x80x1ED_0xEF6A_0x10E3A()
    {

        // unknown_0x1ED_0xCEC9_0xED99();
        // unknown_0x1ED_0xEFBA_0x10E8A();
        return InterruptRet();
    }

    // defineFunction(0x1ED, 0xEFBA, "unknown", this::unknown0x1ED_0xEFBA_0x10E8A);
    public  Action Unknown0x1ED_0xEFBA_0x10E8A()
    {

        // unknown_0x482B_0x10F_0x483BF();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xEFE7, "interrupt_handler_0x9", this::interrupt_handler_0x90x1ED_0xEFE7_0x10EB7);
    public  Action Interrupt_handler_0x90x1ED_0xEFE7_0x10EB7()
    {
        return InterruptRet();
    }

    // defineFunction(0x1ED, 0xF0A0, "open_resource_force_hsq_ida",
    // this::open_resource_force_hsq_ida0x1ED_0xF0A0_0x10F70);
    public  Action Open_resource_force_hsq_ida0x1ED_0xF0A0_0x10F70()
    {

        // ida.open_resource_by_index_si_ida_0x1ED_0xF0B9_0x10F89();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF0B9, "open_resource_by_index_si_ida",
    // this::open_resource_by_index_si_ida0x1ED_0xF0B9_0x10F89);
    public  Action Open_resource_by_index_si_ida0x1ED_0xF0B9_0x10F89()
    {

        // ida.read_and_maybe_hsq_ida_0x1ED_0xF0D6_0x10FA6();
        // ida.alloc_cx_pages_to_di_ida_0x1ED_0xF11C_0x10FEC();
        // ida.read_resource_to_esdi_ida_0x1ED_0xF244_0x11114();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF0D6, "read_and_maybe_hsq_ida", this::read_and_maybe_hsq_ida0x1ED_0xF0D6_0x10FA6);
    public  Action Read_and_maybe_hsq_ida0x1ED_0xF0D6_0x10FA6()
    {

        // ida.read_resource_to_esdi_ida_0x1ED_0xF244_0x11114();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF0F6, "bump_alloc_get_addr_in_di_ida",
    // this::bump_alloc_get_addr_in_di_ida0x1ED_0xF0F6_0x10FC6);
    public  Action Bump_alloc_get_addr_in_di_ida0x1ED_0xF0F6_0x10FC6()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF0FF, "bump_allocate_bump_cx_bytes_ida",
    // this::bump_allocate_bump_cx_bytes_ida0x1ED_0xF0FF_0x10FCF);
    public  Action Bump_allocate_bump_cx_bytes_ida0x1ED_0xF0FF_0x10FCF()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF11C, "alloc_cx_pages_to_di_ida", this::alloc_cx_pages_to_di_ida0x1ED_0xF11C_0x10FEC);
    public  Action Alloc_cx_pages_to_di_ida0x1ED_0xF11C_0x10FEC()
    {

        // ida.allocator_attempt_to_free_space_ida_0x1ED_0xF13F_0x1100F();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF13F, "allocator_attempt_to_free_space_ida",
    // this::allocator_attempt_to_free_space_ida0x1ED_0xF13F_0x1100F);
    public  Action Allocator_attempt_to_free_space_ida0x1ED_0xF13F_0x1100F()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF1FB, "open_res_or_file_to_dx_size_ax_ida",
    // this::open_res_or_file_to_dx_size_ax_ida0x1ED_0xF1FB_0x110CB);
    public  Action Open_res_or_file_to_dx_size_ax_ida0x1ED_0xF1FB_0x110CB()
    {

        // ida.seek_dune_dat_to_res_dsdx_ida_0x1ED_0xF2A7_0x11177();
        // ida.strcpy_to_filename_buf_ida_0x1ED_0xF2FC_0x111CC();
        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF229, "open_res_or_file_or_die_ida",
    // this::open_res_or_file_or_die_ida0x1ED_0xF229_0x110F9);
    public  Action Open_res_or_file_or_die_ida0x1ED_0xF229_0x110F9()
    {

        // ida.open_res_or_file_to_dx_size_ax_ida_0x1ED_0xF1FB_0x110CB();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF244, "read_resource_to_esdi_ida", this::read_resource_to_esdi_ida0x1ED_0xF244_0x11114);
    public  Action Read_resource_to_esdi_ida0x1ED_0xF244_0x11114()
    {

        // ida.open_res_or_file_or_die_ida_0x1ED_0xF229_0x110F9();
        // ida.read_dune_dat_cx_to_esdi_ida_0x1ED_0xF2EA_0x111BA();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF2A7, "seek_dune_dat_to_res_dsdx_ida",
    // this::seek_dune_dat_to_res_dsdx_ida0x1ED_0xF2A7_0x11177);
    public  Action Seek_dune_dat_to_res_dsdx_ida0x1ED_0xF2A7_0x11177()
    {

        // ida.seek_dune_dat_offset_dxax_ida_0x1ED_0xF2D6_0x111A6();
        // ida.locate_res_by_name_dssi_ida_0x1ED_0xF314_0x111E4();
        // unknown_0x1ED_0xF3A7_0x11277();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF2D6, "seek_dune_dat_offset_dxax_ida",
    // this::seek_dune_dat_offset_dxax_ida0x1ED_0xF2D6_0x111A6);
    public  Action Seek_dune_dat_offset_dxax_ida0x1ED_0xF2D6_0x111A6()
    {

        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF2EA, "read_dune_dat_cx_to_esdi_ida",
    // this::read_dune_dat_cx_to_esdi_ida0x1ED_0xF2EA_0x111BA);
    public  Action Read_dune_dat_cx_to_esdi_ida0x1ED_0xF2EA_0x111BA()
    {

        // providedInterrupts.provided_interrupt_handler_0x21_0xF000_0x28_0xF0028 overriden();
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF2FC, "strcpy_to_filename_buf_ida", this::strcpy_to_filename_buf_ida0x1ED_0xF2FC_0x111CC);
    public  Action Strcpy_to_filename_buf_ida0x1ED_0xF2FC_0x111CC()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF314, "locate_res_by_name_dssi_ida",
    // this::locate_res_by_name_dssi_ida0x1ED_0xF314_0x111E4);
    public  Action Locate_res_by_name_dssi_ida0x1ED_0xF314_0x111E4()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF3A7, "unknown", this::unknown0x1ED_0xF3A7_0x11277);
    public  Action Unknown0x1ED_0xF3A7_0x11277()
    {
        return NearRet();
    }

    // defineFunction(0x1ED, 0xF403, "hsq_decomp_skip_header_dssi_to_esdi_ida",
    // this::hsq_decomp_skip_header_dssi_to_esdi_ida0x1ED_0xF403_0x112D3);
    public  Action Hsq_decomp_skip_header_dssi_to_esdi_ida0x1ED_0xF403_0x112D3()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x100, "setMode", this::setMode0x2538_0x100_0x25480);
    public  Action SetMode0x2538_0x100_0x25480()
    {

        // providedInterrupts.provided_interrupt_handler_0x10_0xF000_0xA_0xF000A overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.getInfoInAxCxBp. Reason: Function already has an override
    // defineFunction(0x2538, 0x106, "unknown", this::unknown0x2538_0x106_0x25486);
    public  Action Unknown0x2538_0x106_0x25486()
    {

        // vgaDriver.setBxCxPaletteRelated_0x2538_0xA21_0x25DA1 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x109, "drawMouseCursor", this::drawMouseCursor0x2538_0x109_0x25489);
    public  Action DrawMouseCursor0x2538_0x109_0x25489()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.restoreImageUnderMouseCursor. Reason: Function already has an override
    // defineFunction(0x2538, 0x10F, "blit", this::blit0x2538_0x10F_0x2548F);
    public  Action Blit0x2538_0x10F_0x2548F()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x112, "unknown", this::unknown0x2538_0x112_0x25492);
    public  Action Unknown0x2538_0x112_0x25492()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x115, "unknown", this::unknown0x2538_0x115_0x25495);
    public  Action Unknown0x2538_0x115_0x25495()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.fillWithZeroFor64000AtES. Reason: Function already has an override
    // defineFunction(0x2538, 0x11B, "unknown", this::unknown0x2538_0x11B_0x2549B);
    public  Action Unknown0x2538_0x11B_0x2549B()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x11E, "unknown", this::unknown0x2538_0x11E_0x2549E);
    public  Action Unknown0x2538_0x11E_0x2549E()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.memcpyDSToESFor64000. Reason: Function already has an override
    // defineFunction(0x2538, 0x124, "copyRectangle", this::copyRectangle0x2538_0x124_0x254A4);
    public  Action CopyRectangle0x2538_0x124_0x254A4()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.copySquareOfPixelsSiIsSourceSegment. Reason: Function already has an override
    // Not providing stub for vgaDriver.memcpyDSToESFor64000. Reason: Function already has an override
    // Not providing stub for vgaDriver.moveSquareOfPixels. Reason: Function already has an override
    // defineFunction(0x2538, 0x133, "copy_fbuf_explode_and_center_ida",
    // this::copy_fbuf_explode_and_center_ida0x2538_0x133_0x254B3);
    public  Action Copy_fbuf_explode_and_center_ida0x2538_0x133_0x254B3()
    {

        // interrupt_handler_0x8_0x1ED_0xEF6A_0x10E3A();
        // interrupt_handler_0x9_0x1ED_0xEFE7_0x10EB7();
        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x136, "unknown", this::unknown0x2538_0x136_0x254B6);
    public  Action Unknown0x2538_0x136_0x254B6()
    {
        return FarRet();
    }

    // defineFunction(0x2538, 0x139, "unknown", this::unknown0x2538_0x139_0x254B9);
    public  Action Unknown0x2538_0x139_0x254B9()
    {

        // unknown_0x2538_0x1ADC_0x26E5C();
        return FarRet();
    }

    // Not providing stub for vgaDriver.noOp. Reason: Function already has an override
    // defineFunction(0x2538, 0x142, "unknown", this::unknown0x2538_0x142_0x254C2);
    public  Action Unknown0x2538_0x142_0x254C2()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        // unknown_0x2538_0x2413_0x27793();
        return FarRet();
    }

    // defineFunction(0x2538, 0x145, "unknown", this::unknown0x2538_0x145_0x254C5);
    public  Action Unknown0x2538_0x145_0x254C5()
    {

        // vgaDriver.unknownGlobeRelated_0x2538_0x1D07_0x27087();
        // vgaDriver.unknownGlobeInitRelated_0x2538_0x1D5A_0x270DA overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x148, "unknown", this::unknown0x2538_0x148_0x254C8);
    public  Action Unknown0x2538_0x148_0x254C8()
    {
        return FarRet();
    }

    // defineFunction(0x2538, 0x14B, "unknown", this::unknown0x2538_0x14B_0x254CB);
    public  Action Unknown0x2538_0x14B_0x254CB()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x14E, "unknown", this::unknown0x2538_0x14E_0x254CE);
    public  Action Unknown0x2538_0x14E_0x254CE()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x151, "unknown", this::unknown0x2538_0x151_0x254D1);
    public  Action Unknown0x2538_0x151_0x254D1()
    {

        // vgaDriver.setBxCxPaletteRelated_0x2538_0xA21_0x25DA1 overriden();
        // vgaDriver.copyCsRamB5FToB2F_0x2538_0xA58_0x25DD8 overriden();
        // unknown_0x2538_0xB0C_0x25E8C();
        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        // vgaDriver.memcpyDSToESFor64000_0x2538_0x1B7C_0x26EFC overriden();
        // vgaDriver.retraceRelatedCalledOnEnterGlobe_0x2538_0x253D_0x278BD overriden();
        // vgaDriver.waitForRetraceInTransitions_0x2538_0x2572_0x278F2 overriden();
        // unknown_0x2538_0x2596_0x27916();
        // vgaDriver.waitForRetraceDuringIntroVideo_0x2538_0x261D_0x2799D overriden();
        // unknown_0x2538_0x26E3_0x27A63();
        // unknown_0x2538_0x2AB0_0x27E30();
        // unknown_0x2538_0x316D_0x284ED();
        return FarRet();
    }

    // defineFunction(0x2538, 0x154, "unknown", this::unknown0x2538_0x154_0x254D4);
    public  Action Unknown0x2538_0x154_0x254D4()
    {

        // vgaDriver.waitForRetrace_0x2538_0x9B8_0x25D38 overriden();
        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x157, "unknown", this::unknown0x2538_0x157_0x254D7);
    public  Action Unknown0x2538_0x157_0x254D7()
    {

        // vgaDriver.unknownMapRelated_0x2538_0x2025_0x273A5();
        // unknown_0x2538_0x2123_0x274A3();
        // unknown_0x2538_0x2153_0x274D3();
        return FarRet();
    }

    // defineFunction(0x2538, 0x15A, "unknown", this::unknown0x2538_0x15A_0x254DA);
    public  Action Unknown0x2538_0x15A_0x254DA()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        // vgaDriver.moveSquareOfPixels_0x2538_0x1B8E_0x26F0E overriden();
        // vgaDriver.waitForRetraceInTransitions_0x2538_0x2572_0x278F2 overriden();
        // vgaDriver.generateMenuTransitionFrame_0x2538_0x32C1_0x28641();
        // unknown_0x2538_0x35C8_0x28948();
        // unknown_0x2538_0x36B0_0x28A30();
        // unknown_0x2538_0x372D_0x28AAD();
        // unknown_0x2538_0x3733_0x28AB3();
        // unknown_0x2538_0x37B1_0x28B31();
        return FarRet();
    }

    // defineFunction(0x2538, 0x160, "unknown", this::unknown0x2538_0x160_0x254E0);
    public  Action Unknown0x2538_0x160_0x254E0()
    {

        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.updateVgaOffset01A3FromLineNumberAsAx. Reason: Function already has an override
    // defineFunction(0x2538, 0x169, "unknown", this::unknown0x2538_0x169_0x254E9);
    public  Action Unknown0x2538_0x169_0x254E9()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.generateTextureOutBP. Reason: Function already has an override
    // defineFunction(0x2538, 0x16F, "unknown", this::unknown0x2538_0x16F_0x254EF);
    public  Action Unknown0x2538_0x16F_0x254EF()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x172, "unknown", this::unknown0x2538_0x172_0x254F2);
    public  Action Unknown0x2538_0x172_0x254F2()
    {
        return FarRet();
    }

    // defineFunction(0x2538, 0x175, "unknown", this::unknown0x2538_0x175_0x254F5);
    public  Action Unknown0x2538_0x175_0x254F5()
    {

        // vgaDriver.setBxCxPaletteRelated_0x2538_0xA21_0x25DA1 overriden();
        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x17B, "copy_pal2_to_pal1", this::copy_pal2_to_pal10x2538_0x17B_0x254FB);
    public  Action Copy_pal2_to_pal10x2538_0x17B_0x254FB()
    {

        // vgaDriver.copyCsRamB5FToB2F_0x2538_0xA58_0x25DD8 overriden();
        return FarRet();
    }

    // defineFunction(0x2538, 0x17E, "unknown", this::unknown0x2538_0x17E_0x254FE);
    public  Action Unknown0x2538_0x17E_0x254FE()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        // unknown_0x2538_0x24AD_0x2782D();
        return FarRet();
    }

    // defineFunction(0x2538, 0x184, "unknown", this::unknown0x2538_0x184_0x25504);
    public  Action Unknown0x2538_0x184_0x25504()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.waitForRetrace. Reason: Function already has an override
    // Not providing stub for vgaDriver.setBxCxPaletteRelated. Reason: Function already has an override
    // Not providing stub for vgaDriver.copyCsRamB5FToB2F. Reason: Function already has an override
    // defineFunction(0x2538, 0xB0C, "unknown", this::unknown0x2538_0xB0C_0x25E8C);
    public  Action Unknown0x2538_0xB0C_0x25E8C()
    {

        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        return FarRet();
    }

    // Not providing stub for vgaDriver.loadPalette. Reason: Function already has an override
    // Not providing stub for vgaDriver.setDiFromXYCordsDxBx. Reason: Function already has an override
    // defineFunction(0x2538, 0x1ADC, "unknown", this::unknown0x2538_0x1ADC_0x26E5C);
    public  Action Unknown0x2538_0x1ADC_0x26E5C()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return NearRet();
    }

    // Not providing stub for vgaDriver.memcpyDSToESFor64000. Reason: Function already has an override
    // Not providing stub for vgaDriver.moveSquareOfPixels. Reason: Function already has an override
    // defineFunction(0x2538, 0x1D07, "unknownGlobeRelated", this::unknownGlobeRelated0x2538_0x1D07_0x27087);
    public  Action UnknownGlobeRelated0x2538_0x1D07_0x27087()
    {
        return FarRet();
    }

    // Not providing stub for vgaDriver.unknownGlobeInitRelated. Reason: Function already has an override
    // defineFunction(0x2538, 0x2025, "unknownMapRelated", this::unknownMapRelated0x2538_0x2025_0x273A5);
    public  Action UnknownMapRelated0x2538_0x2025_0x273A5()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x2123, "unknown", this::unknown0x2538_0x2123_0x274A3);
    public  Action Unknown0x2538_0x2123_0x274A3()
    {

        // vgaDriver.copyMapBlock_0x2538_0x2343_0x276C3 overriden();
        return NearRet();
    }

    // defineFunction(0x2538, 0x2153, "unknown", this::unknown0x2538_0x2153_0x274D3);
    public  Action Unknown0x2538_0x2153_0x274D3()
    {

        // vgaDriver.copyMapBlock_0x2538_0x2343_0x276C3 overriden();
        return NearRet();
    }

    // Not providing stub for vgaDriver.copyMapBlock. Reason: Function already has an override
    // defineFunction(0x2538, 0x2396, "unknown", this::unknown0x2538_0x2396_0x27716);
    public  Action Unknown0x2538_0x2396_0x27716()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x23D7, "unknown", this::unknown0x2538_0x23D7_0x27757);
    public  Action Unknown0x2538_0x23D7_0x27757()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x2413, "unknown", this::unknown0x2538_0x2413_0x27793);
    public  Action Unknown0x2538_0x2413_0x27793()
    {

        // unknown_0x2538_0x2396_0x27716();
        // unknown_0x2538_0x23D7_0x27757();
        return NearRet();
    }

    // defineFunction(0x2538, 0x24AD, "unknown", this::unknown0x2538_0x24AD_0x2782D);
    public  Action Unknown0x2538_0x24AD_0x2782D()
    {

        // unknown_0x2538_0x2396_0x27716();
        // unknown_0x2538_0x23D7_0x27757();
        return NearRet();
    }

    // Not providing stub for vgaDriver.retraceRelatedCalledOnEnterGlobe. Reason: Function already has an override
    // Not providing stub for vgaDriver.waitForRetraceInTransitions. Reason: Function already has an override
    // defineFunction(0x2538, 0x2596, "unknown", this::unknown0x2538_0x2596_0x27916);
    public  Action Unknown0x2538_0x2596_0x27916()
    {

        // vgaDriver.memcpyDSToESFor64000_0x2538_0x1B7C_0x26EFC overriden();
        return NearRet();
    }

    // Not providing stub for vgaDriver.waitForRetraceDuringIntroVideo. Reason: Function already has an override
    // defineFunction(0x2538, 0x26E3, "unknown", this::unknown0x2538_0x26E3_0x27A63);
    public  Action Unknown0x2538_0x26E3_0x27A63()
    {

        // vgaDriver.loadPalette_0x2538_0xB68_0x25EE8 overriden();
        // vgaDriver.waitForRetraceDuringIntroVideo_0x2538_0x261D_0x2799D overriden();
        return NearRet();
    }

    // defineFunction(0x2538, 0x2AB0, "unknown", this::unknown0x2538_0x2AB0_0x27E30);
    public  Action Unknown0x2538_0x2AB0_0x27E30()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x316D, "unknown", this::unknown0x2538_0x316D_0x284ED);
    public  Action Unknown0x2538_0x316D_0x284ED()
    {

        // unknown_0x2538_0xB0C_0x25E8C();
        return NearRet();
    }

    // defineFunction(0x2538, 0x32C1, "generateMenuTransitionFrame",
    // this::generateMenuTransitionFrame0x2538_0x32C1_0x28641);
    public  Action GenerateMenuTransitionFrame0x2538_0x32C1_0x28641()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x35C8, "unknown", this::unknown0x2538_0x35C8_0x28948);
    public  Action Unknown0x2538_0x35C8_0x28948()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x36B0, "unknown", this::unknown0x2538_0x36B0_0x28A30);
    public  Action Unknown0x2538_0x36B0_0x28A30()
    {
        return NearRet();
    }

    // defineFunction(0x2538, 0x372D, "unknown", this::unknown0x2538_0x372D_0x28AAD);
    public  Action Unknown0x2538_0x372D_0x28AAD()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return NearRet();
    }

    // defineFunction(0x2538, 0x3733, "unknown", this::unknown0x2538_0x3733_0x28AB3);
    public  Action Unknown0x2538_0x3733_0x28AB3()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return NearRet();
    }

    // defineFunction(0x2538, 0x37B1, "unknown", this::unknown0x2538_0x37B1_0x28B31);
    public  Action Unknown0x2538_0x37B1_0x28B31()
    {

        // vgaDriver.setDiFromXYCordsDxBx_0x2538_0xC10_0x25F90 overriden();
        return NearRet();
    }

    // Not providing stub for soundDriverPcSpeaker.pcSpeakerActivationWithBXAndALCleanup. Reason: Function already has an
    // override
    // Not providing stub for soundDriverPcSpeaker.clearAL. Reason: Function already has an override
    // Not providing stub for soundDriverPcSpeaker.clearAL. Reason: Function already has an override
    // Not providing stub for soundDriverPcSpeaker.clearAL. Reason: Function already has an override
    // Not providing stub for soundDriverPcSpeaker.pcSpeakerActivationWithBXAndALCleanup. Reason: Function already has an
    // override
    // defineFunction(0x482B, 0x103, "unknown", this::unknown0x482B_0x103_0x483B3);
    public  Action Unknown0x482B_0x103_0x483B3()
    {
        return FarRet();
    }

    // Not providing stub for soundDriverPcSpeaker.clearAL. Reason: Function already has an override
    // defineFunction(0x482B, 0x109, "unknown", this::unknown0x482B_0x109_0x483B9);
    public  Action Unknown0x482B_0x109_0x483B9()
    {
        return FarRet();
    }

    // defineFunction(0x482B, 0x10C, "unknown", this::unknown0x482B_0x10C_0x483BC);
    public  Action Unknown0x482B_0x10C_0x483BC()
    {
        return FarRet();
    }

    // defineFunction(0x482B, 0x10F, "unknown", this::unknown0x482B_0x10F_0x483BF);
    public  Action Unknown0x482B_0x10F_0x483BF()
    {
        return FarRet();
    } // Not providing stub for soundDriverPcSpeaker.clearAL. Reason: Function already has an override
    // Not providing stub for providedInterrupts.provided_interrupt_handler_0x10. Reason: Function already has an override
    // Not providing stub for providedInterrupts.provided_interrupt_handler_0x21. Reason: Function already has an override
    // Not providing stub for providedInterrupts.provided_interrupt_handler_0x33. Reason: Function already has an override
}
