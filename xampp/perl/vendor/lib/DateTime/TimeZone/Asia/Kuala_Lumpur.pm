# This file is auto-generated by the Perl DateTime Suite time zone
# code generator (0.08) This code generator comes with the
# DateTime::TimeZone module distribution in the tools/ directory

#
# Generated from /tmp/PG8ljYXUN8/asia.  Olson data version 2019c
#
# Do not edit this file directly.
#
package DateTime::TimeZone::Asia::Kuala_Lumpur;

use strict;
use warnings;
use namespace::autoclean;

our $VERSION = '2.38';

use Class::Singleton 1.03;
use DateTime::TimeZone;
use DateTime::TimeZone::OlsonDB;

@DateTime::TimeZone::Asia::Kuala_Lumpur::ISA = ( 'Class::Singleton', 'DateTime::TimeZone' );

my $spans =
[
    [
DateTime::TimeZone::NEG_INFINITY, #    utc_start
59958205994, #      utc_end 1900-12-31 17:13:14 (Mon)
DateTime::TimeZone::NEG_INFINITY, #  local_start
59958230400, #    local_end 1901-01-01 00:00:00 (Tue)
24406,
0,
'LMT',
    ],
    [
59958205994, #    utc_start 1900-12-31 17:13:14 (Mon)
60097482275, #      utc_end 1905-05-31 17:04:35 (Wed)
59958230919, #  local_start 1901-01-01 00:08:39 (Tue)
60097507200, #    local_end 1905-06-01 00:00:00 (Thu)
24925,
0,
'SMT',
    ],
    [
60097482275, #    utc_start 1905-05-31 17:04:35 (Wed)
60968048400, #      utc_end 1932-12-31 17:00:00 (Sat)
60097507475, #  local_start 1905-06-01 00:04:35 (Thu)
60968073600, #    local_end 1933-01-01 00:00:00 (Sun)
25200,
0,
'+07',
    ],
    [
60968048400, #    utc_start 1932-12-31 17:00:00 (Sat)
61062655200, #      utc_end 1935-12-31 16:40:00 (Tue)
60968074800, #  local_start 1933-01-01 00:20:00 (Sun)
61062681600, #    local_end 1936-01-01 00:00:00 (Wed)
26400,
1,
'+0720',
    ],
    [
61062655200, #    utc_start 1935-12-31 16:40:00 (Tue)
61241503200, #      utc_end 1941-08-31 16:40:00 (Sun)
61062681600, #  local_start 1936-01-01 00:00:00 (Wed)
61241529600, #    local_end 1941-09-01 00:00:00 (Mon)
26400,
0,
'+0720',
    ],
    [
61241503200, #    utc_start 1941-08-31 16:40:00 (Sun)
61256017800, #      utc_end 1942-02-15 16:30:00 (Sun)
61241530200, #  local_start 1941-09-01 00:10:00 (Mon)
61256044800, #    local_end 1942-02-16 00:00:00 (Mon)
27000,
0,
'+0730',
    ],
    [
61256017800, #    utc_start 1942-02-15 16:30:00 (Sun)
61368678000, #      utc_end 1945-09-11 15:00:00 (Tue)
61256050200, #  local_start 1942-02-16 01:30:00 (Mon)
61368710400, #    local_end 1945-09-12 00:00:00 (Wed)
32400,
0,
'+09',
    ],
    [
61368678000, #    utc_start 1945-09-11 15:00:00 (Tue)
62514347400, #      utc_end 1981-12-31 16:30:00 (Thu)
61368705000, #  local_start 1945-09-11 22:30:00 (Tue)
62514374400, #    local_end 1982-01-01 00:00:00 (Fri)
27000,
0,
'+0730',
    ],
    [
62514347400, #    utc_start 1981-12-31 16:30:00 (Thu)
DateTime::TimeZone::INFINITY, #      utc_end
62514376200, #  local_start 1982-01-01 00:30:00 (Fri)
DateTime::TimeZone::INFINITY, #    local_end
28800,
0,
'+08',
    ],
];

sub olson_version {'2019c'}

sub has_dst_changes {1}

sub _max_year {2029}

sub _new_instance {
    return shift->_init( @_, spans => $spans );
}



1;

