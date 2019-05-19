<template>
  <form @click.stop dir='auto'>
    <h1>{{ countryCode }}</h1><br />
    <select id="country-select" @change="setCountry" required>
        <option value="" disabled selected hidden> country </option>
        <option 
            v-for="(country, index) in countryList" 
            :key="country.name" 
            :value="index">
                {{ country.name }}
        </option>
    </select>
    <pre class="meta">{{ countryMetaData }}</pre>
  </form>
</template>

<script>
export default {
  name: 'CountrySelect',
  data() {
      return {
          countryCode: '',
          countryList: []
      }
  },
  computed: {
      countryMetaData() {
          return JSON.stringify(this.countryList[this.countryCode], null, 2);
      }
  },
  methods: {
    setCountry(event) {
      event.stopPropagation()
      this.countryCode = event.target.value;
    },
    populateCountries() {
        fetch('/i18n/countries.json')
            .then(response => response.json())
            .then(countries => this.countryList = countries)
    },
    setLocation() {
        fetch('https://json.geoiplookup.io/', {
                headers: {
                    "Accept": "application/json",
                }
            })
            .then(response => response.json())
            .then(country => this.countryCode = country.country_code)
    }
  },
  created() {
      this.populateCountries();
      this.setLocation();
  }
}
</script>

<style scoped>
h1 {
  height: 150px;
}
select:invalid { color: gray; }
select:required:invalid  { color: gray; }
option[value=""][disabled] {
  display: none;
}
option {
  color: #2c3e50;
  cursor: pointer;
}
.meta {
    text-align: left;
    font-family: monospace;
    font-size: 12px;
    margin: 32px auto;
    width: 25%;
}
</style>
