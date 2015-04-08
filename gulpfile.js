var gulp = require('gulp');
var concat = require('gulp-concat');
var rename = require('gulp-rename');
var uglify = require('gulp-uglify');

gulp.task('build', function() {
   return gulp.src('src/mpAutocomplete.js')        
        .pipe(gulp.dest('./build'))
        .pipe(rename({suffix: '.min'}))
        .pipe(uglify())        
        .pipe(gulp.dest('./build'));
});