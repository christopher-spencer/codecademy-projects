import {
    RaccoonMeadowsVolunteers,
    RaccoonMeadowsActivity,
    raccoonMeadowsVolunteers,
  } from './raccoon-meadows-log';
  
  import {
    WolfPointVolunteers,
    WolfPointActivity,
    wolfPointVolunteers,
  } from './wolf-point-log';
  
  type CombinedActivity = RaccoonMeadowsActivity | WolfPointActivity;
  
  type Volunteers = {
    id: number;
    name: string;
    activities: CombinedActivity[];
  };
  
  function combineVolunteers(volunteers: (RaccoonMeadowsVolunteers | WolfPointVolunteers)[]) {
    return volunteers.map(volunteer => {
      let id = volunteer.id;
  
      if (typeof id === 'string') {
        /*
        parseInt() is a function that takes two arguments: a string to parse and a number for what 
        the integer should be based on. The most typical base is base 10. Since 10 is not the default 
        base, we must provide it as an argument. (e.g. parseInt('400sg', 10) would return 400, because 
        it stops parsing as soon as it encounters the non-numeric character 's'. Everything before that
        ('400') is a valid base-10 number. The rest of the string ('sg') is ignored.)
        */
        id = parseInt(id, 10);
      }
      return { 
        id: id, 
        name: volunteer.name, 
        activities: volunteer.activities 
      };
    });
  }
  
  function isVerified(verified: string | boolean) {
    if (typeof verified === 'string') {
      return verified === 'Yes';
    }
  
    return verified;
  }
  
  function getHours(activity: CombinedActivity) {
    if ('hours' in activity) {
      return activity.hours;
    } else {
      return activity.time;
    }
  }
  
  function calculateHours(volunteers: Volunteers[]) {
    return volunteers.map((volunteer) => {
      let hours = 0;
  
      volunteer.activities.forEach((activity) => {
        if (isVerified(activity.verified)) {
          hours = hours + getHours(activity);
        }
      });
  
      return {
        id: volunteer.id,
        name: volunteer.name,
        hours: hours,
      };
    });
  }
  
  function byHours(a, b) {
    return b.hours - a.hours;
  }
  
  const combinedVolunteers = combineVolunteers(
    [].concat(wolfPointVolunteers, raccoonMeadowsVolunteers)
  );
  
  //console.log(combinedVolunteers);
  let result = calculateHours(combinedVolunteers);
  //console.log(result);
  console.log(result.sort(byHours));