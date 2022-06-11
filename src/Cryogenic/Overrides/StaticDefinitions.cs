namespace Cryogenic.Overrides;

public partial class Overrides {

    public void DefineStaticDefinitionsFunctions() {
        DefineFunction(cs1, 0x3A, "exit");
        DefineFunction(cs1, 0xB0, "initialize_2_ida");
        DefineFunction(cs1, 0xD1, "intialize_resources_ida");
        DefineFunction(cs1, 0x0169, "map2_resource_func_ida");
        DefineFunction(cs1, 0x21C, "play_intro2_ida");
        DefineFunction(cs1, 0x0309, "play_CREDITS_HNM_ida");
        DefineFunction(cs1, 0x0580, "play_intro_ida");
        DefineFunction(cs1, 0x61C, "load_VIRGIN_HNM_ida");
        DefineFunction(cs1, 0x0625, "play_VIRGIN_HNM_ida");
        DefineFunction(cs1, 0x64D, "load_CRYO_HNM_ida");
        DefineFunction(cs1, 0x0658, "load_CRYO2_HNM_ida");
        DefineFunction(cs1, 0x0661, "play_CRYO_OR_CRYO2_HNM_ida");
        DefineFunction(cs1, 0x0678, "load_PRESENT_HNM_ida");
        DefineFunction(cs1, 0x0684, "play_PRESENT_HNM_ida");
        DefineFunction(cs1, 0x69E, "load_INTRO_HNM_ida");
        DefineFunction(cs1, 0xF131, "setErrorMessageToNotEnoughMemory");
        DefineFunction(cs1, 0x6AA, "play_hnm_86_frames_ida");
        DefineFunction(cs1, 0x6BD, "play_hnm_skippable_ida");
        DefineFunction(cs1, 0x9EF, "play_CREDITS_HNM_ida");
        DefineFunction(cs1, 0x2D74, "open_SAL_resource_ida");
        DefineFunction(cs1, 0x3B59, "draw_SAL_ida");
        DefineFunction(cs1, 0x3BE9, "SAL_polygon_ida");
        DefineFunction(cs1, 0x3D83, "do_weird_shit_with_stack_buffer_ida");
        DefineFunction(cs1, 0x55DD, "map_func_ida");
        DefineFunction(cs1, 0x5E4F, "calc_SAL_index_ida");
        DefineFunction(cs1, 0x63F0, "map_func_qq_ida");
        DefineFunction(cs1, 0x739E, "map_func_ida");
        DefineFunction(cs1, 0xA87E, "audio_test_frequency_ida");
        DefineFunction(cs1, 0xA90B, "open_res_file_ida");
        DefineFunction(cs1, 0xA93F, "read_audio_file_ida");
        DefineFunction(cs1, 0xA9A1, "close_res_file_handle_ida");
        DefineFunction(cs1, 0xA9E7, "pcm_test_audio_done_ida");
        DefineFunction(cs1, 0xAA0F, "decode_sd_block_ida");
        DefineFunction(cs1, 0xAA70, "transfer_sd_block_qq_ida");
        DefineFunction(cs1, 0xAB15, "audio_start_voc_ida");
        DefineFunction(cs1, 0xABA3, "check_res_file_open_ida");
        DefineFunction(cs1, 0xABE9, "open_voc_resource_ida");
        DefineFunction(cs1, 0xAC14, "pcm_stop_voc_q_ida");
        DefineFunction(cs1, 0xAD57, "play_music_MORNING_HSQ_ida");
        DefineFunction(cs1, 0xAE62, "load_music_ida");
        DefineFunction(cs1, 0xB389, "open_sav_cl_ida");
        DefineFunction(cs1, 0xB427, "map_func_ida");
        DefineFunction(cs1, 0xB58B, "map_func_ida");
        DefineFunction(cs1, 0xB6C3, "map_func_ida");
        DefineFunction(cs1, 0xB977, "map_func_gfx_ida");
        DefineFunction(cs1, 0xBFE3, "map_func_ida");
        DefineFunction(cs1, 0xC097, "gfx_call_bp_with_front_buffer_as_screen_ida");
        DefineFunction(cs1, 0xC108, "transition_ida");
        DefineFunction(cs1, 0xC137, "load_icons_sprites_ida");
        DefineFunction(cs1, 0xC13E, "open_sprite_sheet_ida");
        DefineFunction(cs1, 0xC1BA, "hnm_apply_palette_ida");
        DefineFunction(cs1, 0xC22F, "draw_sprite_ida");
        DefineFunction(cs1, 0xC477, "gfx_copy_rect_at_si_ida");
        DefineFunction(cs1, 0xC49A, "gfx_copy_framebuffer_to_screen_ida");
        DefineFunction(cs1, 0xC4AA, "gfx_copy_rect_to_screen_ida");
        DefineFunction(cs1, 0xC4CD, "gfx_copy_framebuf_to_screen_ida");
        DefineFunction(cs1, 0xC4F0, "rect_at_si_to_regs_ida");
        DefineFunction(cs1, 0xC92B, "hnm_reset_and_read_header_ida");
        DefineFunction(cs1, 0xC93C, "hnm_read_header_ida");
        DefineFunction(cs1, 0xC9E8, "hnm_do_frame_skippable_ida");
        DefineFunction(cs1, 0xC9F4, "do_frame_and_check_if_frame_advanced_ida");
        DefineFunction(cs1, 0xCA01, "hnm_close_resource_ida");
        DefineFunction(cs1, 0xCA1B, "hnm_load_ida");
        DefineFunction(cs1, 0xCA60, "hnm_do_frame_ida");
        DefineFunction(cs1, 0xCC96, "hnm_decode_video_frame_ida");
        DefineFunction(cs1, 0xCD8F, "hnm_read_header_size_ida");
        DefineFunction(cs1, 0xCDA0, "hnm_prepare_header_read_ida");
        DefineFunction(cs1, 0xCE1A, "hnm_reset_ida");
        DefineFunction(cs1, 0xCE3B, "hnm_handle_pal_chunk_ida");
        DefineFunction(cs1, 0xCE6C, "initialize_memory_handler_ida");
        DefineFunction(cs1, 0xCEFC, "load_IRULn_HSQ_ida");
        DefineFunction(cs1, 0xCF1B, "play_IRULx_HSQ_ida");
        DefineFunction(cs1, 0xCF4B, "IRULx_draw_or_clear_subtitle_ida");
        DefineFunction(cs1, 0xCFA0, "check_amr_or_eng_language_ida");
        DefineFunction(cs1, 0xD00F, "load_PHRASExx_HSQ_ida");
        //DefineFunction(segment, 0xDAE3, "set_mouse_pos_ida");
        DefineFunction(cs1, 0xDB14, "define_mouse_range_ida");
        DefineFunction(cs1, 0xDB4C, "mouse_stuff_ida");
        DefineFunction(cs1, 0xDBB2, "call_restore_cursor_ida");
        DefineFunction(cs1, 0xDBEC, "draw_mouse_ida");
        DefineFunction(cs1, 0xDC20, "redraw_mouse_ida");
        DefineFunction(cs1, 0xDCE0, "read_game_port_ida");
        DefineFunction(cs1, 0xDD5A, "get_key_hit_ida");
        DefineFunction(cs1, 0xDD63, "stc_on_user_input_ida");
        DefineFunction(cs1, 0xDE0C, "check_midi_ida");
        DefineFunction(cs1, 0xDF1E, "get_mouse_pos_etc_ida");
        DefineFunction(cs1, 0xE4AD, "parse_command_line_ida");
        DefineFunction(cs1, 0xE56B, "parse_cmd_is_end_of_arg_ida");
        DefineFunction(cs1, 0xE57B, "load_driver_ax_with_vtable_at_si_ida");
        DefineFunction(cs1, 0xE594, "initialize_ida");
        DefineFunction(cs1, 0xE675, "open_dune_dat_ida");
        DefineFunction(cs1, 0xE741, "read_dune_dat_toc_ida");
        DefineFunction(cs1, 0xE76A, "initialize_audio_ida");
        DefineFunction(cs1, 0xE8B8, "get_pit_timer_value_ida");
        DefineFunction(cs1, 0xE8D5, "uninitialize_memory_driver_ida");
        DefineFunction(cs1, 0xE913, "install_interrupt_handlers_ida");
        DefineFunction(cs1, 0xE97A, "initialize_mouse_ida");
        DefineFunction(cs1, 0xE9F4, "mouse_func_uncalled_ida");
        DefineFunction(cs1, 0xEA32, "initialize_joystick_ida");
        DefineFunction(cs1, 0xEA7B, "memory_func_qq_ida");
        DefineFunction(cs1, 0xEAB7, "memory_func_qq_ida");
        DefineFunction(cs1, 0xEC46, "call_memory_func_2_ida");
        DefineFunction(cs1, 0xEC59, "call_memory_func_1_ida");
        DefineFunction(cs1, 0xEC9C, "xms_memory_func_1_ida");
        DefineFunction(cs1, 0xECEC, "xms_memory_func_1_ida");
        DefineFunction(cs1, 0xED40, "get_ems_emm_handle_ida");
        DefineFunction(cs1, 0xED45, "call_ems_func_ida");
        DefineFunction(cs1, 0xEDB9, "map_ems_for_midi_audio_ida");
        DefineFunction(cs1, 0xEE02, "ems_memory_func_2_ida");
        DefineFunction(cs1, 0xEE46, "ems_memory_func_1_ida");
        DefineFunction(cs1, 0xEEA0, "initialize_himem_sys_ida");
        DefineFunction(cs1, 0xEF22, "call_xms_driver_func_ida");
        DefineFunction(cs1, 0xEF2B, "call_xms_func_on_block_ida");
        DefineFunction(cs1, 0xEF32, "xms_move_memory_ida");
        DefineFunction(cs1, 0xF05C, "reset_keyboard_ida");
        DefineFunction(cs1, 0xF08E, "clear_keyboard_array_ida");
        DefineFunction(cs1, 0xF0A0, "open_resource_force_hsq_ida");
        DefineFunction(cs1, 0xF0B9, "open_resource_by_index_si_ida");
        DefineFunction(cs1, 0xF0D6, "read_and_maybe_hsq_ida");
        DefineFunction(cs1, 0xF0F6, "bump_alloc_get_addr_in_di_ida");
        DefineFunction(cs1, 0xF0FF, "bump_allocate_bump_cx_bytes_ida");
        DefineFunction(cs1, 0xF11C, "alloc_cx_pages_to_di_ida");
        DefineFunction(cs1, 0xF13F, "allocator_attempt_to_free_space_ida");
        DefineFunction(cs1, 0xF1FB, "open_res_or_file_to_dx_size_ax_ida");
        DefineFunction(cs1, 0xF229, "open_res_or_file_or_die_ida");
        DefineFunction(cs1, 0xF244, "read_resource_to_esdi_ida");
        DefineFunction(cs1, 0xF255, "open_nonres_file_ida");
        DefineFunction(cs1, 0xF260, "read_ffff_to_esdi_and_close_ida");
        DefineFunction(cs1, 0xF2A7, "seek_dune_dat_to_res_dsdx_ida");
        DefineFunction(cs1, 0xF2D6, "seek_dune_dat_offset_dxax_ida");
        DefineFunction(cs1, 0xF2EA, "read_dune_dat_cx_to_esdi_ida");
        DefineFunction(cs1, 0xF2FC, "strcpy_to_filename_buf_ida");
        DefineFunction(cs1, 0xF314, "locate_res_by_name_dssi_ida");
        DefineFunction(cs1, 0xF403, "hsq_decomp_skip_header_dssi_to_esdi_ida");
        // Jumped to by self modifying code, needs to be there
        DefineFunction(cs2, 0x1EC9, "split_C000_1EC9_C1EC9");
    }

    public void DefineStaticDefinitionsGlobals() {
        DefineStaticAddress(cs2, 0x01A3, "VgaOffset");
        DefineStaticAddress(cs2, 0x018A, "MouseCursorAddressInVram");
        DefineStaticAddress(cs2, 0x018C, "ColumnsOfMouseCursorCount");
        DefineStaticAddress(cs2, 0x018E, "LinesOfMouseCursorCount");
        DefineStaticAddress(cs2, 0x01BD, "PaletteLoadMode");
        DefineStaticAddress(cs2, 0x01A1, "NeedWaitForRetrace");
        DefineStaticAddress(cs2, 0x019F, "VgaStatusRegisterPort");
        DefineStaticAddress(cs2, 0x01A2, "VgaStatusRegisterPortExpectedRetraceValue");
        DefineStaticAddress(cs2, 0x1CA6, "UnknownGlobeRelated");
        DefineStaticAddress(cs2, 0x1CAE, "UnknownGlobeRelated");
        DefineStaticAddress(cs2, 0x1CB0, "UnknownGlobeRelated");
        DefineStaticAddress(cs2, 0x1CB2, "UnknownGlobeRelated");
        DefineStaticAddress(cs2, 0x1EA6, "UnknownGlobeRelated");
        DefineStaticAddress(cs2, 0x1F29, "UnknownGlobeRelated");
        DefineStaticAddress(cs1, 0xC21A, "paletteOffset");
        DefineStaticAddress(cs1, 0xCC94, "blitFunction");
        DefineStaticAddress(cs1, 0xE40C, "cmdArgList");
        DefineStaticAddress(cs1, 0xE8D2, "pitTimerValue");
        DefineStaticAddress(cs1, 0xE8D4, "pitTimerCounter");
        DefineStaticAddress(cs1, 0xED3A, "emsEmmHandle");
        DefineStaticAddress(cs1, 0xEE8A, "xmsMemoryBlock");
        DefineStaticAddress(0x1138, 0x144C, "loadedSalIndex");
        DefineStaticAddress(0x1138, 0x2580, "mousePosScalerX");
        DefineStaticAddress(0x1138, 0x2581, "mousePosScalerY");
        DefineStaticAddress(0x1138, 0x2582, "mouseCursorImageAddress");
        DefineStaticAddress(0x1138, 0x2784, "resourceId");
        DefineStaticAddress(0x1138, 0x2942, "cmdArgs");
        DefineStaticAddress(0x1138, 0x2943, "cmdArgsMemory");
        DefineStaticAddress(0x1138, 0x2944, "cmdArgsAudio");
        DefineStaticAddress(0x1138, 0x3821, "resFileHandle");
        DefineStaticAddress(0x1138, 0x38B5, "gfxVtable00setMode");
        DefineStaticAddress(0x1138, 0x38B9, "gfxVtable01getInfoInAxCxBp");
        DefineStaticAddress(0x1138, 0x38BD, "gfxVtable02");
        DefineStaticAddress(0x1138, 0x38C1, "gfxVtable03drawMouseCursor");
        DefineStaticAddress(0x1138, 0x38C5, "gfxVtable04restoreImageUnderMouseCursor");
        DefineStaticAddress(0x1138, 0x38C9, "gfxVtable05blit");
        DefineStaticAddress(0x1138, 0x38CD, "gfxVtable06");
        DefineStaticAddress(0x1138, 0x38D1, "gfxVtable07");
        DefineStaticAddress(0x1138, 0x38D5, "gfxVtable08fillWithZeroFor64000AtES");
        DefineStaticAddress(0x1138, 0x38D9, "gfxVtable09");
        DefineStaticAddress(0x1138, 0x38DD, "gfxVtable10");
        DefineStaticAddress(0x1138, 0x38E1, "gfxVtable11memcpyDSToESFor64000");
        DefineStaticAddress(0x1138, 0x38E5, "gfxVtable12copyRectangle");
        DefineStaticAddress(0x1138, 0x38E9, "gfxVtable13copyFramebuffer");
        DefineStaticAddress(0x1138, 0x38ED, "gfxVtable14copySquareOfPixelsSiIsSourceSegment");
        DefineStaticAddress(0x1138, 0x38F1, "gfxVtable15memcpyDSToESFor64000");
        DefineStaticAddress(0x1138, 0x38F5, "gfxVtable16copySquareOfPixels");
        DefineStaticAddress(0x1138, 0x38F9, "gfxVtable17copyframebufferExplodeAndCenter");
        DefineStaticAddress(0x1138, 0x38FD, "gfxVtable18");
        DefineStaticAddress(0x1138, 0x3901, "gfxVtable19");
        DefineStaticAddress(0x1138, 0x3905, "gfxVtable20noOp");
        DefineStaticAddress(0x1138, 0x3909, "gfxVtable21setPixel");
        DefineStaticAddress(0x1138, 0x390D, "gfxVtable22");
        DefineStaticAddress(0x1138, 0x3911, "gfxVtable23");
        DefineStaticAddress(0x1138, 0x3915, "gfxVtable24");
        DefineStaticAddress(0x1138, 0x3919, "gfxVtable25");
        DefineStaticAddress(0x1138, 0x391D, "gfxVtable26");
        DefineStaticAddress(0x1138, 0x3921, "gfxVtable27");
        DefineStaticAddress(0x1138, 0x3925, "gfxVtable28");
        DefineStaticAddress(0x1138, 0x3929, "gfxVtable29");
        DefineStaticAddress(0x1138, 0x392D, "gfxVtable30");
        DefineStaticAddress(0x1138, 0x3931, "gfxVtable31");
        DefineStaticAddress(0x1138, 0x3935, "gfxVtable32");
        DefineStaticAddress(0x1138, 0x3939, "gfxVtable33updateVgaOffset01A3FromLineNumberAsAx");
        DefineStaticAddress(0x1138, 0x393D, "gfxVtable34");
        DefineStaticAddress(0x1138, 0x3941, "gfxVtable35");
        DefineStaticAddress(0x1138, 0x3945, "gfxVtable36");
        DefineStaticAddress(0x1138, 0x3949, "gfxVtable37");
        DefineStaticAddress(0x1138, 0x394D, "gfxVtable38");
        DefineStaticAddress(0x1138, 0x3951, "gfxVtable39");
        DefineStaticAddress(0x1138, 0x3955, "gfxVtable40");
        DefineStaticAddress(0x1138, 0x3959, "gfxVtable41copyPalette2toPalette1");
        DefineStaticAddress(0x1138, 0x395D, "gfxVtable42");
        DefineStaticAddress(0x1138, 0x3961, "gfxVtable43");
        DefineStaticAddress(0x1138, 0x3965, "gfxVtable44");
        DefineStaticAddress(0x1138, 0x3969, "gfxVtable45");
        DefineStaticAddress(0x1138, 0x3989, "pcmVtable1");
        DefineStaticAddress(0x1138, 0x398D, "pcmVtable2");
        DefineStaticAddress(0x1138, 0x39A9, "xmsOrEmsMemLimit");
        DefineStaticAddress(0x1138, 0x39B3, "cmdArgMidi");
        DefineStaticAddress(0x1138, 0x39B7, "allocatorNextFreeOffset");
        DefineStaticAddress(0x1138, 0x39B9, "allocatorNextFreeSegment");
        DefineStaticAddress(0x1138, 0x3CBC, "errorMsg");
        DefineStaticAddress(0x1138, 0x47F6, "salStackBuffer24b");
        DefineStaticAddress(0x1138, 0xAA72, "resConditOffset");
        DefineStaticAddress(0x1138, 0xAA74, "resConditSegment");
        DefineStaticAddress(0x1138, 0xCE68, "allocatorLastFreeSegment");
        DefineStaticAddress(0x1138, 0xCE71, "disableHsq");
        DefineStaticAddress(0x1138, 0xCE78, "resourceIndex");
        DefineStaticAddress(0x1138, 0xCE9A, "keyPstatus");
        DefineStaticAddress(0x1138, 0xCE9D, "keyEnterStatus");
        DefineStaticAddress(0x1138, 0xCE9E, "keyWstatus");
        DefineStaticAddress(0x1138, 0xCEE8, "keyHit");
        DefineStaticAddress(0x1138, 0xCEEA, "resetKeyboardCounter");
        DefineStaticAddress(0x1138, 0xCEEB, "languageSetting");
        DefineStaticAddress(0x1138, 0xDBB5, "hnmFlagMsb");
        DefineStaticAddress(0x1138, 0xDBBC, "dnmajFunc2");
        DefineStaticAddress(0x1138, 0xDBCE, "midiFunc5returnBx");
        DefineStaticAddress(0x1138, 0xDBD0, "midiFunc5returnCx");
        DefineStaticAddress(0x1138, 0xDBD6, "framebufferFront");
        DefineStaticAddress(0x1138, 0xDBD8, "screenBuffer");
        DefineStaticAddress(0x1138, 0xDBDA, "framebufferActive");
        DefineStaticAddress(0x1138, 0xDBDE, "framebuffer2Segment");
        DefineStaticAddress(0x1138, 0xDBE7, "hnmFinishedFlag");
        DefineStaticAddress(0x1138, 0xDBE8, "hnmFrameCounter");
        DefineStaticAddress(0x1138, 0xDBEA, "hnmCounter2");
        DefineStaticAddress(0x1138, 0xDBFE, "currentHnmResourceFlag");
        DefineStaticAddress(0x1138, 0xDC00, "hnmVideoId");
        DefineStaticAddress(0x1138, 0xDC02, "hnmActiveVideoId");
        DefineStaticAddress(0x1138, 0xDC04, "hnmFileOffset");
        DefineStaticAddress(0x1138, 0xDC06, "hnmFileOffsetHi");
        DefineStaticAddress(0x1138, 0xDC08, "hnmFileRemain");
        DefineStaticAddress(0x1138, 0xDC0A, "hnmFileRemainHi");
        DefineStaticAddress(0x1138, 0xDC0C, "hnmFileReadBufferSegment");
        DefineStaticAddress(0x1138, 0xDC10, "hnmFileReadBufferOffset");
        DefineStaticAddress(0x1138, 0xDC14, "videoDecodeBufferOffset");
        DefineStaticAddress(0x1138, 0xDC16, "videoDecodeBufferSegment");
        DefineStaticAddress(0x1138, 0xDC1C, "hnmSdBlockOffset");
        DefineStaticAddress(0x1138, 0xDC1E, "hnmPlBlockOffset");
        DefineStaticAddress(0x1138, 0xDC24, "videoChunkTag");
        DefineStaticAddress(0x1138, 0xDC26, "pcmVocLipsyncData");
        DefineStaticAddress(0x1138, 0xDC32, "framebufferBack");
        DefineStaticAddress(0x1138, 0xDC36, "mousePosY");
        DefineStaticAddress(0x1138, 0xDC38, "mousePosX");
        DefineStaticAddress(0x1138, 0xDC42, "mouseDrawPosY");
        DefineStaticAddress(0x1138, 0xDC44, "mouseDrawPosX");
        DefineStaticAddress(0x1138, 0xDC46, "cursorHideCounter");
        DefineStaticAddress(0x1138, 0xDC47, "cursorUnknown");

        // Whitelist only this segment as the game is browsing pointer list by incrementing segments...
        DefineStaticAddress(0x1138, 0xDBB0, "spriteSheetResourcePointer", true);
        DefineStaticAddress(0x1138, 0x4772, "TimeBetweenFaceZooms");
        DefineStaticAddress(0x1138, 0xD82C, "CharacterXCoord");
        DefineStaticAddress(0x1138, 0xD82E, "CharacterYCoord");
        DefineStaticAddress(0x1138, 0x2518, "FontRelated");
        DefineStaticAddress(0x1138, 0x47A0, "FontRelated");
        DefineStaticAddress(0x1138, 0x2570, "MapClickHandlerAddress");
        DefineStaticAddress(0x1138, 0xDC58, "MapCursorType");
        DefineStaticAddress(0x1138, 0x35A6, "IsAnimateMenuUnneeded");
        DefineStaticAddress(0x1138, 0xDCE6, "TransitionBitmask");
        DefineStaticAddress(0x1138, 0x21DA, "OffsetToMenuType");
        DefineStaticAddress(0x1138, 0x4854, "SceneSequenceOffset");
        DefineStaticAddress(0x1138, 0xDBCD, "IsSoundPresent");
        DefineStaticAddress(0x1138, 0x0002, "GameElapsedTime");
        DefineStaticAddress(0x1138, 0xCE7A, "VideoPlayRelatedIndex");
        DefineStaticAddress(0x1138, 0xDC22, "VideoPlayRelatedIndex");
    }
}