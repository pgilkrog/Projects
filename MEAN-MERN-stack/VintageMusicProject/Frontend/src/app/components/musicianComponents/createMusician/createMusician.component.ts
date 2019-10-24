import { Component, OnInit } from '@angular/core';
import { MusicianService } from 'src/app/services/musician.service';
import { Musician } from 'src/app/models/musician.model';
import { NgForm, FormGroup, FormControl, Validators } from '@angular/forms';
import { mimeType } from './mime-type.validator';

@Component({
  selector: 'app-createmusician',
  templateUrl: './createMusician.component.html'
})

export class CreateMusicianComponent implements OnInit {
  form: FormGroup;
  imagePreview: string;

  constructor(private musicianService: MusicianService) { }

  ngOnInit() {
    this.form = new FormGroup({
      name: new FormControl(null, {
        validators: [Validators.required]
      }),
      realname: new FormControl(null, {
        validators: [Validators.required]
      }),
      description: new FormControl(null, {
        validators: [Validators.required]
      }),
      image: new FormControl(null, {
        validators: [Validators.required],
        asyncValidators: [mimeType]
      }),
      birth: new FormControl(null, {
        validators: [Validators.required]
      }),
      death: new FormControl(null, {
        validators: [Validators.required]
      })
    });
  }

  createMusician() {
    const musician = new Musician();
    musician.name = this.form.value.name;
    musician.realname = this.form.value.realname;
    musician.description = this.form.value.description;
    musician.birth = new Date(this.form.value.birth);
    musician.death = new Date(this.form.value.death);

    this.musicianService.createMusician(musician, this.form.value.image);

    this.form.reset();
  }

  onImagePicked(event: Event) {
    const file = (event.target as HTMLInputElement).files[0];
    this.form.patchValue({image: file});
    this.form.get('image').updateValueAndValidity();
    const reader = new FileReader();
    reader.onload = () => {
      this.imagePreview = reader.result as string;
    };
    reader.readAsDataURL(file);
  }
}
