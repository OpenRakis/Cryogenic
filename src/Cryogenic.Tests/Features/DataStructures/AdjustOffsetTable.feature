Feature: AdjustOffsetTable (seg000:0098 adjust_sub_resource_pointers)
  Converts every word in a size-prefixed table to an absolute pointer by adding
  a fixed base offset to each entry. The first word encodes the total byte size
  of the adjustable region; count = size / 2 words are adjusted (including the
  size word itself), matching the STOSW loop at seg000:009F.
  Confirmed executed in dump/spice86dumpExecutionFlow.json.

  Scenario: two-entry table is rebased
    Given a word table containing [4, 16, 48]
    And a base offset of 256
    When I call AdjustOffsetTable
    Then the word table should equal [260, 272, 48]

  Scenario: count of zero leaves the table unchanged
    Given a word table containing [0, 100]
    And a base offset of 50
    When I call AdjustOffsetTable
    Then the word table should equal [0, 100]

  Scenario: empty table is unchanged
    Given an empty word table
    And a base offset of 100
    When I call AdjustOffsetTable
    Then the word table should be empty

  Scenario: single-slot table adjusts only the count word
    Given a word table containing [2, 500]
    And a base offset of 10
    When I call AdjustOffsetTable
    Then the word table should equal [12, 500]

  Scenario: base offset of zero is a no-op
    Given a word table containing [4, 8, 99]
    And a base offset of 0
    When I call AdjustOffsetTable
    Then the word table should equal [4, 8, 99]
