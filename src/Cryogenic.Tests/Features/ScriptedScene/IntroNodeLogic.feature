Feature: IntroNodeLogic (seg000:01E0 loc_001e0)
  Computes the animation direction byte for an intro scene node.
  The result encodes both the masked tile type (lower nibble) and the direction
  bit (bit 7), derived from three successive XOR-with-0x80 threshold tests.

  Assembly (seg000:01E0–020B, doc/DNCDPRG.lst):
    AL = tileType & 0x0F
    AH = directionByte & 0x07
    if AL > 3  → AH ^= 0x80
    if AL > 5  → AH ^= 0x80   (cancels first XOR for 4 < AL ≤ 9)
    if AL > 9  → AH ^= 0x80   (re-sets bit 7 for AL > 9)
    result = AL | AH

  Scenario: tile type at or below threshold 3 – no XOR applied
    Given an intro node tile type of 2
    And a current intro node direction byte of 0
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 2

  Scenario: tile type exactly at threshold 3 – no XOR applied
    Given an intro node tile type of 3
    And a current intro node direction byte of 2
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 3

  Scenario: tile type above 3 and at or below 5 – one XOR sets bit 7
    Given an intro node tile type of 4
    And a current intro node direction byte of 3
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 135

  Scenario: tile type above 5 and at or below 9 – two XORs cancel bit 7
    Given an intro node tile type of 7
    And a current intro node direction byte of 5
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 7

  Scenario: tile type exactly at threshold 9 – two XORs cancel bit 7
    Given an intro node tile type of 9
    And a current intro node direction byte of 6
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 15

  Scenario: tile type above 9 – three XORs net-set bit 7
    Given an intro node tile type of 10
    And a current intro node direction byte of 1
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 139

  Scenario: tile type upper nibble is masked away before threshold tests
    Given an intro node tile type of 20
    And a current intro node direction byte of 0
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 132

  Scenario: direction byte upper bits are masked to lower 3 bits
    Given an intro node tile type of 2
    And a current intro node direction byte of 255
    When I compute the intro node direction byte
    Then the computed intro node direction byte should be 7
